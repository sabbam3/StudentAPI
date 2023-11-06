using StudentAPI.Models.Requests;

namespace StudentAPI.Abstraction.IGrade
{
    public interface IAddStudentGradeService
    {
        Task AddGradeAsync(int studentId, AddStudentGradeRequest request);
    }
}
