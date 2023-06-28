// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Task2;

//Storage<string> stringStorage = new Storage<string>();
//stringStorage.Add("string1");
//stringStorage.Add("string2");
//stringStorage.Update(1, "string3");
//stringStorage.Delete(0);

BenchmarkRunner.Run<BenchMarkTest>();