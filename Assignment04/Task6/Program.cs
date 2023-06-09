// See https://aka.ms/new-console-template for more information

//6. შესაქმნელია კონსოლური აპლიკაცია რომელსაც გადაეცემა ორი მატრიცია N x M და M x K ზომებით.
//პირველი მატრიცის სვერების რაოდენობა უნდა უდრიდეს მეორე მატრიცის ხაზების რაოდენობას, წინააღმდეგ
//შემთხვევაში გამოვიდეს შეტყობინება და მატრიცების შეყვანა მოითხოვოს თავიდან. პროგრამამ უნდა გამოთვალოს
//მატრიცების ნამრავლი და დაბეჭდოს შედეგად მიღებული მატრიცა. N x M * M x K = N x K

Console.WriteLine("Enter the number of rows of the first matrix");
    int N = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the number of columns of the first matrix");
    int M1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the number of rows of the second matrix");
    int M2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the number of columns of the second matrix");
    int K = int.Parse(Console.ReadLine());

    int[,] Array1 = new int[N, M1];
    int[,] Array2 = new int[M2, K];
    int[,] Array3 = new int[N, K];

if (M1 == M2)
    {
    for(int i = 0; i < N; i++)
    {
        for (int j = 0; j < K; j++)
        {
            for (int l = 0; l < M1; l++)
            {
                Array3[i, j] += Array1[i, l] * Array2[l, j];
            }
        }
    }
}
    else
    {
        Console.WriteLine("The number of columns of the first matrix isn't equal the number of " +
                          " rows of the second matrix");
    }
Console.WriteLine("N x K: ");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < K; j++)
    {
        Console.Write(Array3[i, j] + " ");
    }
    Console.WriteLine();
}