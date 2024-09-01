using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public int PersonId { get; set; }
        public List<Person>? Owners { get; set; }
    }
}
