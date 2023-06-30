using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchmarkSortedList
    {
        SortedList<int, string> bookNumbers = new SortedList<int, string>();

        [Benchmark]
        public void sortedListAdd()
        {
            bookNumbers.Add(1, "Book1");
            bookNumbers.Add(2, "Book2");
            bookNumbers.Add(3, "Book3");
        }


        [Benchmark]
        public void sortedListRemove()
        {
            bookNumbers.Remove(1);
        }
    }
}