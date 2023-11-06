using Microsoft.EntityFrameworkCore;
using StudentAPI.Abstraction.IGrade;
using StudentAPI.Db;
using StudentAPI.Models;

namespace StudentAPI.Features.GetGrades
{
    public class GetRepository : IGetGradesRepository
    {
        private readonly AppDbContext _db;
        public GetRepository(AppDbContext db) 
        {
            _db = db;
        }
        public async Task<List<Grade>> GetGradesAsync(int studentId)
        {
            return await _db.Grades.Where(s => s.StudentId == studentId).ToListAsync();   
        }
    }
}
