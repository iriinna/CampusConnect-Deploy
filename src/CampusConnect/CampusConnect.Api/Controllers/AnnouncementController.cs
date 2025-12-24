using CampusConnect.Domain.Entities;
using CampusConnect.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
[ApiController]
[Route("api/[controller]")]
public class AnnouncementsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AnnouncementsController(ApplicationDbContext context)
    {
        _context = context;
    }
    private int? GetCurrentUserId()
{
    var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

    if (string.IsNullOrEmpty(userIdClaim))
    {
        userIdClaim = User.FindFirst("id")?.Value;
    }

    if (string.IsNullOrEmpty(userIdClaim))
    {
        userIdClaim = User.FindFirst(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub)?.Value;
    }

    if (userIdClaim != null && int.TryParse(userIdClaim, out int userId))
    {
        return userId;
    }
    return null;
}

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Announcement>>> GetAll([FromQuery] string? category, [FromQuery] string? search)
    {
        var query = _context.Announcements.AsQueryable();

        if (!string.IsNullOrWhiteSpace(category))
        {
            query = query.Where(a => a.Category == category);
        }

        if (!string.IsNullOrWhiteSpace(search))
        {
            search = search.Trim().ToLower();
            query = query.Where(a => a.Title.ToLower().Contains(search) 
                                || a.Content.ToLower().Contains(search));
        }

        var list = await query
            .OrderByDescending(a => a.CreatedAt)
            .ToListAsync();

        return Ok(list);
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var announcement = await _context.Announcements.FindAsync(id);
        if (announcement == null) return NotFound();
        return Ok(announcement);
    }

[Authorize] 
[HttpPost]
public async Task<IActionResult> Create(Announcement announcement)
{
    var userId = GetCurrentUserId();
    if (userId == null) return Unauthorized();

    announcement.CreatedByUserId = userId.Value; 
    if (announcement.CreatedAt == default) announcement.CreatedAt = DateTime.UtcNow;

    _context.Announcements.Add(announcement);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetById), new { id = announcement.Id }, announcement);
}

[Authorize]
[HttpPut("{id}")]
public async Task<IActionResult> Update(int id, Announcement updated)
{
    var announcement = await _context.Announcements.FindAsync(id);
    if (announcement == null) return NotFound();
    var userId = GetCurrentUserId();
    var isAdmin = User.IsInRole("Admin"); 
    
    if (announcement.CreatedByUserId != userId && !isAdmin)
    {
        return Forbid(); 
    }

    announcement.Title = updated.Title;
    announcement.Content = updated.Content;
    await _context.SaveChangesAsync();

    return NoContent();
}

[Authorize]
[HttpDelete("{id}")]
public async Task<IActionResult> Delete(int id)
{
    var announcement = await _context.Announcements.FindAsync(id);
    if (announcement == null) return NotFound();

    var userId = GetCurrentUserId();
    var isAdmin = User.IsInRole("Admin"); 

    if (announcement.CreatedByUserId != userId && !isAdmin)
    {
        return Forbid();
    }

    _context.Announcements.Remove(announcement);
    await _context.SaveChangesAsync();

    return NoContent();
}


    [Authorize]
    [HttpPost("{id}/bookmark")]
    public async Task<IActionResult> Bookmark(int id)
    {
        var userId = GetCurrentUserId();
        if (userId == null) return Unauthorized();

        var exists = await _context.SavedAnnouncements
            .AnyAsync(sa => sa.UserId == userId.Value && sa.AnnouncementId == id);

        if (exists)
        {
            return BadRequest(new { message = "Announcement already bookmarked." });
        }

        var saved = new SavedAnnouncement
        {
            UserId = userId.Value,
            AnnouncementId = id
        };

        _context.SavedAnnouncements.Add(saved);
        await _context.SaveChangesAsync();

        return Ok();
    }

    
    [Authorize]
    [HttpDelete("{id}/bookmark")]
    public async Task<IActionResult> Unbookmark(int id)
    {
        var userId = GetCurrentUserId();
        if (userId == null) return Unauthorized();

        var saved = await _context.SavedAnnouncements
            .FirstOrDefaultAsync(sa => sa.UserId == userId.Value && sa.AnnouncementId == id);

        if (saved == null) return NotFound();

        _context.SavedAnnouncements.Remove(saved);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    
    [Authorize]
    [HttpGet("saved")]
    public async Task<ActionResult<IEnumerable<Announcement>>> GetSaved()
    {
        var userId = GetCurrentUserId();
        if (userId == null) return Unauthorized();

        var announcements = await _context.SavedAnnouncements
            .Where(sa => sa.UserId == userId.Value)
            .Select(sa => sa.Announcement)
            .OrderByDescending(a => a.CreatedAt)
            .ToListAsync();

        return Ok(announcements);
    }

}
