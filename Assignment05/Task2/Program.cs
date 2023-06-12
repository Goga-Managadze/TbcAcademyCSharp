// See https://aka.ms/new-console-template for more information

//2. დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც მომხმარებელს მოსთხოვს შეიყვანოს მასივის ზომა
//და შემდეგ შეავსებინებს მასივის ელემენტებს კონსოლიდან, მასივი უნდა იყოს char-ების, ფუნქციამ უნდა
//დააბრუნოს მომხმარებლის მიერ შევსებული მასივი. დაწერე მეორე ფუნქცია, რომელიც პირველი ფუნქციის
//დახმარებით პარამეტრად მიიღებს უკვე შევსებულ მასივს და სიმბოლოს, თუ ასეთი სიმბოლო მოიძებნა
//პარამეტრად გადმოცემულ მასივში მაშინ ფუნქციამ უნდა დააბრუნოს ის რიცხვი თუ რამდენჯერაც შეგვხდება
//მასივში გადმოცემული სიმბოლო. მაგალითად: თუ 'a' არის მასივში 2 ჯერ, უნდა დააბრუნოს 2. დაწერეთ
//მესამე ფუნქცია, რომელიც დაბეჭდავს მიღებულ შედეგებს, სიმბოლო 'a' shegvxda 2 jer ასეთი სახით.

void createarray()
{
    Console.WriteLine($"Enter the size of the char array");
    int Arraysize = int.Parse(Console.ReadLine());
    char[] chars = new char[Arraysize];

    for (int i = 0; i < Arraysize; i++)
    {
        Console.WriteLine("Enter array element");
        char input = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Entered element: " + input);
        chars[i] = input;
    }

    Console.Write("Array: ");

    foreach (var i in chars)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
    countsymbol(chars);
    
}

void countsymbol(char[] chars)
{
    int count = 0;
    Console.WriteLine("Enter symbol");

    char inputchar = Convert.ToChar(Console.ReadLine());

    for(int j = 0; j < chars.Length; j++)
    {
        if (chars[j] == inputchar)
        {
            count++;
        }
    }

    Console.WriteLine("Count: " + count);
    resultfunction(inputchar, count);
}

void resultfunction(char inputchar, int count)
{
    Console.WriteLine("The symbol " + "'" + inputchar + "'" + " is used " + count + " times.");
}

createarray();
