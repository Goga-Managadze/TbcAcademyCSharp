using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1

{

    public class Matrix
    {
        int i;
        int j;
        int[,] Array = new int[2, 2];
        int[,] Array1 = new int[2, 2];
        public void createMatrix()
        {
            for (int t = 0; t < 2; t++) {
                if (t == 0)
                {
                    Console.WriteLine("Enter array elements of first array [2,2]");

                    for (i = 0; i < 2; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            int input = int.Parse(Console.ReadLine());
                            Array[i, j] = input;
                            //Console.Write(Array[i, j] + " ");

                        }
                        //Console.WriteLine();
                    }
                    Console.WriteLine("First matrix");
                    Console.Write(Array[0, 0] + " " + Array[0, 1]);
                    Console.WriteLine();
                    Console.Write(Array[1, 0] + " " + Array[1, 1]);

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter array elements of Second array [2,2]");
                    //}
                    //int[,] Array = new int[2, 2];

                    //Console.WriteLine("Enter array elements of array [2,2]");

                    for (i = 0; i < 2; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            int input = int.Parse(Console.ReadLine());
                            Array1[i, j] = input;
                            //Console.Write(Array[i, j] + " ");

                        }
                        //Console.WriteLine();
                    }
                    //if (t == 0)
                    //{
                    //    Console.WriteLine("First matrix");
                    //    Console.Write(Array[0, 0] + " " + Array[0, 1]);
                    //    Console.WriteLine();
                    //    Console.Write(Array[1, 0] + " " + Array[1, 1]);
                    //}
                    //else
                    //{
                    Console.WriteLine("Second matrix");
                    Console.Write(Array1[0, 0] + " " + Array1[0, 1]);
                    Console.WriteLine();
                    Console.Write(Array1[1, 0] + " " + Array1[1, 1]);
                    Console.WriteLine();
                    //}
                }

               

                Console.WriteLine();
            }
        }
 
    }
}


