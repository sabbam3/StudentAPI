using StudentAPI.Models.Requests;

namespace StudentAPI.Abstraction.ISubject
{
    public interface IAddSubjectService
    {
        Task AddSubjectAsync(AddSubjectRequest request);
    }
}
