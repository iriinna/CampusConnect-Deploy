using CampusConnect.Application.DTOs.Groups;
using CampusConnect.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using CampusConnect.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using CampusConnect.Domain.Entities;

namespace CampusConnect.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class GroupController : ControllerBase
{
    private readonly IGroupService _groupService;
    private readonly ApplicationDbContext _context;
    private readonly IAchievementService _achievementService;
    private readonly IActivityLoggerService _activityLogger;

    public GroupController(IGroupService groupService, ApplicationDbContext context, IAchievementService achievementService, IActivityLoggerService activityLogger)
    {
        _groupService = groupService;
        _context = context;
        _achievementService = achievementService;
        _activityLogger = activityLogger;
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
    
    [HttpPost]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<GroupResponse>> CreateGroup([FromBody] CreateGroupRequest request)
    {
        try
        {
            var group = await _groupService.CreateGroupAsync(request);
            await _activityLogger.LogActivityAsync(GetCurrentUserId().Value, "Create", "Group", group.Id, group.Name, "Created a new group");
            return Ok(group);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Forbid(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GroupResponse>>> GetAllGroups()
    {
        var groups = await _groupService.GetAllGroupsAsync();
        return Ok(groups);
    }

    [HttpGet("{id}")]
public async Task<ActionResult<object>> GetGroupById(int id)
{
    var group = await _context.Groups // sau _context.StudyGroups
        .Include(g => g.Members) // <--- LINIA ASTA LIPSEȘTE SAU NU MERGE
        .FirstOrDefaultAsync(g => g.Id == id);

    if (group == null) return NotFound();
     return Ok(new 
    {
        group.Id,
        group.Name,
        group.Subject,
        group.Description,
        group.ProfessorId,
        // Trimitem lista explicit:
        Members = group.Members.Select(gm => new { 
            // Verifică în modelul tău GroupMember cum se numește câmpul cu ID-ul studentului
            // Poate fi UserId sau StudentId
            StudentId = gm.UserId 
        }).ToList()
    });
}
    [HttpGet("my-groups")]
    public async Task<ActionResult<IEnumerable<GroupResponse>>> GetMyGroups()
    {
        try
        {
            var groups = await _groupService.GetMyGroupsAsync();
            return Ok(groups);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpGet("created-by-me")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<IEnumerable<GroupResponse>>> GetGroupsCreatedByMe()
    {
        try
        {
            var groups = await _groupService.GetGroupsCreatedByMeAsync();
            return Ok(groups);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpGet("available")]
    public async Task<ActionResult<IEnumerable<GroupResponse>>> GetAvailableGroups()
    {
        try
        {
            var groups = await _groupService.GetAvailableGroupsAsync();
            return Ok(groups);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpDelete("{id}")]
    [Authorize] 
    public async Task<ActionResult> DeleteGroup(int id)
    {
        try
        {
            var userId = GetCurrentUserId();
            var isAdmin = User.IsInRole("Admin");

            var group = await _groupService.GetGroupByIdAsync(id);
            if (group == null) 
                return NotFound(new { message = "Group not found" });

            if (!isAdmin && group.ProfessorId != userId)
            {
                return Forbid();
            }

            var result = await _groupService.DeleteGroupAsync(id);
            if (!result)
                return NotFound(new { message = "Group not found" });
            await _activityLogger.LogActivityAsync(userId.Value, "Delete", "Group", group.Id, group.Name, "Deleted a group");
            return Ok(new { message = "Group deleted successfully" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Forbid(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    // Group Membership
    [HttpPost("{id}/join")]
    public async Task<ActionResult> JoinGroup(int id)
    {
        try
        {
            var result = await _groupService.JoinGroupAsync(id);
            if (!result)
                return BadRequest(new { message = "Could not join group. You may already be a member." });

            var userId = GetCurrentUserId();
            if (userId.HasValue)
            {
                await _achievementService.CheckAndGrantGroupAchievementAsync(userId.Value);
            }
            await _activityLogger.LogActivityAsync(userId.Value, "Join", "Group", id, null, "Joined a group");
            return Ok(new { message = "Successfully joined the group" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpPost("{id}/leave")]
    public async Task<ActionResult> LeaveGroup(int id)
    {
        try
        {
            var result = await _groupService.LeaveGroupAsync(id);
            if (!result)
                return BadRequest(new { message = "You are not a member of this group" });
            var userId = GetCurrentUserId();
            await _activityLogger.LogActivityAsync(userId.Value, "Leave", "Group", id, null, "Left a group");
            return Ok(new { message = "Successfully left the group" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpPost("{groupId}/tasks")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<GroupTaskResponse>> CreateTask(int groupId, [FromBody] CreateTaskRequest request)
    {
        try
        {
            var task = await _groupService.CreateTaskAsync(groupId, request);
            
            var currentUserId = GetCurrentUserId();
            
            var groupInfo = await _context.Groups
                .Include(g => g.Members)
                .Where(g => g.Id == groupId)
                .Select(g => new { 
                    g.Name, 
                    MemberIds = g.Members.Select(m => m.UserId).ToList() 
                })
                .FirstOrDefaultAsync();

            if (groupInfo != null && currentUserId.HasValue)
            {
                var membersToNotify = groupInfo.MemberIds
                    .Where(uid => uid != currentUserId.Value)
                    .ToList();

                if (membersToNotify.Any())
                {
                    var notifications = membersToNotify.Select(userId => new Notification
                    {
                        UserId = userId,
                        Message = $"Task nou în grupul '{groupInfo.Name}': {task.Title}",
                        RelatedEntityType = "GroupTask", 
                        RelatedEntityId = groupId,       
                        CreatedAt = DateTime.UtcNow,
                        IsRead = false
                    });

                    _context.Notifications.AddRange(notifications);
                    await _context.SaveChangesAsync();
                }
            }
            await _activityLogger.LogActivityAsync(currentUserId.Value, "Create", "GroupTask", task.Id, task.Title, $"Created a new task in group {groupInfo?.Name}");
            return Ok(task);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Forbid(ex.Message);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
    

    [HttpGet("{groupId}/tasks")]
    public async Task<ActionResult<IEnumerable<GroupTaskResponse>>> GetGroupTasks(int groupId)
    {
        var tasks = await _groupService.GetGroupTasksAsync(groupId);
        return Ok(tasks);
    }


    [HttpDelete("tasks/{taskId}")]
[Authorize]
public async Task<IActionResult> DeleteTask(int taskId)
{
    var userId = GetCurrentUserId();
    if (userId == null) return Unauthorized();

    var task = await _context.GroupTasks
        .Include(t => t.Group) 
        .FirstOrDefaultAsync(t => t.Id == taskId);

    if (task == null) return NotFound("Task not found");

    if (task.Group.ProfessorId != userId && !User.IsInRole("Admin"))
    {
        return StatusCode(403, new { 
            message = "Nu aveți dreptul să ștergeți acest task.",
            myId = userId,
            ownerId = task.Group.ProfessorId
        });
    }

    var savedTasks = _context.SavedTasks.Where(st => st.TaskId == taskId);
    _context.SavedTasks.RemoveRange(savedTasks);
    _context.GroupTasks.Remove(task);
    await _context.SaveChangesAsync();
    await _activityLogger.LogActivityAsync(userId.Value, "Delete", "GroupTask", task.Id, task.Title, "Deleted a task");
    return Ok(new { message = "Task deleted successfully" });
}


    [HttpPost("tasks/{taskId}/save")]
    public async Task<ActionResult> SaveTask(int taskId)
    {
        try
        {
            var result = await _groupService.SaveTaskAsync(taskId);
            if (!result)
                return BadRequest(new { message = "Task not found or already saved" });
            
            var userId = GetCurrentUserId();
            if (userId.HasValue)
            {
                await _activityLogger.LogActivityAsync(userId.Value, "Save", "GroupTask", taskId, null, "Saved a task");
            }

            return Ok(new { message = "Task saved successfully" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpDelete("tasks/{taskId}/unsave")]
    public async Task<ActionResult> UnsaveTask(int taskId)
    {
        try
        {
            var result = await _groupService.UnsaveTaskAsync(taskId);
            if (!result)
                return BadRequest(new { message = "Task not found in your saved tasks" });

            return Ok(new { message = "Task removed from saved tasks" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpPatch("tasks/{taskId}/complete")]
    public async Task<ActionResult> MarkTaskAsCompleted(int taskId)
    {
        try
        {
            var result = await _groupService.MarkTaskAsCompletedAsync(taskId);
            if (!result)
                return BadRequest(new { message = "Task not found in your saved tasks" });

            var userId = GetCurrentUserId();
            if (userId.HasValue)
            {
                await _achievementService.CheckAndGrantTaskAchievementsAsync(userId.Value);
                await _activityLogger.LogActivityAsync(userId.Value, "Complete", "GroupTask", taskId, null, "Marked a task as completed");
            }

            return Ok(new { message = "Task marked as completed" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpPatch("tasks/{taskId}/incomplete")]
    public async Task<ActionResult> MarkTaskAsIncomplete(int taskId)
    {
        try
        {
            var result = await _groupService.MarkTaskAsIncompletedAsync(taskId);
            if (!result)
                return BadRequest(new { message = "Task not found in your saved tasks" });

            return Ok(new { message = "Task marked as incomplete" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    [HttpGet("my-saved-tasks")]
    public async Task<ActionResult<IEnumerable<SavedTaskResponse>>> GetMySavedTasks()
    {
        try
        {
            var tasks = await _groupService.GetMySavedTasksAsync();
            return Ok(tasks);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }
}
