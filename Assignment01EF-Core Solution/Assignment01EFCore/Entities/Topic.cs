using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Entities
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
        public Course CourseHasTopic { get; set; }
    }
}
