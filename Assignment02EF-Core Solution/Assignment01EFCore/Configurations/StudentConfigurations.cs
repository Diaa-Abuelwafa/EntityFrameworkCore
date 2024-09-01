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
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(x => x.Department)
                   .WithMany(x => x.Students)
                   .HasForeignKey(x => x.DeptId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
