using System.Collections.Generic;

namespace CampusConnect.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? About { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public ICollection<Post> Posts { get; set; }

        public User()
        {
            Posts = new HashSet<Post>();
        }
    }
}