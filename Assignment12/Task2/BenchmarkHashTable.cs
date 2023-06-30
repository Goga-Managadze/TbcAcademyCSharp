using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchmarkHashTable
    {
        Hashtable number = new Hashtable();

        [Benchmark]
        public void hashTableAdd()
        {
            number.Add(1, "erti");
            number.Add(2, "ori");
            number.Add(3, "sami");
        }

        [Benchmark]
        public void hashTableRemove()
        {
            number.Remove(3);
        }

        [Benchmark]
        public void hashTableContains()
        {
            number.Contains(1);
        }
    }
}
