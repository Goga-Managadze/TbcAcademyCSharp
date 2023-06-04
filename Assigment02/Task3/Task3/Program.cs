// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your birth year");
int birthyear = int.Parse(Console.ReadLine());
int calculate = birthyear % 12;
switch (calculate)
{
    case 0:
        Console.WriteLine("You were born in the year of the monkey.");
        break;
    case 1:
        Console.WriteLine("You were born in the year of the rooster.");
        break;
    case 2:
        Console.WriteLine("You were born in the year of the dog.");
        break;
    case 3:
        Console.WriteLine("You were born in the year of the boar.");
        break;
    case 4:
        Console.WriteLine("You were born in the year of the rat.");
        break;
    case 5:
        Console.WriteLine("You were born in the year of the ox.");
        break;
    case 6:
        Console.WriteLine("You were born in the year of the tiger.");
        break;
    case 7:
        Console.WriteLine("You were born in the year of the rabbit.");
        break;
    case 8:
        Console.WriteLine("You were born in the year of the dragon.");
        break;
    case 9:
        Console.WriteLine("You were born in the year of the snake.");
        break;
    case 10:
        Console.WriteLine("You were born in the year of the horse.");
        break;
    default:
        Console.WriteLine("You were born in the year of the goat.");
        break;
}
