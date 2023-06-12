// See https://aka.ms/new-console-template for more information

//1. დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც პირველ პარამეტრად იღებს მთელი რიცხვების
//მასივს, მეორე პარამეტრად იღებს მთელ რიცხვს (index), ფუნქციამ უნდა დაითვალოს იმ ელემენტის ციფრების
//ჯამი, რომლის ინდექსი არის მეორე პარამეტრი. მაგალითად: თუ ინდექს 2-ზე წერია ელემენტი 123 ფუნქციამ
//უნდა დააბრუნოს 6.
int function(int[] integers, int index)
{
    int total = 0;
    string convertedtostringvalue = integers[index].ToString();
    char[] chars = convertedtostringvalue.ToCharArray();
    int[] intArray = chars.Select(c => (int)Char.GetNumericValue(c)).ToArray();
    int length = convertedtostringvalue.Length - 1;
    for (int i = 0; i < convertedtostringvalue.Length; i++)
    {
        chars[i]= convertedtostringvalue[i];
    }

    foreach (int i in intArray)
    {
        total += i;
    }
        return total;
    }

Console.WriteLine(function(new int[] { 2, 5, 52, 555 }, 2));

Console.WriteLine(function(new int[] { 25, 50, 77, 100 }, 3));