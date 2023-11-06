using StudentAPI.Abstraction.IGrade;
using StudentAPI.Models;
using StudentAPI.Models.Requests;

namespace StudentAPI.Features.AddGrade
{
    public class AddService : IAddStudentGradeService
    {
        private readonly IAddStudentGradeRepository _repository;

        public AddService(IAddStudentGradeRepository repository) 
        {
            _repository = repository;
        }
        public async Task AddGradeAsync(int studentId, AddStudentGradeRequest request)
        {
            Grade grade = new Grade();
            grade.StudentId = studentId;
            grade.SubjectId = request.SubjectId;
            grade.Score = request.Score;
            await _repository.AddGradeAsync(grade);
        }
        
    }
}
