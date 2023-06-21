using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Sedan : Consumer
    {
        private string _cabinColor;

        public string CabinColor
        {
            get 
            { 
                return _cabinColor; 
            }
            set 
            { 
                _cabinColor = value; 
            }
        }
        public Sedan(string brand, string maxSpeed, string fuelType, string manufactureCountry, int numberOfTires, string cabinColor)
            : base(brand, maxSpeed, fuelType, manufactureCountry, numberOfTires)
        {
            _cabinColor = cabinColor;
        }
    }


    public class Jeep : Consumer
    {
        private string _leadingWheels;

        public string LeadingWheels
        {
            get 
            { 
                return _leadingWheels; 
            }
            set
            {
                _leadingWheels = value;
            }
        }

        public Jeep(string brand, string maxSpeed, string fuelType, string manufactureCountry, int numberOfTires, string leadingWheels)
            : base(brand, maxSpeed, fuelType, manufactureCountry, numberOfTires)
        {
            _leadingWheels = leadingWheels;
        }
    }


    public class Motorcycle : Consumer
    {
        private string _mileage;

        public string Mileage
        {
            get 
            { 
                return _mileage; 
            }
            set
            {
                _mileage = value;
            }
        }

        public Motorcycle(string brand, string maxSpeed, string fuelType, string manufactureCountry, int numberOfTires, string mileage)
            : base(brand, maxSpeed, fuelType, manufactureCountry, numberOfTires)
        {
            _mileage = mileage;
        }
    }


    public class Bicycle : Consumer
    {
        private string _wheelDiameter;

        public string WheelDiameter
        {
            get 
            { 
                return _wheelDiameter; 
            }
            set
            {
                _wheelDiameter = value;
            }
        }

        public Bicycle(string name, string maxSpeed, string fuelType, string manufactureCountry, int numberOfTires, string wheelDiameter)
            : base(name, maxSpeed, fuelType, manufactureCountry, numberOfTires)
        {
            _wheelDiameter = wheelDiameter;
        }
    }
}
