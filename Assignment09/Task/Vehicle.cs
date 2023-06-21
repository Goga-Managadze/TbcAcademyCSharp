using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Vehicle
    {
        private string _brand;
        private string _maxSpeed;
        private string _fuelType;
        private string _manufactureCountry;

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }

        public string MaxSpeed
        {
            get 
            { 
                return _maxSpeed; 
            }
            set 
            { 
                _maxSpeed = value; 
            }
        }

        public string FuelType
        {
            get 
            { 
                return _fuelType; 
            }
            set
            {
                _fuelType = value;
            }
        }

        public string ManufactureCountry
        {
            get 
            { 
                return _manufactureCountry; 
            }
            set
            {
                _manufactureCountry = value;
            }
        }

        public Vehicle(string brand, string maxSpeed, string fuelType, string manufactureCountry)
        {
            _brand = brand;
            _maxSpeed = maxSpeed;
            _fuelType = fuelType;
            _manufactureCountry = manufactureCountry;
        }
    }
}
