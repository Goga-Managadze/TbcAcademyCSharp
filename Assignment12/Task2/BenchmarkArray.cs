using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchmarkArray
    {
        string[] countriesArray = { "Georgia", "France" };

        [Benchmark]
        public void Count() {
            countriesArray.Count();
        }
    }
}
