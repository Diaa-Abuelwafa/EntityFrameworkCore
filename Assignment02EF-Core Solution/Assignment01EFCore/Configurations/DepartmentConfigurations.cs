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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(x => x.Manager)
                   .WithOne(x => x.DeptManage)
                   .HasForeignKey<Department>("InsId")
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
