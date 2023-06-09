// See https://aka.ms/new-console-template for more information

//1.შესაქმნელია კონსოლური აპლიკაცია რომელსაც გადაეცემა ერთგანზომილებიანი მასივის ზომა N,
//და მასვის ელემენტები, ნატურალური რიცხვები. მასივის ყველა ელემენტის შეყვანის შემდეგ კონსოლში
//უნდა დაიბეჭდოს ზრდადობით დალაგებული მასივის ელემენტები. დალაგების ალგორითმის რეალიზაცია
//უნდა მოახდინოთ თავად და არა მზა საშუალებების გამოყენებით. სორტირების ალგორითმი რეალიზებული
//უნდა იყოს შემდეგი პრინციპით - მასივის ყოველი ელემენტი უნდა შედარდეს მომდევნო ელემენტთან, და თუ
//ელემენტი მეტია მომდევნოზე ელემენტები უნდა გადაანაცვლონ მდებარეობა. შედარება და გადანაცვლება უნდა
//განმეორდეს მანამ სანამ მასივი არ დალაგდება სრულად.

Console.WriteLine($"Enter the size of the array");
int N = int.Parse(Console.ReadLine());

int[] intarray = new int[N];

Console.WriteLine($"Array size is {N}");
Console.WriteLine($"Enter {N} elements:");

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Enter array element");
    int input = int.Parse(Console.ReadLine());
    intarray[i] = input;
}

foreach (int i in intarray)
{
    Console.Write(i + " ");
}
Console.WriteLine("Array without sorting");
Console.WriteLine();

for (int j = 0; j < intarray.Length; j++)
{
    for (int k = j + 1; k < intarray.Length; k++)
    {
        if (intarray[j] > intarray[k])
        {
            intarray[j] = intarray[j] + intarray[k];
            intarray[k] = intarray[j] - intarray[k];
            intarray[j] = intarray[j] - intarray[k];
        }
    }

    Console.Write(intarray[j] + " ");
}
Console.WriteLine("Array with sorting");