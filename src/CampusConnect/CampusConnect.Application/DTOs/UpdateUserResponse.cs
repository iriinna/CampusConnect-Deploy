// Models/User/UserProfileResponseDto.cs
namespace CampusConnect.Application.DTOs; // Adaptați namespace-ul

    public class UserProfileResponse
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? ProfilePictureUrl { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string? StudentId { get; set; }
        
    }
