// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Task1;

//Calculate<int> integerCalculate = new Calculate<int>();
//int sum = integerCalculate.Add(30, 20);
//int difference = integerCalculate.Substract(30, 20);
//int multiply = integerCalculate.Multiply(30, 20);

//Console.WriteLine($"sum: {sum}");
//Console.WriteLine($"difference: {difference}");
//Console.WriteLine($"multiplied: {multiply}");

//Calculate<double> doubleCalculate = new Calculate<double>();
//double sum1 = doubleCalculate.Add(3.5, 2.5);
//double difference1 = doubleCalculate.Substract(3.5, 2.5);
//double multiply1 = doubleCalculate.Multiply(3.5, 2.5);

//Console.WriteLine($"sum: {sum1}");
//Console.WriteLine($"difference: {difference1}");
//Console.WriteLine($"multiplied: {multiply1}");

BenchmarkRunner.Run<BenchmarkTest>();