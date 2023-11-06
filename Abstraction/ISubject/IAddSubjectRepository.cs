using StudentAPI.Models;

namespace StudentAPI.Abstraction.ISubject
{
    public interface IAddSubjectRepository
    {
        Task AddSubjectAsync(Subject subject);
    }
}
