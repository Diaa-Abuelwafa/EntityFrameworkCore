using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public Instructor Manager { get; set; }
        public ICollection<Instructor> InstructorsWork { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
