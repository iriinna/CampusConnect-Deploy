namespace CampusConnect.Domain.Entities;

public class Grade
{
    public int Id { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;
    public int StudentId { get; set; }
    public ApplicationUser Student { get; set; } = null!;
    public decimal Value { get; set; }
    public string? Comments { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
