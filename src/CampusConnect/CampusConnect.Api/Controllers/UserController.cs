
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
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl,
                DateofBirth = user.DateOfBirth, 
                StudentId = user.StudentId
            };
            
            return Ok(responseDto);
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

        [HttpDelete("delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)] 
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUser()
        {
            var userId = GetCurrentUserId();
            if (userId == null)
            {
                return Unauthorized(new { message = "ID-ul utilizatorului nu a putut fi extras din token." });
            }

            var success = await _userService.DeleteUserAsync(userId.Value);

            if (success)
            {
                return NoContent(); 
            }
            
            return NotFound(new { message = "Eroare. Utilizatorul nu a fost gasit." });
        }
    }
}