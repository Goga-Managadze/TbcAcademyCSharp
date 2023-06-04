// See https://aka.ms/new-console-template for more information

int temperature = int.Parse(Console.ReadLine());
if (temperature < 0)
{
    Console.WriteLine("It's Freezing");
}
else if (temperature >= 0 && temperature <= 30)
{
    Console.WriteLine("Weather is good");
}
else
{
    Console.WriteLine("It's Hot");
}
