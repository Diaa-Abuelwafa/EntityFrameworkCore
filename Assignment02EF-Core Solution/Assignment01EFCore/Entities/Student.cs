using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int? DeptId { get; set; }
        public Department Department { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; } = new List<StudentCourse>();
    }
}
