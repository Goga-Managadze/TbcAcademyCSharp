using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SequentialCalculator
    {
        public static long CalculateSequentialSum(int[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public async Task<long> CalculateSumAsync(int[] array)
        {
            return await Task.Run(() => CalculateSequentialSum(array));
        }
    }
}
