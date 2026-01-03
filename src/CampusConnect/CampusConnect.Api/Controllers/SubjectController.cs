using CampusConnect.Application.DTOs.Subjects;
using CampusConnect.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CampusConnect.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class SubjectController : ControllerBase
{
    private readonly ISubjectService _subjectService;

    public SubjectController(ISubjectService subjectService)
    {
        _subjectService = subjectService;
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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SubjectDto>>> GetAllSubjects()
    {
        var subjects = await _subjectService.GetAllSubjectsAsync();
        return Ok(subjects);
    }

    [HttpGet("professor/{professorId}")]
    public async Task<ActionResult<IEnumerable<SubjectDto>>> GetProfessorSubjects(int professorId)
    {
        var subjects = await _subjectService.GetProfessorSubjectsAsync(professorId);
        return Ok(subjects);
    }

    [HttpGet("my-subjects")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<IEnumerable<SubjectDto>>> GetMySubjects()
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            return Unauthorized();

        var subjects = await _subjectService.GetProfessorSubjectsAsync(userId.Value);
        return Ok(subjects);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SubjectDto>> GetSubjectById(int id)
    {
        var subject = await _subjectService.GetSubjectByIdAsync(id);
        if (subject == null)
            return NotFound();

        return Ok(subject);
    }

    [HttpPost]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<SubjectDto>> CreateSubject([FromBody] CreateSubjectRequest request)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            return Unauthorized();

        try
        {
            var subject = await _subjectService.CreateSubjectAsync(userId.Value, request);
            return CreatedAtAction(nameof(GetSubjectById), new { id = subject.Id }, subject);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<SubjectDto>> UpdateSubject(int id, [FromBody] UpdateSubjectRequest request)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            return Unauthorized();

        var subject = await _subjectService.UpdateSubjectAsync(id, userId.Value, request);
        if (subject == null)
            return NotFound();

        return Ok(subject);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult> DeleteSubject(int id)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            return Unauthorized();

        var result = await _subjectService.DeleteSubjectAsync(id, userId.Value);
        if (!result)
            return NotFound();

        return NoContent();
    }
}
