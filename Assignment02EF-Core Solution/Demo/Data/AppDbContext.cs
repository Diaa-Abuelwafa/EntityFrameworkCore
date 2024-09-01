using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Revision.Configurations;
using Revision.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .;Database = SchoolDB;Trusted_Connection = True;TrustServerCertificate=True;");

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new CarConfigurations());
            modelBuilder.ApplyConfiguration(new PersonConfigurations());
            modelBuilder.ApplyConfiguration(new ExamConfigurations());
        }
    }
}
