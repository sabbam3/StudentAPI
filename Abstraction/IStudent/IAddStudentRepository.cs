using StudentAPI.Models;

namespace StudentAPI.Abstraction.IStudent
{
    public interface IAddStudentRepository
    {
        Task AddStudentAsync(Student student);
    }
}
