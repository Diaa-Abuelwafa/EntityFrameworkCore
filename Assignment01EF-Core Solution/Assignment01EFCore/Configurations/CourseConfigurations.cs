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
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(x => x.CourseTopic)
                   .WithOne(x => x.CourseHasTopic)
                   .HasForeignKey<Course>(x => x.TopicId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
