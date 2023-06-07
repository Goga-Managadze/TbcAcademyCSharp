// See https://aka.ms/new-console-template for more information

//2.დაწერეთ პროგრამა რომელსაც კონსოლიდან გადავცემთ რიცხვს და პასუხად დაბეჭდავს შეყვანილი რიცხვის გამყოფების რაოდენობას.
//მაგალითად, თუ შევიყვანთ 6-ს, უნდა დაიბეჭდოს 4-ს (1, 6, 2, 3).

int dividend = int.Parse(Console.ReadLine());
int divisor = 1;
int count = 0;

while (divisor <= dividend)
{
    if (dividend % divisor == 0)
    {
        count += 1;
        //Console.WriteLine("divisors are" + divisor);
        Console.Write(divisor + ",");
    }
    divisor += 1;
}
Console.WriteLine("\n" + "Count of divisors: " + count);
