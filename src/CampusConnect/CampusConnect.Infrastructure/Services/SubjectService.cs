using CampusConnect.Application.DTOs.Subjects;
using CampusConnect.Application.Interfaces;
using CampusConnect.Domain.Entities;
using CampusConnect.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CampusConnect.Infrastructure.Services;

public class SubjectService : ISubjectService
{
    private readonly ApplicationDbContext _context;

    public SubjectService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SubjectDto>> GetAllSubjectsAsync()
    {
        return await _context.Set<Subject>()
            .Include(s => s.Professor)
            .Include(s => s.Grades)
            .Select(s => new SubjectDto
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                ProfessorId = s.ProfessorId,
                ProfessorName = $"{s.Professor.FirstName} {s.Professor.LastName}",
                CreatedAt = s.CreatedAt,
                GradesCount = s.Grades.Count
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<SubjectDto>> GetProfessorSubjectsAsync(int professorId)
    {
        return await _context.Set<Subject>()
            .Where(s => s.ProfessorId == professorId)
            .Include(s => s.Professor)
            .Include(s => s.Grades)
            .Select(s => new SubjectDto
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                ProfessorId = s.ProfessorId,
                ProfessorName = $"{s.Professor.FirstName} {s.Professor.LastName}",
                CreatedAt = s.CreatedAt,
                GradesCount = s.Grades.Count
            })
            .ToListAsync();
    }

    public async Task<SubjectDto?> GetSubjectByIdAsync(int id)
    {
        var subject = await _context.Set<Subject>()
            .Include(s => s.Professor)
            .Include(s => s.Grades)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (subject == null)
            return null;

        return new SubjectDto
        {
            Id = subject.Id,
            Name = subject.Name,
            Description = subject.Description,
            ProfessorId = subject.ProfessorId,
            ProfessorName = $"{subject.Professor.FirstName} {subject.Professor.LastName}",
            CreatedAt = subject.CreatedAt,
            GradesCount = subject.Grades.Count
        };
    }

    public async Task<SubjectDto> CreateSubjectAsync(int professorId, CreateSubjectRequest request)
    {
        var subject = new Subject
        {
            Name = request.Name,
            Description = request.Description,
            ProfessorId = professorId,
            CreatedAt = DateTime.UtcNow
        };

        _context.Set<Subject>().Add(subject);
        await _context.SaveChangesAsync();

        var professor = await _context.Users.FindAsync(professorId);

        return new SubjectDto
        {
            Id = subject.Id,
            Name = subject.Name,
            Description = subject.Description,
            ProfessorId = subject.ProfessorId,
            ProfessorName = professor != null ? $"{professor.FirstName} {professor.LastName}" : "Unknown",
            CreatedAt = subject.CreatedAt,
            GradesCount = 0
        };
    }

    public async Task<SubjectDto?> UpdateSubjectAsync(int id, int professorId, UpdateSubjectRequest request)
    {
        var subject = await _context.Set<Subject>()
            .Include(s => s.Professor)
            .FirstOrDefaultAsync(s => s.Id == id && s.ProfessorId == professorId);

        if (subject == null)
            return null;

        subject.Name = request.Name;
        subject.Description = request.Description;

        await _context.SaveChangesAsync();

        return new SubjectDto
        {
            Id = subject.Id,
            Name = subject.Name,
            Description = subject.Description,
            ProfessorId = subject.ProfessorId,
            ProfessorName = $"{subject.Professor.FirstName} {subject.Professor.LastName}",
            CreatedAt = subject.CreatedAt,
            GradesCount = subject.Grades.Count
        };
    }

    public async Task<bool> DeleteSubjectAsync(int id, int professorId)
    {
        var subject = await _context.Set<Subject>()
            .FirstOrDefaultAsync(s => s.Id == id && s.ProfessorId == professorId);

        if (subject == null)
            return false;

        _context.Set<Subject>().Remove(subject);
        await _context.SaveChangesAsync();

        return true;
    }
}
