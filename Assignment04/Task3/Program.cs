// See https://aka.ms/new-console-template for more information

//3. შესაქმნელია კონსოლური აპლიკაცია რომელიც მიიღებს ორი ერთგანზომილებიან მასივს, დალაგების მიმართლებას,
//ზრდადებოთ (ASC) ან კლებადობით (DESC) გააერთიანებს მათ, დაალაგებს შესაბამისად და დაბეჭდავს შედეს.

Console.WriteLine($"Enter the size of the first array");
int N = int.Parse(Console.ReadLine());

int[] array1 = new int[N];

Console.WriteLine($"Array size is {N}");
Console.WriteLine($"Enter {N} elements:");

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Enter array element");
    int input = int.Parse(Console.ReadLine());
    array1[i] = input;
}

Console.Write("Array1: ");
foreach (var i in array1)
{
    Console.Write(i + " ");
}
Console.WriteLine();

Console.WriteLine($"Enter the size of the second array");
N = int.Parse(Console.ReadLine());

int[] array2 = new int[N];

Console.WriteLine($"Array size is {N}");
Console.WriteLine($"Enter {N} elements:");

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Enter array element");
    int input = int.Parse(Console.ReadLine());
    array2[i] = input;
}

Console.Write("Array1: ");
foreach (var i in array2)
{
    Console.Write(i + " ");
}
Console.WriteLine();

int[] array3 = array1.Concat(array2).ToArray();


Console.WriteLine("concatenated array:");
foreach (var i in array3)
{
    Console.Write(i + " ");
}
Console.WriteLine();

Console.WriteLine("If you want to sort in ascending order enter ASC and if you want to sort in descending order enter DESC");

string input1 = Console.ReadLine();
if (input1 == "ASC")
{
    Array.Sort(array3);
    foreach (var i in array3)
    {

        Console.Write(i + " ");
    }
}
else if (input1 == "DESC")
{
    Array.Sort(array3);
    Array.Reverse(array3);
    foreach (var i in array3)
    {

        Console.Write(i + " ");
    }
}
else
{
    Console.WriteLine("Your input wasn't ASC or DESC");
}

