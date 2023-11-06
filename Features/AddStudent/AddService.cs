using StudentAPI.Abstraction.IStudent;
using StudentAPI.Models;
using StudentAPI.Models.Requests;

namespace StudentAPI.Features.AddStudent
{
    public class AddService : IAddStudentService
    {
        private readonly IAddStudentRepository _repository;
        public AddService(IAddStudentRepository repository)
        {
            _repository = repository;
        }
        public async Task AddStudentAsync(AddStudentRequest request)
        {
            var student = new Student();
            student.Name = request.Name;
            student.LastName = request.LastName;
            student.Course = request.Course;
            student.PersonalID = request.PersonalID;
            await _repository.AddStudentAsync(student);
        }
    }
}
