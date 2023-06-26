// See https://aka.ms/new-console-template for more information

using Task1;
Console.WriteLine("Enter values for Matrix1:");
var result = Matrix.createMatrix();
Matrix matrix1 = new Matrix(result);

Console.WriteLine("Enter values for Matrix2:");
var result2 = Matrix.createMatrix();
Matrix matrix2 = new Matrix(result2);


Console.WriteLine("Addition Result:");
Matrix sumResult = matrix1 + matrix2;
Console.WriteLine(sumResult.ToString());

Console.WriteLine("Multiplied Result:");
Matrix multResult = matrix1 * matrix2;
Console.WriteLine(multResult.ToString());

Console.WriteLine("Difference Result:");
Matrix difference = matrix1 - matrix2;
Console.WriteLine(difference.ToString());







