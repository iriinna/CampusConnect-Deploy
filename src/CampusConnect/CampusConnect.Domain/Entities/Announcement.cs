using System;

namespace CampusConnect.Domain.Entities
{
    public class Announcement
{
    public int Id { get; set; } 
    public required string Title { get; set; } 
    public required string Content { get; set; }

    public string Category { get; set; } = "General";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
}

}
