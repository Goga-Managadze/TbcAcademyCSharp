using Task2;

Console.WriteLine("Enter first triangle sides");

Console.WriteLine("First side of the triangle 1:");
double firstSideOfTriangle1 = double.Parse(Console.ReadLine());
Console.WriteLine("Second side of the triangle 1:");
double secondSideOfTriangle1 = double.Parse(Console.ReadLine());
Console.WriteLine("Third side of the triangle 1:");
double thirdSideOfTriangle1 = double.Parse(Console.ReadLine());

Triangle firstTriangle = new Triangle(firstSideOfTriangle1, secondSideOfTriangle1, thirdSideOfTriangle1);

Console.WriteLine("Enter second triangle sides");

Console.WriteLine("First side of the triangle 2:");
double firstSideOfTriangle2 = double.Parse(Console.ReadLine());
Console.WriteLine("Second side of the triangle 2:");
double secondSideOfTriangle2 = double.Parse(Console.ReadLine());
Console.WriteLine("Third side of the triangle 2:");
double thirdSideOfTriangle2 = double.Parse(Console.ReadLine());

Triangle secondTriangle = new Triangle(firstSideOfTriangle2, secondSideOfTriangle2, thirdSideOfTriangle2);

bool result1 = firstTriangle == secondTriangle;
Console.WriteLine($"Is the first triangle equal to the second triangle? - {result1}");


bool result2 = firstTriangle != secondTriangle;
Console.WriteLine($"Is the first triangle not equal to the second triangle? - {result2}");

bool result3 = firstTriangle < secondTriangle;
Console.WriteLine($"Is the first triangle smaller than the second? - {result3}");

bool result4 = firstTriangle > secondTriangle;
Console.WriteLine($"Is the first triangle larger than the second? - {result4}");



