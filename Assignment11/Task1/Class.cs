using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Calculate<T> : IInterface<T>
    {
        public T Add(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a + b;
        }

        public T Substract(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a - b;
        }
        public T Multiply(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a * b;
        }
    }
}