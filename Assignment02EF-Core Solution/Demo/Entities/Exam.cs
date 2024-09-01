using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Entities
{
    public class Exam
    {
        public int ExamId { get; set; }
        public TimeSlot Time { get; set; }
        public string TestString { get; set; }
    }

    public class TimeSlot
    {
        public DateTime StartExam { get; set; }
        public DateTime EndExam { get; set; }
    }
}
