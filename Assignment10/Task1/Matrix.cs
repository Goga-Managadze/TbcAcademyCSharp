using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1

{
    public class Matrix
    {
        
        public int[,] _data { get; set; }
        public Matrix(int[,] data)
        {
            _data = data;

        }

        public static int[,] createMatrix()
        {
            int[,] matrix = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = input;
                }
            }
            return matrix;
        }
        public static Matrix operator +(Matrix array, Matrix array1)
        {

            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = array._data[i, j] + array1._data[i, j];
                }
            }
            return new Matrix(result);
        }
        public static Matrix operator -(Matrix array, Matrix array1)
        {

            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = array._data[i, j] - array1._data[i, j];
                }
            }
            return new Matrix(result);
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            
            int[,] matrixMultiplied = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        sum += matrix1._data[i, k] * matrix2._data[k, j];
                    }
                    matrixMultiplied[i, j] = sum;
                }
            }
            return new Matrix(matrixMultiplied);
        }
        public override bool Equals(object obj)
        {
            Matrix matrix = (Matrix)obj;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (_data[i, j] != matrix._data[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output += _data[i, j] + " ";
                }
                output += "\n";
            }
            return output;
        }
    }
}


