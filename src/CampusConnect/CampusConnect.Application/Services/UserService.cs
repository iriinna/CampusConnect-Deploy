using CampusConnect.Application.DTOs;
using CampusConnect.Application.Interfaces;
using CampusConnect.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace CampusConnect.Application.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApplicationUser?> GetUserByIdAsync(int userId)
        {
            return await _userManager.FindByIdAsync(userId.ToString());
        }

        public async Task<bool> UpdateUserProfileAsync(int userId, UpdateUserProfileRequest profileData)
        {
           var user = await GetUserByIdAsync(userId);
            if (user == null) return false;

            if (!string.IsNullOrEmpty(profileData.DateOfBirth))
            {
                if (DateTime.TryParseExact(profileData.DateOfBirth, "yyyy-MM-dd", 
                               System.Globalization.CultureInfo.InvariantCulture, 
                               System.Globalization.DateTimeStyles.None, 
                               out DateTime dob))
    
               {
                    user.DateOfBirth = dob;
                }
            }
            else
            {
                user.DateOfBirth = null;
            }

            user.FirstName = profileData.FirstName;
            user.LastName = profileData.LastName;
            user.StudentId = profileData.StudentId;
            user.ProfilePictureUrl = profileData.ProfilePictureUrl;

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }
        
        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await GetUserByIdAsync(userId);

            if (user == null)
            {
                return false; 
            }

            var result = await _userManager.DeleteAsync(user);

            return result.Succeeded;
        }
    }
}