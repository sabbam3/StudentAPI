using StudentAPI.Models;

namespace StudentAPI.Abstraction.IGPA
{
    public interface IGPARepository
    {
        Task<int> GetStudentPointAsync(int studentId, int subjectId);
        Task<int> GetSubjectCreditAsync(int studentId, int subjectId);
        Task<List<int>> GetStudentSubjectIdListAsync(int studentId);
        Task<List<int>> GetSubjectCreditsAsync(int studentId);

     }
}
