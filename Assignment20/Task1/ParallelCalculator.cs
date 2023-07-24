using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ParallelCalculator
    {
        public static long CalculateParallelSum(int[] array)
        {
            long sum = 0;
            object lockObj = new object();

            Parallel.For(0, array.Length, i =>
            {
                lock (lockObj)
                {
                    sum += array[i];
                }
            });
            return sum;
        }

        public async Task<long> CalculateSumAsync(int[] array)
        {
            return await Task.Run(() => CalculateParallelSum(array));
        }
    }
}
