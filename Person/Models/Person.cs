using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.Models
{
    public class Person
    {
        public int Id { get; set; }
        public DateTime Birthday { get; set; }
        public string  Name { get; set; }
        public bool Present { get; set; }
    }
}
