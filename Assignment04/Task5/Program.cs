// See https://aka.ms/new-console-template for more information

//5.შესაქმნელია კონსოლური აპლიკაცია რომელსაც გადაეცემა მატრიცა 2 x 2 ან 3 x 3
//და შედეგად დაიბეჭდება თავად შეყვანილი მატრიცა და მატრიცის დეტერმინანტი

Console.WriteLine("If you want to calculate determinant of the array [2,2], " +
    "enter 2 and if you want to calculate determinant of the array  [3,3] enter 3");
int N = int.Parse(Console.ReadLine());
if (N == 2)
{
    int[,] Array = new int[2, 2];

    Console.WriteLine("Enter array elements of array [2,2]");
   
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            int input = int.Parse(Console.ReadLine());
            Array[i, j] = input;
        }
    }
    int determinant = (Array[0, 0] * Array[1, 1]) - (Array[0, 1] * Array[1, 0]);
    Console.WriteLine("determinant: " + determinant);
}
else if (N == 3)
{
    int[,] Array1 = new int[3, 3];

    Console.WriteLine("Enter array elements of array [3,3]");
    
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            int input1 = int.Parse(Console.ReadLine());
            Array1[i, j] = input1;
        }
    }

    int determinant = Array1[0, 0] * (Array1[1, 1] * Array1[2, 2] - Array1[1, 2] * Array1[2, 1]) -
                      Array1[0, 1] * (Array1[1, 0] * Array1[2, 2] - Array1[1, 2] * Array1[2, 0]) +
                      Array1[0, 2] * (Array1[1, 0] * Array1[2, 1] - Array1[1, 1] * Array1[2, 0]);
    Console.WriteLine("determinant: " + determinant);
}
else
{
    Console.WriteLine("Entered number isn't 2 or 3");
}
