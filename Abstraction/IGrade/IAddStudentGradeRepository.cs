using StudentAPI.Models;

namespace StudentAPI.Abstraction.IGrade
{
    public interface IAddStudentGradeRepository
    {
        Task AddGradeAsync(Grade grade);
    }
}
