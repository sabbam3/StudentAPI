using StudentAPI.Abstraction.IGrade;
using StudentAPI.Db;
using StudentAPI.Models;

namespace StudentAPI.Features.AddGrade
{
    public class AddRepository : IAddStudentGradeRepository
    {
        private readonly AppDbContext _db;

        public AddRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task AddGradeAsync(Grade grade)
        {
            await _db.Grades.AddAsync(grade);
            await _db.SaveChangesAsync();
        }
        
    }
}
