using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Formula1 : RacingCar
    {
        private int _horsepower;

        public int Horsepower
        {
            get
            {
                return _horsepower;
            }
            set
            {
                _horsepower = value;
            }
        }
        public Formula1(string brand, string maxSpeed, string fuelType, string manufactureCountry, string transmission, int horsepower)
            : base(brand, maxSpeed, fuelType, manufactureCountry, transmission)
        {
            _horsepower = horsepower;
        }
    }


    public class Rally : RacingCar
    {
        private int _numberOfCylinders;

        public int NumberOfCylinders
        {
            get 
            { 
                return _numberOfCylinders; 
            } 
            set 
            {
                _numberOfCylinders = value;
            }
        }
        public Rally(string brand, string maxSpeed, string fuelType, string manufactureCountry, string transmission, int numberOfCylinders)
            : base(brand, maxSpeed, fuelType, manufactureCountry, transmission)
        {
            _numberOfCylinders = numberOfCylinders;
        }
    }

    public class OffRoad : RacingCar
    {
        private int _numberOfAirbags;

        public int NumberOfAirbags
        {
            get 
            { 
                return _numberOfAirbags; 
            }
            set
            {
                _numberOfAirbags = value;
            }
        }
        public OffRoad(string brand, string maxSpeed, string fuelType, string manufactureCountry, string transmission, int numberOfAirbags)
            : base(brand, maxSpeed, fuelType, manufactureCountry, transmission)
        {
            _numberOfAirbags = numberOfAirbags;
        }
    }

}
