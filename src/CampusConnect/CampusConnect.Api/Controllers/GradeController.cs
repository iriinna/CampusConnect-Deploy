using CampusConnect.Application.DTOs.Grades;
using CampusConnect.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CampusConnect.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class GradeController : ControllerBase
{
    private readonly IGradeService _gradeService;

    public GradeController(IGradeService gradeService)
    {
        _gradeService = gradeService;
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

    [HttpGet("student/{studentId}")]
    public async Task<ActionResult<IEnumerable<GradeDto>>> GetStudentGrades(int studentId)
    {
        var grades = await _gradeService.GetStudentGradesAsync(studentId);
        return Ok(grades);
    }

    [HttpGet("my-grades")]
    public async Task<ActionResult<IEnumerable<GradeDto>>> GetMyGrades()
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            return Unauthorized();

        var grades = await _gradeService.GetStudentGradesAsync(userId.Value);
        return Ok(grades);
    }

    [HttpGet("subject/{subjectId}")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<IEnumerable<GradeDto>>> GetSubjectGrades(int subjectId)
    {
        var grades = await _gradeService.GetSubjectGradesAsync(subjectId);
        return Ok(grades);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GradeDto>> GetGradeById(int id)
    {
        var grade = await _gradeService.GetGradeByIdAsync(id);
        if (grade == null)
            return NotFound();

        return Ok(grade);
    }

    [HttpPost]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<GradeDto>> CreateGrade([FromBody] CreateGradeRequest request)
    {
        try
        {
            var grade = await _gradeService.CreateGradeAsync(request);
            return CreatedAtAction(nameof(GetGradeById), new { id = grade.Id }, grade);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<GradeDto>> UpdateGrade(int id, [FromBody] UpdateGradeRequest request)
    {
        var grade = await _gradeService.UpdateGradeAsync(id, request);
        if (grade == null)
            return NotFound();

        return Ok(grade);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult> DeleteGrade(int id)
    {
        var result = await _gradeService.DeleteGradeAsync(id);
        if (!result)
            return NotFound();

        return NoContent();
    }
}
