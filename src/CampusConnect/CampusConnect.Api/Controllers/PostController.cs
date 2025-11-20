using CampusConnect.Application.Features.Posts.Commands.AddPost;
using CampusConnect.Application.Features.Posts.Commands.DeletePost;
using CampusConnect.Application.Features.Posts.Commands.UpdatePost;
using CampusConnect.Application.Features.Posts.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/posts")]
public class PostsController : ControllerBase
{
    private readonly IMediator _mediator;

    public PostsController(IMediator mediator) => _mediator = mediator;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPostById(int id)
    {
        var query = new GetPostByIdQuery { Id = id };
        var post = await _mediator.Send(query);
        return Ok(post);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePost([FromBody] CreatePostCommand command)
    {
        var newPostId = await _mediator.Send(command);
        // Returneaza 201 Created si locatia noii resurse
        return CreatedAtAction(nameof(GetPostById), new { id = newPostId }, newPostId);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePost(int id, [FromBody] UpdatePostCommand command)
    {
        if (id != command.Id) return BadRequest();

        await _mediator.Send(command);
        return NoContent(); 
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePost(int id)
    {
        var command = new DeletePostCommand { Id = id };
        await _mediator.Send(command);
        return NoContent(); 
    }
}