using StudentAPI.Abstraction.IGrade;
using StudentAPI.Models;

namespace StudentAPI.Features.GetGrades
{
    public class GetService : IGetGradesService
    {
        private readonly IGetGradesRepository _repository;

        public GetService(IGetGradesRepository repository) 
        {
            _repository = repository;
        }
        public async Task<List<GradeDto>> GetGradesAsync(int studentId)
        {
            var grades = await _repository.GetGradesAsync(studentId);
            var gradeList = grades.Select(s => new GradeDto()
            {
                Score = s.Score
            }).ToList();
            return gradeList;
        }
        
    }
}
