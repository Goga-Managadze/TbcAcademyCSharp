using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Combat : Vehicle
    {
        private string _model;

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public Combat(string brand, string maxSpeed, string fuelType, string manufactureCountry, string model)
           : base(brand, maxSpeed, fuelType, manufactureCountry)
        {
            _model = model;
        }
    }


    public class Consumer : Vehicle
    {
        private int _numberOfTires;

        public int NumberOfTires
        {
            get 
            { 
                return _numberOfTires; 
            }
            set
            {
                _numberOfTires = value;
            }
        }
        public Consumer(string brand, string maxSpeed, string fuelType, string manufactureCountry, int numberOfTires)
           : base(brand, maxSpeed, fuelType, manufactureCountry)
        {
            _numberOfTires = numberOfTires;
        }
    }


    public class PublicTransport : Vehicle
    {
        private int _numberOfSeats;

        public int NumberOfSeats
        {
            get 
            { 
                return _numberOfSeats; 
            }
            set
            {
                _numberOfSeats = value;
            }
        }

        public PublicTransport(string brand, string maxSpeed, string fuelType, string manufactureCountry, int numberOfSeats)
           : base(brand, maxSpeed, fuelType, manufactureCountry)
        {
            _numberOfSeats = numberOfSeats;
        }
    }


    public class RacingCar : Vehicle
    {
        private string _transmission;

        public string Transmission
        {
            get 
            { 
                return _transmission; 
            }
            set
            {
                _transmission = value;
            }
        }

        public RacingCar(string brand, string maxSpeed, string fuelType, string manufactureCountry, string transmission)
           : base(brand, maxSpeed, fuelType, manufactureCountry)
        {
            _transmission = transmission;
        }
    }
}