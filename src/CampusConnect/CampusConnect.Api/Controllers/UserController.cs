<<<<<<< HEAD
﻿using CampusConnect.Application.Features.Users.Commands.CreateUser;
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
=======
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using CampusConnect.Application.Interfaces;
using CampusConnect.Application.DTOs;

namespace CampusConnect.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")] 
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        private int? GetCurrentUserId()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim != null && int.TryParse(userIdClaim, out int userId))
            {
                return userId;
            }
            return null;
        }

        [HttpGet("details")]
        public async Task<IActionResult> GetUserDetails()
        {
            var userId = GetCurrentUserId();
            if (userId == null)
            {
                return Unauthorized(new { message = "ID-ul utilizatorului nu a putut fi extras din token." });
            }

            var user = await _userService.GetUserByIdAsync(userId.Value);

            if (user == null)
            {
                return NotFound(new { message = "Profilul utilizatorului nu a fost gasit." });
            }

            var responseDto = new UserProfileResponse
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl,
                DateofBirth = user.DateOfBirth, 
                StudentId = user.StudentId
            };
            
            return Ok(responseDto);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserProfileRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
            }

            var userId = GetCurrentUserId();
            if (userId == null)
            {
                return Unauthorized(new { message = "ID-ul utilizatorului nu a putut fi extras din token." });
            }

            var success = await _userService.UpdateUserProfileAsync(userId.Value, model);

            if (success)
            {
                return Ok(new { message = "Profil actualizat cu succes!" });
            }
            
            return NotFound(new { message = "Eroare. Utilizatorul nu a fost gasit." });
        }

        [HttpDelete("delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)] 
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUser()
        {
            var userId = GetCurrentUserId();
            if (userId == null)
            {
                return Unauthorized(new { message = "ID-ul utilizatorului nu a putut fi extras din token." });
            }

            var success = await _userService.DeleteUserAsync(userId.Value);

            if (success)
            {
                return NoContent(); 
            }
            
            return NotFound(new { message = "Eroare. Utilizatorul nu a fost gasit." });
        }
>>>>>>> main
    }
}