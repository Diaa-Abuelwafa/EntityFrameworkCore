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
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.CourseId });

            builder.HasOne(x => x.Student)
                   .WithMany(x => x.StudentCourse)
                   .HasForeignKey("StudentId");

            builder.HasOne(x => x.Course)
                   .WithMany(x => x.StudentCourse)
                   .HasForeignKey("CourseId");
        }
    }
}
