using CampusConnect.Domain.Entities;
using CampusConnect.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class AnnouncementsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AnnouncementsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var announcements = await _context.Announcements.ToListAsync();
        return Ok(announcements);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var announcement = await _context.Announcements.FindAsync(id);
        if (announcement == null) return NotFound();
        return Ok(announcement);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Announcement announcement)
    {
        _context.Announcements.Add(announcement);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = announcement.Id }, announcement);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Announcement updated)
    {
        var announcement = await _context.Announcements.FindAsync(id);
        if (announcement == null) return NotFound();

        announcement.Title = updated.Title;
        announcement.Content = updated.Content;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var announcement = await _context.Announcements.FindAsync(id);
        if (announcement == null) return NotFound();

        _context.Announcements.Remove(announcement);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
