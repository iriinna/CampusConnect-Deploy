using CampusConnect.Application.DTOs.Grades;

namespace CampusConnect.Application.Interfaces;

public interface IGradeService
{
    Task<IEnumerable<GradeDto>> GetStudentGradesAsync(int studentId);
    Task<IEnumerable<GradeDto>> GetSubjectGradesAsync(int subjectId);
    Task<GradeDto?> GetGradeByIdAsync(int id);
    Task<GradeDto> CreateGradeAsync(CreateGradeRequest request);
    Task<GradeDto?> UpdateGradeAsync(int id, UpdateGradeRequest request);
    Task<bool> DeleteGradeAsync(int id);
}
