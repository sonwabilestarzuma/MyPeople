using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePerson.Models
{
    public class People
    {
        List<Person> _people = new List<Person>()
        {
            new Person() {Id=1 , Name="Zuma", Birthday = DateTime.Parse("04/24/1969"), Present = true},
             new Person() {Id=1 , Name="Sinazo", Birthday = DateTime.Parse("04/24/1955"), Present = false},
              new Person() {Id=1 , Name="Bada", Birthday = DateTime.Parse("04/24/1922"), Present = false},
               new Person() {Id=1 , Name="Luba", Birthday = DateTime.Parse("04/24/1925"), Present = true},
                new Person() {Id=1 , Name="Danger", Birthday = DateTime.Parse("04/24/1952"), Present = true}
        };
        public IEnumerable<Person> Get()
        {
            return _people;
        }
        public void Add(Person p)
        {
            _people.Add(p);

        }
        public void Remove(Person p)
        {
            _people.Remove(p);
        }
    }
}
