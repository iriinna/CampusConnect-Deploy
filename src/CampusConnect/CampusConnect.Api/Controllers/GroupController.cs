using CampusConnect.Application.DTOs.Groups;
using CampusConnect.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CampusConnect.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class GroupController : ControllerBase
{
    private readonly IGroupService _groupService;

    public GroupController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    // Group Management
    [HttpPost]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<GroupResponse>> CreateGroup([FromBody] CreateGroupRequest request)
    {
        try
        {
            var group = await _groupService.CreateGroupAsync(request);
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
    public async Task<ActionResult<GroupResponse>> GetGroupById(int id)
    {
        var group = await _groupService.GetGroupByIdAsync(id);
        if (group == null)
            return NotFound(new { message = "Group not found" });

        return Ok(group);
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
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult> DeleteGroup(int id)
    {
        try
        {
            var result = await _groupService.DeleteGroupAsync(id);
            if (!result)
                return NotFound(new { message = "Group not found" });

            return Ok(new { message = "Group deleted successfully" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Forbid(ex.Message);
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

            return Ok(new { message = "Successfully left the group" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }

    // Task Management
    [HttpPost("{groupId}/tasks")]
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult<GroupTaskResponse>> CreateTask(int groupId, [FromBody] CreateTaskRequest request)
    {
        try
        {
            var task = await _groupService.CreateTaskAsync(groupId, request);
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
    [Authorize(Roles = "Professor,Admin")]
    public async Task<ActionResult> DeleteTask(int taskId)
    {
        try
        {
            var result = await _groupService.DeleteTaskAsync(taskId);
            if (!result)
                return NotFound(new { message = "Task not found" });

            return Ok(new { message = "Task deleted successfully" });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Forbid(ex.Message);
        }
    }

    // Saved Tasks
    [HttpPost("tasks/{taskId}/save")]
    public async Task<ActionResult> SaveTask(int taskId)
    {
        try
        {
            var result = await _groupService.SaveTaskAsync(taskId);
            if (!result)
                return BadRequest(new { message = "Task not found or already saved" });

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
