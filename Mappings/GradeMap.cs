using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAPI.Models;

namespace StudentAPI.Mappings
{
    public class GradeMap : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasKey(g => g.Id);
            builder.HasOne(g => g.Subject).WithMany().HasForeignKey( g => g.SubjectId);
        }
    }
}
