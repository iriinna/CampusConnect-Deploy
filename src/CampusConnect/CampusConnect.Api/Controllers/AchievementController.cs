using CampusConnect.Application.DTOs.Achievements;
using CampusConnect.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CampusConnect.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AchievementController : ControllerBase
{
    private readonly IAchievementService _achievementService;

    public AchievementController(IAchievementService achievementService)
    {
        _achievementService = achievementService;
    }

    // GET: api/achievement
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AchievementResponse>>> GetAllAchievements()
    {
        var achievements = await _achievementService.GetAllAchievementsAsync();
        return Ok(achievements);
    }

    // GET: api/achievement/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<AchievementResponse>> GetAchievementById(int id)
    {
        var achievement = await _achievementService.GetAchievementByIdAsync(id);
        if (achievement == null)
            return NotFound();

        return Ok(achievement);
    }

    // GET: api/achievement/user/{userId}
    [Authorize]
    [HttpGet("user/{userId}")]
    public async Task<ActionResult<IEnumerable<UserAchievementResponse>>> GetUserAchievements(int userId)
    {
        var achievements = await _achievementService.GetUserAchievementsAsync(userId);
        return Ok(achievements);
    }

    // GET: api/achievement/my
    [Authorize]
    [HttpGet("my")]
    public async Task<ActionResult<IEnumerable<UserAchievementResponse>>> GetMyAchievements()
    {
        try
        {
            var achievements = await _achievementService.GetMyAchievementsAsync();
            return Ok(achievements);
        }
        catch (UnauthorizedAccessException)
        {
            return Unauthorized();
        }
    }

    // POST: api/achievement
    [Authorize(Roles = "Admin")]
    [HttpPost]
    public async Task<ActionResult<AchievementResponse>> CreateAchievement([FromBody] CreateAchievementRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var achievement = await _achievementService.CreateAchievementAsync(request);
        return CreatedAtAction(nameof(GetAchievementById), new { id = achievement.Id }, achievement);
    }

    // PUT: api/achievement/{id}
    [Authorize(Roles = "Admin")]
    [HttpPut("{id}")]
    public async Task<ActionResult<AchievementResponse>> UpdateAchievement(int id, [FromBody] UpdateAchievementRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var achievement = await _achievementService.UpdateAchievementAsync(id, request);
        if (achievement == null)
            return NotFound();

        return Ok(achievement);
    }

    // DELETE: api/achievement/{id}
    [Authorize(Roles = "Admin")]
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteAchievement(int id)
    {
        var result = await _achievementService.DeleteAchievementAsync(id);
        if (!result)
            return NotFound();

        return NoContent();
    }
}
