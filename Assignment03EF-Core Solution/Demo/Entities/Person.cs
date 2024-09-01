using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }

        public int CarId { get; set; }
        public List<Car> PersonCars { get; set; }
    }
}
