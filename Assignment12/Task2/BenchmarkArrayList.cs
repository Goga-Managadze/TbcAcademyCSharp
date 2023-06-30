using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchmarkArrayList
    {
        ArrayList arrList = new ArrayList();

        [Benchmark]
        public void arrayAdd()
        {
            arrList.Add("animal");
            arrList.Add("plant");
            arrList.Add("thing");
        }


        [Benchmark]
        public void arrayRemove()
        {
            arrList.Remove(6);
            arrList.RemoveAt(2);
        }
    }
}
