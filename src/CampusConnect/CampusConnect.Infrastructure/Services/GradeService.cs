using CampusConnect.Application.DTOs.Grades;
using CampusConnect.Application.Interfaces;
using CampusConnect.Domain.Entities;
using CampusConnect.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CampusConnect.Infrastructure.Services;

public class GradeService : IGradeService
{
    private readonly ApplicationDbContext _context;

    public GradeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<GradeDto>> GetStudentGradesAsync(int studentId)
    {
        return await _context.Set<Grade>()
            .Where(g => g.StudentId == studentId)
            .Include(g => g.Subject)
                .ThenInclude(s => s.Professor)
            .Include(g => g.Student)
            .Select(g => new GradeDto
            {
                Id = g.Id,
                SubjectId = g.SubjectId,
                SubjectName = g.Subject.Name,
                StudentId = g.StudentId,
                StudentName = $"{g.Student.FirstName} {g.Student.LastName}",
                StudentEmail = g.Student.Email ?? "",
                StudentId_Number = g.Student.StudentId,
                Value = g.Value,
                Comments = g.Comments,
                CreatedAt = g.CreatedAt,
                UpdatedAt = g.UpdatedAt,
                ProfessorName = $"{g.Subject.Professor.FirstName} {g.Subject.Professor.LastName}"
            })
            .OrderByDescending(g => g.CreatedAt)
            .ToListAsync();
    }

    public async Task<IEnumerable<GradeDto>> GetSubjectGradesAsync(int subjectId)
    {
        var grades = await _context.Set<Grade>()
            .Where(g => g.SubjectId == subjectId)
            .Include(g => g.Subject)
                .ThenInclude(s => s.Professor)
            .Include(g => g.Student)
            .Select(g => new GradeDto
            {
                Id = g.Id,
                SubjectId = g.SubjectId,
                SubjectName = g.Subject.Name,
                StudentId = g.StudentId,
                StudentName = $"{g.Student.FirstName} {g.Student.LastName}",
                StudentEmail = g.Student.Email ?? "",
                StudentId_Number = g.Student.StudentId,
                Value = g.Value,
                Comments = g.Comments,
                CreatedAt = g.CreatedAt,
                UpdatedAt = g.UpdatedAt,
                ProfessorName = $"{g.Subject.Professor.FirstName} {g.Subject.Professor.LastName}"
            })
            .ToListAsync();
        
        return grades.OrderBy(g => g.StudentName).ToList();
    }

    public async Task<GradeDto?> GetGradeByIdAsync(int id)
    {
        var grade = await _context.Set<Grade>()
            .Include(g => g.Subject)
                .ThenInclude(s => s.Professor)
            .Include(g => g.Student)
            .FirstOrDefaultAsync(g => g.Id == id);

        if (grade == null)
            return null;

        return new GradeDto
        {
            Id = grade.Id,
            SubjectId = grade.SubjectId,
            SubjectName = grade.Subject.Name,
            StudentId = grade.StudentId,
            StudentName = $"{grade.Student.FirstName} {grade.Student.LastName}",
            StudentEmail = grade.Student.Email ?? "",
            StudentId_Number = grade.Student.StudentId,
            Value = grade.Value,
            Comments = grade.Comments,
            CreatedAt = grade.CreatedAt,
            UpdatedAt = grade.UpdatedAt,
            ProfessorName = $"{grade.Subject.Professor.FirstName} {grade.Subject.Professor.LastName}"
        };
    }

    public async Task<GradeDto> CreateGradeAsync(CreateGradeRequest request)
    {
        var grade = new Grade
        {
            SubjectId = request.SubjectId,
            StudentId = request.StudentId,
            Value = request.Value,
            Comments = request.Comments,
            CreatedAt = DateTime.UtcNow
        };

        _context.Set<Grade>().Add(grade);
        await _context.SaveChangesAsync();

        var gradeWithDetails = await _context.Set<Grade>()
            .Include(g => g.Subject)
                .ThenInclude(s => s.Professor)
            .Include(g => g.Student)
            .FirstOrDefaultAsync(g => g.Id == grade.Id);

        return new GradeDto
        {
            Id = gradeWithDetails!.Id,
            SubjectId = gradeWithDetails.SubjectId,
            SubjectName = gradeWithDetails.Subject.Name,
            StudentId = gradeWithDetails.StudentId,
            StudentName = $"{gradeWithDetails.Student.FirstName} {gradeWithDetails.Student.LastName}",
            StudentEmail = gradeWithDetails.Student.Email ?? "",
            StudentId_Number = gradeWithDetails.Student.StudentId,
            Value = gradeWithDetails.Value,
            Comments = gradeWithDetails.Comments,
            CreatedAt = gradeWithDetails.CreatedAt,
            UpdatedAt = gradeWithDetails.UpdatedAt,
            ProfessorName = $"{gradeWithDetails.Subject.Professor.FirstName} {gradeWithDetails.Subject.Professor.LastName}"
        };
    }

    public async Task<GradeDto?> UpdateGradeAsync(int id, UpdateGradeRequest request)
    {
        var grade = await _context.Set<Grade>()
            .Include(g => g.Subject)
                .ThenInclude(s => s.Professor)
            .Include(g => g.Student)
            .FirstOrDefaultAsync(g => g.Id == id);

        if (grade == null)
            return null;

        grade.Value = request.Value;
        grade.Comments = request.Comments;
        grade.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return new GradeDto
        {
            Id = grade.Id,
            SubjectId = grade.SubjectId,
            SubjectName = grade.Subject.Name,
            StudentId = grade.StudentId,
            StudentName = $"{grade.Student.FirstName} {grade.Student.LastName}",
            StudentEmail = grade.Student.Email ?? "",
            StudentId_Number = grade.Student.StudentId,
            Value = grade.Value,
            Comments = grade.Comments,
            CreatedAt = grade.CreatedAt,
            UpdatedAt = grade.UpdatedAt,
            ProfessorName = $"{grade.Subject.Professor.FirstName} {grade.Subject.Professor.LastName}"
        };
    }

    public async Task<bool> DeleteGradeAsync(int id)
    {
        var grade = await _context.Set<Grade>().FindAsync(id);

        if (grade == null)
            return false;

        _context.Set<Grade>().Remove(grade);
        await _context.SaveChangesAsync();

        return true;
    }
}
