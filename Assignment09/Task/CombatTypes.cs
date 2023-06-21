using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Tank : Combat
    {
        private string _productionMaterial;

        public string ProductionMaterial
        {
            get
            {
                return _productionMaterial;
            }
            set
            {
                _productionMaterial = value;
            }
        }
        public Tank(string brand, string maxSpeed, string fuelType, string manufactureCountry, string model, string productionMaterial)
               : base(brand, maxSpeed, fuelType, manufactureCountry, model)
        {
            _productionMaterial = productionMaterial;
        }
    }


    public class Beteer : Combat
    {
        private int _machineGunCount;

        public int MachineGunCount
        {
            get 
            { 
                return _machineGunCount; 
            }
            set
            {
                _machineGunCount = value;
            }
        }
        public Beteer(string brand, string maxSpeed, string fuelType, string manufactureCountry, string model, int machineGunCount)
               : base(brand, maxSpeed, fuelType, manufactureCountry, model)
        {
            _machineGunCount = machineGunCount;
        }
    }
}
