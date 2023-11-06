using StudentAPI.Abstraction.IStudent;
using StudentAPI.Db;
using StudentAPI.Models;

namespace StudentAPI.Features.AddStudent
{
    public class AddRepository : IAddStudentRepository
    {
        private readonly AppDbContext _db;
        public AddRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task AddStudentAsync(Student student)
        {
            await _db.Students.AddAsync(student);
            await _db.SaveChangesAsync();
        }   
    }
}
