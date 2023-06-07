// See https://aka.ms/new-console-template for more information

//3.დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს N რიცხვს და გამოიტანს დადებითების საშუალო არითმეტიკულს და ჯამს.
decimal num1 = 0;
int count = 0;
decimal average = 0;

while (true)
{

    decimal number = decimal.Parse(Console.ReadLine());
    if (number > 0)
    {
        decimal num2 = number;

        decimal sum = num1 + num2;

        num1 = sum;
        count++;
        average = num1 / count;

        Console.WriteLine("The sum of the entered numbers: " + num1);
        Console.WriteLine("Arithmetic average of the entered numbers: " + average);
    }
    else
    {
        Console.WriteLine(number + " is not a positive number and will not be taken into account in the calculation");
        Console.WriteLine("The sum of the entered numbers: " + num1);
        Console.WriteLine("Arithmetic average of the entered numbers: " + average);
    }
}

