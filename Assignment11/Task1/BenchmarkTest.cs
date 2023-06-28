using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Task1
{
    public class BenchmarkTest
    {
        Calculate<int> integerCalculate = new Calculate<int>();
        Calculate<double> doubleCalculate = new Calculate<double>();

        [Benchmark]
        public void Add()
        {
            integerCalculate.Add(30, 20);
            doubleCalculate.Add(3.5, 2.5);
        }

        [Benchmark]
        public void Substract()
        {
            integerCalculate.Substract(30, 20);
            doubleCalculate.Substract(3.5, 2.5);
        }

        [Benchmark]
        public void Multiply()
        {
            integerCalculate.Multiply(30, 20);
            doubleCalculate.Multiply(3.5, 2.5);
        }
    }
}
