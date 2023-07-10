// See https://aka.ms/new-console-template for more information

using Task1;

Console.WriteLine("Select a method:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Pow");
Console.WriteLine("6. Sqrt");
Console.Write("Enter the method number: ");

int methodNum = int.Parse(Console.ReadLine());
MyDelegate del1;

switch (methodNum)
{
    case 1:
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());
        del1 = CalcMethods.Add;
        Console.WriteLine("Sum: " + del1(num1, num2));
        break;
    case 2:
        Console.WriteLine("Enter the first number:");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = double.Parse(Console.ReadLine());

        del1 = CalcMethods.Substract;
        Console.WriteLine("Difference: " + del1(num1, num2));
        break;
    case 3:
        Console.WriteLine("Enter the first number:");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = double.Parse(Console.ReadLine());

        del1 = CalcMethods.Multiply;
        Console.WriteLine("Multiply: " + del1(num1, num2));
        break;
    case 4:
        Console.WriteLine("Enter the first number:");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = double.Parse(Console.ReadLine());

        del1 = CalcMethods.Devide;
        Console.WriteLine("Devide: " + del1(num1, num2));
        break;
    case 5:
        Console.WriteLine("Enter the first number:");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = double.Parse(Console.ReadLine());

        del1 = CalcMethods.Pow;
        Console.WriteLine("Pow: " + del1(num1, num2));
        break;
    case 6:
        Console.WriteLine("Enter the number:");
        num1 = double.Parse(Console.ReadLine());

        MyDelegate1 del = CalcMethods.Sqrt;
        Console.WriteLine("Sqrt: " + del(num1));
        break;
    default:
        Console.WriteLine("Entered number is not correct");
        break;
}

public delegate double MyDelegate(double value1, double value2);
public delegate double MyDelegate1(double value);