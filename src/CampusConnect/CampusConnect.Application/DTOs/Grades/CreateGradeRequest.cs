namespace CampusConnect.Application.DTOs.Grades;

public class CreateGradeRequest
{
    public int SubjectId { get; set; }
    public int StudentId { get; set; }
    public decimal Value { get; set; }
    public string? Comments { get; set; }
}
