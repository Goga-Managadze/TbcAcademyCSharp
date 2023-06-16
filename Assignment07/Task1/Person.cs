using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }

        public Home Home { get; set; }
    public Person(string name, int age, string id, Home home)
        {
            Name = name;
            Age = age;
            Id = id;
            Home = home;
        }
    }
}
