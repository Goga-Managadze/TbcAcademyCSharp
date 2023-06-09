// See https://aka.ms/new-console-template for more information

//4.შესაქმნელია კონსოლური აპლიკაცია რომელსაც გადაეცემა ერთგანზომილებიანი მასივის ზომა N,
//და მასვის ელემენტები, ნატურალური რიცხვები. პროგრამამ შედეგად უნდა დაბეჭდოს შეყვანილ
//მასივში არსებული ყველაზე გრძელი ზრდადი რიცხვების მონაკვეთი. მაგალითად,
//{0, -1, 2, 3, 0, 5, 10, 20, 0} მასივის შემთხვევაში უნდა დაიბეჭდოს 0, 5, 10, 20

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


int maxLength = 0;
int startIndex = 0;
int currentLength = 1;
int currentStartIndex = 0;


for (int i = 1; i < intarray.Length; i++)
{
    if (intarray[i] > intarray[i - 1])
    {
        currentLength++;


        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            startIndex = currentStartIndex;
        }
    }
    else
    {
        currentLength = 1;
        currentStartIndex = i;
    }
}

for (int i = startIndex; i < startIndex + maxLength; i++)
{
    Console.Write(intarray[i] + " ");
}
