using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }

        public int? TopicId { get; set; }
        public Topic CourseTopic { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
        public ICollection<CourseInstructor> CourseInstructor { get; set; }
    }
}
