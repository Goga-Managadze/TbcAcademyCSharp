using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchmarkStack
    {
        Stack<int> stack = new Stack<int>();

        [Benchmark]
        public void stackPush()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
        }

        [Benchmark]
        public void stackPop()
        {
            stack.Pop();
        }

        [Benchmark]
        public void stackContains()
        {
            stack.Contains(1);
        }

        [Benchmark]
        public void stackPeek()
        {
            stack.Peek();
        }
    }
}
