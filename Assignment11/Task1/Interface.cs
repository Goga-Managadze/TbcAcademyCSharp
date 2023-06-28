using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IInterface<T>
    {
        T Add(T x, T y);
        T Substract(T x, T y);
        T Multiply(T x, T y);
    }
}
