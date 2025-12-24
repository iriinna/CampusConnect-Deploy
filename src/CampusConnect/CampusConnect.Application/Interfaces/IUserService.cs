using CampusConnect.Domain.Entities;
using CampusConnect.Application.DTOs;

namespace CampusConnect.Application.Interfaces;
public interface IUserService
{
    Task<ApplicationUser?> GetUserByIdAsync(int userId);
    Task<bool> UpdateUserProfileAsync(int userId, UpdateUserProfileRequest profileData);
    Task<bool> DeleteUserAsync(int userId);
    Task<IEnumerable<ApplicationUser>> SearchUsersAsync(string search);
    Task<string> ToggleAdminRoleAsync(int userId);
}