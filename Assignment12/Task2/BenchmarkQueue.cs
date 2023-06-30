using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchmarkQueue
    {
        Queue<int> numbersQueue = new Queue<int>();

        [Benchmark]
        public void queueEnqueue()
        {
            numbersQueue.Enqueue(1);
            numbersQueue.Enqueue(2);
            numbersQueue.Enqueue(3);
            numbersQueue.Enqueue(4);
        }

        [Benchmark]
        public void queueDequeue()
        {
            numbersQueue.Dequeue();
        }

        [Benchmark]
        public void queuePeek()
        {
            numbersQueue.Peek();
        }
    }
}
