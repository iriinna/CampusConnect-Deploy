using CampusConnect.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusConnect.Application.Features.Users.Commands.CreateUser;
public class CreateUserCommand : IRequest<int>
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? About { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public virtual ICollection<User>? Posts { get; set; } = new List<User>();
    public string Role { get; set; } = string.Empty;

    public string Password { get; set; }
}
