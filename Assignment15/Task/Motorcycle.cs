using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Motorcycle
    {
        private string _brand;
        private string _model;

        public void motorcycleInfo(string brand, string model)
        {
            _brand = brand;
            _model = model;
            Console.WriteLine($"Brand: {brand}, Model: {model}");
        }
        public void calculateAge(int year)
        {
            DateTime current_year = DateTime.Now;
            int currentYear = current_year.Year;
            Console.WriteLine($"Age: {currentYear - year}");
        }
    }
}
