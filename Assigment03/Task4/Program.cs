// See https://aka.ms/new-console-template for more information

//4.დაწერეთ კონსოლური აპლიკაცია რომელიც მომხმარებლისგან მიიღებს შემავალ პარამეტრად რიცხვს და
//შემდეგ დაბეჭდავს ამ რიცხვის შესაბამისი სართულების "პირამიდას".

int input = int.Parse(Console.ReadLine());
Console.WriteLine("Height: " + input);
for (int i = 0; i < input; i++)
{
    for (int j = 1; j <= input - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine("*");
}
