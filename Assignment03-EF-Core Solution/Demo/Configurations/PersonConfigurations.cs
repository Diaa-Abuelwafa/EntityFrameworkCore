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
    internal class PersonConfigurations : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Persons", schema: "dbo")
                   .HasKey(x => x.PersonId);

            builder.HasMany(x => x.PersonCars)
                   .WithMany(x => x.Owners);
        }
    }
}
