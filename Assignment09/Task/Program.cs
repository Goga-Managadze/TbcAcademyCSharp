// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Threading.Tasks;
using System.Transactions;
using Task;


Console.WriteLine("Choose vehicle category: Combat, Consumer, Public or Racing");
string input = Console.ReadLine();
if (input == "Combat")
{
    Console.WriteLine("Choose Tank or Beteer");
    input = Console.ReadLine();
}else if (input == "Consumer")
{
    Console.WriteLine("Choose Sedan, Jeep, Motorcycle, Bicycle");
    input = Console.ReadLine();
}else if (input == "Public")
{
    Console.WriteLine("Choose Bus or Tram");
    input = Console.ReadLine();
}
else if (input == "Racing")
{
    Console.WriteLine("Choose Formula1, Rally or Offroad");
    input = Console.ReadLine();
}
else
{
    Console.WriteLine("Enter correct text");
}


void create()
{
    if (input == "Tank")
    {
        Console.WriteLine("Enter brand");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter max speed");
        string maxSpeed = Console.ReadLine();

        Console.WriteLine("Enter fuel type");
        string fuelType = Console.ReadLine();

        Console.WriteLine("Enter manufacture country");
        string manufactureCountry = Console.ReadLine();

        Console.WriteLine("Enter model");
        string model = Console.ReadLine();

        Console.WriteLine("Enter production material");
        string productionMaterial = Console.ReadLine();

        Tank tank = new Tank(brand, maxSpeed, fuelType, manufactureCountry, model, productionMaterial);
        Console.WriteLine($"Brand: {tank.Brand}, Max Speed: {tank.MaxSpeed}, Fuel Type: {tank.FuelType}" +
            $"Manufacture Country: {tank.ManufactureCountry}, Model: {tank.Model}, Production Material: {tank.ProductionMaterial}");       
    }
    else if (input == "Beteer")
    {
        Console.WriteLine("Enter brand");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter max speed");
        string maxSpeed = Console.ReadLine();

        Console.WriteLine("Enter fuel type");
        string fuelType = Console.ReadLine();

        Console.WriteLine("Enter manufacture country");
        string manufactureCountry = Console.ReadLine();

        Console.WriteLine("Enter model");
        string model = Console.ReadLine();

        Console.WriteLine("Enter machine gun count");
        int machineGunCount = int.Parse(Console.ReadLine());

        Beteer beteer = new Beteer(brand, maxSpeed, fuelType, manufactureCountry, model, machineGunCount);
        Console.WriteLine($"Brand: {beteer.Brand}, Max Speed: {beteer.MaxSpeed}, Fuel Type: {beteer.FuelType}" +
            $"Manufacture Country: {beteer.ManufactureCountry}, Model: {beteer.Model}, Machine gun count: {beteer.MachineGunCount}");
    }else if(input == "Sedan")
    {
        Console.WriteLine("Enter brand");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter max speed");
        string maxSpeed = Console.ReadLine();

        Console.WriteLine("Enter fuel type");
        string fuelType = Console.ReadLine();

        Console.WriteLine("Enter manufacture country");
        string manufactureCountry = Console.ReadLine();

        Console.WriteLine("Enter number of tires");
        int numberOfTires = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of tires");
        string cabinColor = Console.ReadLine();

        Sedan sedan = new Sedan(brand, maxSpeed, fuelType, manufactureCountry, numberOfTires, cabinColor);
    }
  
}



create();