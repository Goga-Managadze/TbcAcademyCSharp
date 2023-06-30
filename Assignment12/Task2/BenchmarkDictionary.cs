using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchmarkDictionary
    {
        IDictionary<int, string> dictionary = new Dictionary<int, string>();

        [Benchmark]
        public void dictionaryAdd()
        {
            dictionary.Add(1, "book1");
            dictionary.Add(2, "book2");
            dictionary.Add(3, "book3");
        }

        [Benchmark]
        public void dictionaryContains()
        {
            dictionary.ContainsKey(1);
        }

        [Benchmark]
        public void dictionaryRemove()
        {
            dictionary.Remove(1);
        }
    }
}
