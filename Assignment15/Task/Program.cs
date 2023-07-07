// See https://aka.ms/new-console-template for more information

using System.Reflection;
using Task;

Console.WriteLine("Choose a class to create. Enter 1 or 2");
Console.WriteLine("1. Class 'Book'");
Console.WriteLine("2. Class 'Motorcycle'");

int input = int.Parse(Console.ReadLine());

Type type = null;

if (input == 1)
{
    type = typeof(Book);
}
else if (input == 2)
{
    type = typeof(Motorcycle);
}
else
{
    Console.WriteLine("Enter correct number: 1 or 2");
}

object typeInstance = Activator.CreateInstance(type);

Console.WriteLine($"You choose class: {type.Name}");

MethodInfo[] classMethods = type.GetMethods();

Console.WriteLine("Available methods of this class:");

int j = 0;
foreach (MethodInfo method in classMethods)
{
    j++;
    if (method.DeclaringType == type)
    {
        Console.WriteLine(j + " method name: " + method.Name);
    }
}

Console.WriteLine();

Console.WriteLine("Enter the name of the method to invoke:");
string methodName = Console.ReadLine();

MethodInfo selectedMethod = null;

foreach (MethodInfo method in classMethods)
{
    if (method.Name == methodName && method.DeclaringType == type)
    {
        selectedMethod = method;
        break;
    }
}

if (selectedMethod == null)
{
    Console.WriteLine("Method name is not correct.");
    return;
}

ParameterInfo[] parameters = selectedMethod.GetParameters();

object[] methodArguments = new object[parameters.Length];

for (int i = 0; i < parameters.Length; i++)
{
    Console.WriteLine($"Enter value for parameter '{parameters[i].Name}' (Data type: {parameters[i].ParameterType.Name}):");

    string input1 = Console.ReadLine();

    methodArguments[i] = Convert.ChangeType(input1, parameters[i].ParameterType);
}

object result = selectedMethod.Invoke(typeInstance, methodArguments);

Console.WriteLine($"Method '{selectedMethod.Name}' invoked successfully.");