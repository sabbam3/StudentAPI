using Microsoft.EntityFrameworkCore;
using StudentAPI.Abstraction.ISubject;
using StudentAPI.Db;
using StudentAPI.Models;

namespace StudentAPI.Features.AddSubject
{
    public class AddRepository : IAddSubjectRepository
    {
        private readonly AppDbContext _db;
        public AddRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task AddSubjectAsync(Subject subject)
        {
            await _db.AddAsync(subject);
            await _db.SaveChangesAsync();
        }
    }

}
