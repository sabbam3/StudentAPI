using StudentAPI.Abstraction.ISubject;
using StudentAPI.Models;
using StudentAPI.Models.Requests;

namespace StudentAPI.Features.AddSubject
{
    public class AddService : IAddSubjectService
    {
        private readonly IAddSubjectRepository _addSubjectRepository;
        public AddService(IAddSubjectRepository addSubjectRepository) 
        {
            _addSubjectRepository = addSubjectRepository;
        } 
        public async Task AddSubjectAsync(AddSubjectRequest request)
        {
            Subject subject = new Subject();
            subject.Name = request.Name;
            subject.Credit = request.Credit;
            await _addSubjectRepository.AddSubjectAsync(subject);

        }
    }
}
