using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revision.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmpName { get; set; }
    }
}
