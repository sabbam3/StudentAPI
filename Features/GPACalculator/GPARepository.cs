using Microsoft.EntityFrameworkCore;
using StudentAPI.Abstraction.IGPA;
using StudentAPI.Db;
using StudentAPI.Models;

namespace StudentAPI.Features.GPACalculator
{
    public class GPARepository : IGPARepository
    {
        private readonly AppDbContext _db;
        public GPARepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<int> GetStudentPointAsync(int studentId, int subjectId)
        {
            return await _db.Grades.Where(s => s.StudentId == studentId && s.SubjectId == subjectId).Select(s => s.Score).FirstOrDefaultAsync();
        }
        public async Task<int> GetSubjectCreditAsync(int studentId, int subjectId)
        {
            return await _db.Grades.Where(s => s.StudentId == studentId && s.SubjectId == subjectId).Select(s => s.Subject.Credit).FirstOrDefaultAsync();
        }
        public async Task<List<int>> GetStudentSubjectIdListAsync(int studentId)
        {
            return await _db.Grades.Where(g => g.StudentId == studentId).Select(s => s.SubjectId).ToListAsync();
        }
        public async Task<List<int>> GetSubjectCreditsAsync(int studentId)
        {
            return await _db.Grades.Where(s => s.StudentId == studentId).Select(s => s.Subject.Credit).ToListAsync();
        }
        
        
    }
}
