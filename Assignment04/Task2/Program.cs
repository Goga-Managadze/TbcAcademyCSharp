// See https://aka.ms/new-console-template for more information

//2. შესაქმნელია კონსოლური აპლიკაცია რომელსაც გადაეცემა ერთგანზომილებიანი მასივის ზომა N,
//და მასვის ელემენტები, სიტყვები. ყველა ელემენტის შეყვანის შემდეგ პროგრამამ უნდა გვთხოვოს
//მეორე მასივის ზომის და ელემენტების, რიცხვების შეყვანა. მეორე მასივის ყველა ელემენტის შეყვანის
//შემდეგ პირველი და მეროე მასივი უნდა გაერთიანდეს ისე რომ პირველი მასივის პირველი ელემენტის
//შემდეგ იდგეს მეორე მასივისპირველი ელემენტი და ა.შ. კონსოლში უნდა დაიბეჭდოს გაერთიანებული
//მასივის ყველა ელემენტი.

Console.WriteLine($"Enter the size of the string array");
int N = int.Parse(Console.ReadLine());

string[] stringarray = new string[N];

Console.WriteLine($"Array size is {N}");
Console.WriteLine($"Enter {N} elements:");

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Enter array element");
    string input = Console.ReadLine();
    stringarray[i] = input;
}

Console.Write("Array1: ");
foreach (var i in stringarray)
{
    Console.Write(i + " ");
}
Console.WriteLine();


Console.WriteLine($"Enter the size of the integers array");
N = int.Parse(Console.ReadLine());

int[] integersarray = new int[N];

Console.WriteLine($"Array size is {N}");
Console.WriteLine($"Enter {N} elements:");

for (int j = 0; j < N; j++)
{
    Console.WriteLine("Enter array element");
    int integerinput = int.Parse(Console.ReadLine());
    integersarray[j] = integerinput;
}

Console.Write("Array2: ");
foreach (var j in integersarray)
{
    Console.Write(j + " ");
}
Console.WriteLine();

string[] arrayindexes = new string[stringarray.Length];
for (int j = 0; j < stringarray.Length; j++)
{
    arrayindexes[j] = stringarray[j] + " " + integersarray[j];
    Console.Write(arrayindexes[j] + ",");
}
