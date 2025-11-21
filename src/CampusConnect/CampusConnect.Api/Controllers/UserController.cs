using CampusConnect.Application.Features.Users.Commands.CreateUser;
using CampusConnect.Application.Features.Users.Commands.DeleteUser;
using CampusConnect.Application.Features.Users.Commands.UpdateUser;
using CampusConnect.Application.Features.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/controller")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator) => _mediator = mediator;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var query = new GetUserByIdQuery { Id = id };
        var user = await _mediator.Send(query);
        return Ok(user);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var query = new GetAllUsersQuery();
        var users = await _mediator.Send(query);
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
    {
        var newUserId = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetUserById), new { id = newUserId }, newUserId);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserCommand command)
    {
        if (id != command.UserId) return BadRequest();
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var command = new DeleteUserCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}