using System.Collections.Generic;
using System.Threading.Tasks;
using CampusConnect.Domain.Models;

public interface IUserRepository
{
    // Queries (Citire)
    Task<User> GetUserByIdAsync(int userId);
    Task<IEnumerable<User>> GetAllUsersAsync();

    // Commands (Scriere/Modificare)
    Task<int> AddUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(int userId);
}