// See https://aka.ms/new-console-template for more information

//1.დაწერეთ პროგრამა რომელსაც კონსოლიდან გადავცემთ რიცხვს და პასუხად დაბეჭდავს რიცხვი მარტივია თუ შედგენილი.
int dividend = int.Parse(Console.ReadLine());
int divisor = 1;
int count = 0;

while (divisor <= dividend)
{
    if (dividend % divisor == 0)
    {
        count += 1;
    }
    divisor += 1;
}

if (count == 2)
{
    Console.WriteLine("martivi ricxvi");
}
else if (dividend == 1)
{
    Console.WriteLine("1 ar aris arc martivi ricxvi da arc shedgenili");
}
else
{
    Console.WriteLine("shedgenili ricxvi");
}
