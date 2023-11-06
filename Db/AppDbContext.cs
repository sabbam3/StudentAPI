using Microsoft.EntityFrameworkCore;
using StudentAPI.Mappings;
using StudentAPI.Models;

namespace StudentAPI.Db

{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students{ get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GradeMap());
            modelBuilder.ApplyConfiguration(new StudentMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
