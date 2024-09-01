using Assignment01EFCore.Configurations;
using Assignment01EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCourse> Stud_Course { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITIDB; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // To Apply All Configurations Classes In This Assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
