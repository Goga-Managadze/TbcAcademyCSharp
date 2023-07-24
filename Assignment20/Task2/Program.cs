// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;
using Task2;

static async Task ChargeAllCars(IEnumerable<ElectricCar> cars)
{
    var tasks = new List<Task>();

    foreach (var car in cars)
    {
        tasks.Add(car.Charge());
    }
    await Task.WhenAll(tasks);
}

var electricCars = new List<ElectricCar>();

Console.WriteLine("Add Electric cars");

while (true)
{      
    Console.Write("Enter the car model: ");
    string model = Console.ReadLine();

    Console.Write("Enter the year: ");
    int year = int.Parse(Console.ReadLine());

    electricCars.Add(new ElectricCar(model, year));

    Console.WriteLine("Do you want to add more electric cars? enter 'yes or 'no'");
    var exit = Console.ReadLine();
    if (exit.ToLower() == "yes")
    {
        continue;
    }
    else if (exit.ToLower() == "no")
    {
        break;
    }
    else
    {
        Console.WriteLine("Entered text is not correct");
        break;
    }
}

if (electricCars.Count > 0)
{
    Console.WriteLine("Charging added electric cars...");
}

var maxChargingTime = TimeSpan.FromSeconds(200);
var stopwatch = new Stopwatch();
stopwatch.Start();

await ChargeAllCars(electricCars);

stopwatch.Stop();
TimeSpan totalChargingTime = stopwatch.Elapsed;

Console.WriteLine("All cars are fully charged.");
Console.WriteLine($"Total charging time: {totalChargingTime}");
    
