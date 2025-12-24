
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using CampusConnect.Application.Interfaces;
using CampusConnect.Application.DTOs;

namespace CampusConnect.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")] 
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
    [HttpGet("search")]
    public async Task<IActionResult> SearchUsers([FromQuery] string? search)
    {
        var users = await _userService.SearchUsersAsync(search ?? "");
        
        var response = users.Select(u => new 
        {
            id = u.Id,
            firstName = u.FirstName,
            lastName = u.LastName,
            profilePictureUrl = u.ProfilePictureUrl,
            studentId = u.StudentId,
            dateofBirth = u.DateOfBirth
        });

        return Ok(response);
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

        [HttpGet("details")]
        public async Task<IActionResult> GetUserDetails()
        {
            var userId = GetCurrentUserId();
            if (userId == null)
            {
                return Unauthorized(new { message = "ID-ul utilizatorului nu a putut fi extras din token." });
            }

            var user = await _userService.GetUserByIdAsync(userId.Value);

            if (user == null)
            {
                return NotFound(new { message = "Profilul utilizatorului nu a fost gasit." });
            }

            var responseDto = new UserProfileResponse
            {
                Id=user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl,
                DateofBirth = user.DateOfBirth, 
                StudentId = user.StudentId
            };
            
            return Ok(responseDto);
        }


        [HttpGet("public-details/{id}")]
        public async Task<IActionResult> GetPublicUserDetails(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null) return NotFound();

            return Ok(new {
                id = user.Id,
                firstName = user.FirstName,
                lastName = user.LastName,
                studentId = user.StudentId,
                profilePictureUrl = user.ProfilePictureUrl,
                dateOfBirth = user.DateOfBirth 
            });
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserProfileRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
            }

            var userId = GetCurrentUserId();
            if (userId == null)
            {
                return Unauthorized(new { message = "ID-ul utilizatorului nu a putut fi extras din token." });
            }

            var success = await _userService.UpdateUserProfileAsync(userId.Value, model);

            if (success)
            {
                return Ok(new { message = "Profil actualizat cu succes!" });
            }
            
            return NotFound(new { message = "Eroare. Utilizatorul nu a fost gasit." });
        }

        [HttpDelete("delete/{id?}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUser(int? id)
        {
            var currentUserId = GetCurrentUserId();
            if (currentUserId == null)
            {
                return Unauthorized(new { message = "ID-ul utilizatorului nu a putut fi extras din token." });
            }

            int targetId = id ?? currentUserId.Value;
            var isAdmin = User.IsInRole("Admin");

            if (targetId != currentUserId && !isAdmin)
            {
                return Unauthorized(); 
            }

            var success = await _userService.DeleteUserAsync(targetId);
            if (success)
            {
                return NoContent();
            }

            return NotFound(new { message = "Eroare. Utilizatorul nu a fost găsit." });
        }
    }
}