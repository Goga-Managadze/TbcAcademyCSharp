using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public class BenchMarkTest
    {
        Storage<string> stringStorage = new Storage<string>();
        [Benchmark]
        public void Add()
        {
            stringStorage.Add("string1");
            stringStorage.Add("string2");
        }

        public void Update()
        {
            stringStorage.Update(1, "string3");
        }

        public void Delete()
        {
            stringStorage.Delete(0);
        }

    }
}
