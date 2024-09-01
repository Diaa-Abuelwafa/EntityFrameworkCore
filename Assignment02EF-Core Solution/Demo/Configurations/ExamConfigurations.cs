using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Revision.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Configurations
{
    public class ExamConfigurations : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.OwnsOne(x => x.Time, ts => {
                ts.Property(x => x.StartExam).HasColumnName("Start");
                ts.Property(x => x.EndExam).HasColumnName("End");
            });
        }
    }
}
