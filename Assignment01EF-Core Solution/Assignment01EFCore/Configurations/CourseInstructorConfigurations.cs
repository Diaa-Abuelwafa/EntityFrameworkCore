using Assignment01EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Configurations
{
    public class CourseInstructorConfigurations : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.HasKey(x => new { x.CourseId, x.InstructorId });

            builder.HasOne(x => x.Course)
                   .WithMany(x => x.CourseInstructor)
                   .HasForeignKey(x => x.CourseId);

            builder.HasOne(x => x.Instructor)
                   .WithMany(x => x.CourseInstructor)
                   .HasForeignKey(x => x.InstructorId);
        }
    }
}
