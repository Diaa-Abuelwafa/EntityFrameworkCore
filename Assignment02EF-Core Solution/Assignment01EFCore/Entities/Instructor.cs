using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public double Bonus { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public Department DeptManage { get; set; }
        public Department DeptWork { get; set; }
        public ICollection<CourseInstructor> CourseInstructor { get; set; }
    }
}
