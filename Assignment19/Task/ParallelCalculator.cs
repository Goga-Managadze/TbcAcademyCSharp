using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class ParallelCalculator
    {
        public static long CalculateParallelSum(int[] array)
        {
            long sum = 0;
            Parallel.For(0, array.Length, i =>
            {
                sum += array[i];
            });
            return sum;
        }
    }
}
