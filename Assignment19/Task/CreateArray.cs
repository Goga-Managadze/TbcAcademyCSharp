using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class CreateArray
    {
        public static int[] createArray()
        {
            int size = 10000000;
            var random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100);
            }
            return array;
        }
    }
}
