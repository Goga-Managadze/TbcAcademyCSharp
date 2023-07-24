// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Task1;

int[] array = CreateArray.createArray();

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
var sequentialSum = SequentialCalculator.CalculateSequentialSum(array);
stopwatch.Stop();
Console.WriteLine($"Sequential Sum: {sequentialSum}, Time: {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Restart();
var parallelSum = ParallelCalculator.CalculateParallelSum(array);
stopwatch.Stop();
Console.WriteLine($"Parallel Sum: {parallelSum}, Time: {stopwatch.ElapsedMilliseconds} ms");
