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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            // Not Required Relationship : Means I Can Insert Instructor Without WorkDepartment
            //                           : Means That FK Will Be Nullable
            builder.HasOne(x => x.DeptWork)
                   .WithMany(x => x.InstructorsWork)
                   .HasForeignKey("DeptId")
                   .IsRequired(false);
        }
    }
}
