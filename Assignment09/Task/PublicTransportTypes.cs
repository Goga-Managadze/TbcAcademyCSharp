using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Bus : PublicTransport
    {
        private int _numberOfDoors;

        public int NumberOfDoors
        {
            get 
            { 
                return _numberOfDoors; 
            }
            set
            {
                _numberOfDoors = value;
            }
        }

        public Bus(string brand, string maxSpeed, string fuelType, string manufactureCountry, int numberOfSeats, int numberOfDoors)
                  : base(brand, maxSpeed, fuelType, manufactureCountry, numberOfSeats)
        {
            _numberOfDoors = numberOfDoors;
        }
    }


    public class Tram : PublicTransport
    {
        private int _numberOfLines;

        public int NumberOfLines
        {
            get 
            { 
                return _numberOfLines; 
            }
            set 
            { 
                _numberOfLines = value; 
            }
        }

        public Tram(string brand, string maxSpeed, string fuelType, string manufactureCountry, int numberOfSeats, int numberOfLines)
                  : base(brand, maxSpeed, fuelType, manufactureCountry, numberOfSeats)
        {
            _numberOfLines = numberOfLines;
        }
    }
}

