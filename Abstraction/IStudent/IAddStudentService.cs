using StudentAPI.Models.Requests;

namespace StudentAPI.Abstraction.IStudent
{
    public interface IAddStudentService
    {
        Task AddStudentAsync(AddStudentRequest request);
    }
}
