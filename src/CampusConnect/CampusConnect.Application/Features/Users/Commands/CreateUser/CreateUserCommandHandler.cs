using CampusConnect.Domain.Models;
using CampusConnect.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace CampusConnect.Application.Features.Users.Commands.CreateUser;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IUserRepository _userRepository;
    public CreateUserCommandHandler(IUserRepository userRepository) => _userRepository = userRepository;

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // 1. Logica de Business/Validare (Ex: Verifică dacă email-ul este deja în uz)
        var existingUsers = await _userRepository.GetAllUsersAsync();
        if (existingUsers.Any(u => u.Email == request.Email))
        {
            throw new Exception("Email-ul este deja in uz.");
        }

        var newUser = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Role = request.Role,
            About = request.About,
            ProfilePictureUrl = request.ProfilePictureUrl,
            PasswordHash = HashPassword(request.Password), 
        };

        return await _userRepository.AddUserAsync(newUser);
    }

    private string HashPassword(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
