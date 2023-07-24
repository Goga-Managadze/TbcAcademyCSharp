using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ElectricCar
    {
        public int BatteryLevel { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public ElectricCar(string model, int year)
        {
            BatteryLevel = 0;
            Model = model;
            Year = year;
        }
        public async Task Charge()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (BatteryLevel < 100)
            {
                BatteryLevel += 5;
                Console.WriteLine($"Charging model: {Model} (year: {Year}) battery level: {BatteryLevel}%");
                await Task.Delay(10000);
            }

            stopwatch.Stop();
            Console.WriteLine($"Charging completed");

            TimeSpan chargingTime = stopwatch.Elapsed;
            Console.WriteLine($"Charging time for {Model} ({Year}): {chargingTime}");
        }
    }
}
