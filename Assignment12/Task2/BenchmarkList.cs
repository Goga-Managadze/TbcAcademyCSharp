using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchmarkList
    {
        List<int> list = new List<int>();

        [Benchmark]
        public void arrListAdd()
        {
            list.Add(8);
            list.Add(9);
        }

        [Benchmark]
        public void arrListInsert()
        {
            list.Insert(0, 10);
            list.Add(9);
        }

        [Benchmark]
        public void arrListRemove()
        {
            list.Remove(9);
            list.RemoveRange(2, 5);
        }

        [Benchmark]
        public void arrListSort()
        {
            list.Sort();
        }
    }
}
