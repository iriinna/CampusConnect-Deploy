namespace CampusConnect.Domain.Entities;

public class Subject
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public int ProfessorId { get; set; }
    public ApplicationUser Professor { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
