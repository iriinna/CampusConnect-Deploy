using CampusConnect.Application.DTOs.Subjects;

namespace CampusConnect.Application.Interfaces;

public interface ISubjectService
{
    Task<IEnumerable<SubjectDto>> GetAllSubjectsAsync();
    Task<IEnumerable<SubjectDto>> GetProfessorSubjectsAsync(int professorId);
    Task<SubjectDto?> GetSubjectByIdAsync(int id);
    Task<SubjectDto> CreateSubjectAsync(int professorId, CreateSubjectRequest request);
    Task<SubjectDto?> UpdateSubjectAsync(int id, int professorId, UpdateSubjectRequest request);
    Task<bool> DeleteSubjectAsync(int id, int professorId);
}
