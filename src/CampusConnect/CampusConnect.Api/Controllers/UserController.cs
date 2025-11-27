using CampusConnect.Application.Features.Users.Commands.CreateUser;
using CampusConnect.Application.Features.Users.Commands.DeleteUser;
using CampusConnect.Application.Features.Users.Commands.UpdateUser;
using CampusConnect.Application.Features.Users.Commands.LoginUser;
using CampusConnect.Application.Features.Users.Queries;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IConfiguration _configuration;

    public UsersController(IMediator mediator, IConfiguration configuration) 
    {
        _mediator = mediator;
        _configuration = configuration;
    }

    // Metoda Privată de Generare Token (trebuie să fie în aceeași clasă sau într-un serviciu separat)
    private string GenerateJwtToken(string userId, string userName)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]); // Folosește _configuration
        
        // ... restul logicii JWT (este corectă) ...
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Name, userName),
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature
            )
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    // Endpoint-ul NOU pentru Login

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
    {
        var loginResult = await _mediator.Send(command); 

        if (loginResult == null) return Unauthorized(new { message = "Nume de utilizator sau parolă incorectă." });

        // 💡 CORECȚIE: Folosește Numele de utilizator real pentru ClaimTypes.Name
        var token = GenerateJwtToken(
        loginResult.UserId.ToString(), 
        loginResult.Email // <-- Folosește Username-ul real
    );
        return Ok(new { Token = token, Expires = DateTime.UtcNow.AddDays(7) });
    }
    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var query = new GetUserByIdQuery { Id = id };
        var user = await _mediator.Send(query);
        return Ok(user);
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var query = new GetAllUsersQuery();
        var users = await _mediator.Send(query);
        return Ok(users);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
    {
        var newUserId = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetUserById), new { id = newUserId }, newUserId);
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserCommand command)
    {
        if (id != command.UserId) return BadRequest();
        await _mediator.Send(command);
        return NoContent();
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var command = new DeleteUserCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}