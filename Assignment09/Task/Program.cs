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
    Console.WriteLine("Such text is not in the list of transport categories. Enter correct text");
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
    }
    else if (input == "Sedan")
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

        Console.WriteLine("Enter cabin color");
        string cabinColor = Console.ReadLine();

        Sedan sedan = new Sedan(brand, maxSpeed, fuelType, manufactureCountry, numberOfTires, cabinColor);
        Console.WriteLine($"Brand: {sedan.Brand}, Max Speed: {sedan.MaxSpeed}, Fuel Type: {sedan.FuelType}" +
            $"Manufacture Country: {sedan.ManufactureCountry}, Number of tires: {sedan.NumberOfTires}, Cabin color: {sedan.CabinColor}");
    }
    else if (input == "Jeep")
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

        Console.WriteLine("Enter leading wheels");
        string leadingWheels = Console.ReadLine();

        Jeep jeep = new Jeep(brand, maxSpeed, fuelType, manufactureCountry, numberOfTires, leadingWheels);
        Console.WriteLine($"Brand: {jeep.Brand}, Max Speed: {jeep.MaxSpeed}, Fuel Type: {jeep.FuelType}" +
            $"Manufacture Country: {jeep.ManufactureCountry}, Number of tires: {jeep.NumberOfTires}, Leading wheels: {jeep.LeadingWheels}");
    }
    else if (input == "Motorcycle")
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

        Console.WriteLine("Enter mileage");
        string mileage = Console.ReadLine();

        Motorcycle motorcycle = new Motorcycle(brand, maxSpeed, fuelType, manufactureCountry, numberOfTires, mileage);
        Console.WriteLine($"Brand: {motorcycle.Brand}, Max Speed: {motorcycle.MaxSpeed}, Fuel Type: {motorcycle.FuelType}" +
            $"Manufacture Country: {motorcycle.ManufactureCountry}, Number of tires: {motorcycle.NumberOfTires}, Leading wheels: {motorcycle.Mileage}");
    }
    else if (input == "Bicycle")
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

        Console.WriteLine("Enter wheel diameter");
        string wheelDiameter = Console.ReadLine();

        Bicycle bicycle = new Bicycle(brand, maxSpeed, fuelType, manufactureCountry, numberOfTires, wheelDiameter);
        Console.WriteLine($"Brand: {bicycle.Brand}, Max Speed: {bicycle.MaxSpeed}, Fuel Type: {bicycle.FuelType}" +
            $"Manufacture Country: {bicycle.ManufactureCountry}, Number of tires: {bicycle.NumberOfTires}, Leading wheels: {bicycle.WheelDiameter}");
    }
    else if (input == "Bus")
    {
        Console.WriteLine("Enter brand");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter max speed");
        string maxSpeed = Console.ReadLine();

        Console.WriteLine("Enter fuel type");
        string fuelType = Console.ReadLine();

        Console.WriteLine("Enter manufacture country");
        string manufactureCountry = Console.ReadLine();

        Console.WriteLine("Enter number of seats");
        int numberOfSeats = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of doors");
        int numberOfDoors = int.Parse(Console.ReadLine());

        Bus bus = new Bus(brand, maxSpeed, fuelType, manufactureCountry, numberOfSeats, numberOfDoors);
        Console.WriteLine($"Brand: {bus.Brand}, Max Speed: {bus.MaxSpeed}, Fuel Type: {bus.FuelType}" +
            $"Manufacture Country: {bus.ManufactureCountry}, Number of seats: {bus.NumberOfSeats}, Number of doors: {bus.NumberOfDoors}");
    }
    else if (input == "Tram")
    {
        Console.WriteLine("Enter brand");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter max speed");
        string maxSpeed = Console.ReadLine();

        Console.WriteLine("Enter fuel type");
        string fuelType = Console.ReadLine();

        Console.WriteLine("Enter manufacture country");
        string manufactureCountry = Console.ReadLine();

        Console.WriteLine("Enter number of seats");
        int numberOfSeats = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of lines");
        int numberOfLines = int.Parse(Console.ReadLine());

        Tram tram = new Tram(brand, maxSpeed, fuelType, manufactureCountry, numberOfSeats, numberOfLines);
        Console.WriteLine($"Brand: {tram.Brand}, Max Speed: {tram.MaxSpeed}, Fuel Type: {tram.FuelType}" +
            $"Manufacture Country: {tram.ManufactureCountry}, Number of seats: {tram.NumberOfSeats}, Number of doors: {tram.NumberOfLines}");
    }
    else if (input == "Formula1")
    {
        Console.WriteLine("Enter brand");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter max speed");
        string maxSpeed = Console.ReadLine();

        Console.WriteLine("Enter fuel type");
        string fuelType = Console.ReadLine();

        Console.WriteLine("Enter manufacture country");
        string manufactureCountry = Console.ReadLine();

        Console.WriteLine("Enter transmission");
        string transmission = Console.ReadLine();

        Console.WriteLine("Enter number horse power");
        int horsepower = int.Parse(Console.ReadLine());

        Formula1 formula1 = new Formula1(brand, maxSpeed, fuelType, manufactureCountry, transmission, horsepower);
        Console.WriteLine($"Brand: {formula1.Brand}, Max Speed: {formula1.MaxSpeed}, Fuel Type: {formula1.FuelType}" +
            $"Manufacture Country: {formula1.ManufactureCountry}, Transmission: {formula1.Transmission}, Horse power: {formula1.Horsepower}");
    }
    else if (input == "Rally")
    {
        Console.WriteLine("Enter brand");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter max speed");
        string maxSpeed = Console.ReadLine();

        Console.WriteLine("Enter fuel type");
        string fuelType = Console.ReadLine();

        Console.WriteLine("Enter manufacture country");
        string manufactureCountry = Console.ReadLine();

        Console.WriteLine("Enter transmission");
        string transmission = Console.ReadLine();

        Console.WriteLine("Enter number of cylinders");
        int numberOfCylinders = int.Parse(Console.ReadLine());

        Rally rally = new Rally(brand, maxSpeed, fuelType, manufactureCountry, transmission, numberOfCylinders);
        Console.WriteLine($"Brand: {rally.Brand}, Max Speed: {rally.MaxSpeed}, Fuel Type: {rally.FuelType}" +
            $"Manufacture Country: {rally.ManufactureCountry}, Transmission: {rally.Transmission}, Number of cylinders: {rally.NumberOfCylinders}");
    }
    else if (input == "Offroad")
    {
        Console.WriteLine("Enter brand");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter max speed");
        string maxSpeed = Console.ReadLine();

        Console.WriteLine("Enter fuel type");
        string fuelType = Console.ReadLine();

        Console.WriteLine("Enter manufacture country");
        string manufactureCountry = Console.ReadLine();

        Console.WriteLine("Enter transmission");
        string transmission = Console.ReadLine();

        Console.WriteLine("Enter number of airbags");
        int numberOfAirbags = int.Parse(Console.ReadLine());

        OffRoad offroad = new OffRoad(brand, maxSpeed, fuelType, manufactureCountry, transmission, numberOfAirbags);
        Console.WriteLine($"Brand: {offroad.Brand}, Max Speed: {offroad.MaxSpeed}, Fuel Type: {offroad.FuelType}" +
            $"Manufacture Country: {offroad.ManufactureCountry}, Transmission: {offroad.Transmission}, Number of cylinders: {offroad.NumberOfAirbags}");
    }
    else
    {
        Console.WriteLine("Such text is not in the list of transport types. Enter correct text");
    }
}

create();
