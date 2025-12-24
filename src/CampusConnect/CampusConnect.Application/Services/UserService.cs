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

        public async Task<IEnumerable<ApplicationUser>> SearchUsersAsync(string search)
        {
            var usersQuery = _userManager.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                usersQuery = usersQuery.Where(u => u.FirstName.ToLower().Contains(search) 
                                               || u.LastName.ToLower().Contains(search));
            }

            return await Task.FromResult(usersQuery.ToList());
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
        public async Task<string> ToggleAdminRoleAsync(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) return null; 

            var currentRoles = await _userManager.GetRolesAsync(user);
            var isAdmin = currentRoles.Contains("Admin");

            string newRole;

            if (isAdmin)
            {
                var email = user.Email?.ToLower() ?? "";

                if (email.Contains("s.unibuc.ro"))
                {
                    newRole = "User"; 
                }
                else if (email.Contains("unibuc.ro"))
                {
                    newRole = "Professor";
                }
                else
                {
                    newRole = "User"; 
                }
            }
            else
            {
                newRole = "Admin";
            }

            if (currentRoles.Any())
            {
                await _userManager.RemoveFromRolesAsync(user, currentRoles);
            }

            await _userManager.AddToRoleAsync(user, newRole);
            return newRole;
        }
    }
}