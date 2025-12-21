using CampusConnect.Domain.Entities;
using CampusConnect.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace CampusConnect.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
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

        [HttpGet("upcoming")]
        public async Task<ActionResult<IEnumerable<Event>>> GetUpcomingEvents()
        {
            var events = await _context.Events
                .Where(e => e.Date > DateTime.UtcNow) 
                .Include(e => e.Participants)
                .OrderBy(e => e.Date) 
                .ToListAsync();

            return Ok(events);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var eventItem = await _context.Events
                .Include(e => e.Participants) 
                .FirstOrDefaultAsync(e => e.Id == id);

            if (eventItem == null) return NotFound();
            return Ok(eventItem);
        }

        [HttpPost]
        [Authorize] 
        public async Task<IActionResult> Create(Event eventItem)
        {
            var userId = GetCurrentUserId();
            if (userId == null) return Unauthorized();

            eventItem.OrganizerId = userId.Value;
            eventItem.DateCreated = DateTime.UtcNow;

            _context.Events.Add(eventItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = eventItem.Id }, eventItem);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Update(int id, Event updatedEvent)
        {
            var userId = GetCurrentUserId();
            var existingEvent = await _context.Events.FindAsync(id);

            if (existingEvent == null) return NotFound();
            if (userId != existingEvent.OrganizerId) 
            {
                return Unauthorized(); 
            }

            existingEvent.Title = updatedEvent.Title;
            existingEvent.Description = updatedEvent.Description;
            existingEvent.Date = updatedEvent.Date;
            existingEvent.Category = updatedEvent.Category;
            
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = GetCurrentUserId();
            var eventItem = await _context.Events.FindAsync(id);

            if (eventItem == null) return NotFound();

            if (userId!= eventItem.OrganizerId)
            {
                return Unauthorized();
            }

            _context.Events.Remove(eventItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("{id}/join")]
        [Authorize]
        public async Task<IActionResult> Participate(int id)
        {
            var userId = GetCurrentUserId();
            if (userId == null) return Unauthorized();

            var eventItem = await _context.Events
                .Include(e => e.Participants)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (eventItem == null) return NotFound();

            // Verificare: Să nu participe de două ori
            if (eventItem.Participants.Any(p => p.UserId == userId.Value))
            {
                return BadRequest("Deja participi la acest eveniment.");
            }

            var participation = new EventParticipant
            {
                EventId = id,
                UserId = userId.Value,
                JoinedAt = DateTime.UtcNow
            };

            _context.EventParticipants.Add(participation);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}/leave")]
        [Authorize]
        public async Task<IActionResult> Withdraw(int id)
        {
            var userId = GetCurrentUserId();
            if (userId == null) return Unauthorized();

            var eventItem = await _context.Events
                .Include(e => e.Participants)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (eventItem == null) return NotFound();

            var participation = eventItem.Participants.FirstOrDefault(p => p.UserId == userId.Value);
            if (participation == null)
            {
                return BadRequest("Nu participi la acest eveniment.");
            }

            _context.EventParticipants.Remove(participation);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}