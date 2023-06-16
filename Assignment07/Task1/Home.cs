using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persons
{
    public class Home
    {
        public string Address { get; set; }
        public string City { get; set; }

        public Home(string address, string city)
        {
            Address = address;
            City = city;
        }
    }
}
