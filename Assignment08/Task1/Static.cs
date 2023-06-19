using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Calculator
    {
        public static decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public static decimal Substract(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        public static decimal Multiply(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        public static decimal Devide(decimal number1, decimal number2)
        {
            return number1 / number2;
        }

        public static double Pow(double number1, double number2)
        {
            if (number2 == 0)
            {
                return 1;
            }
            else if (number2 > 0) 
            {
                double result = number1;
                for (int i = 1; i < number2; i++)
                {
                    result *= number1;
                }
                return result;
            }
            else
            {
                double result = 1;
                for (int i = -1;i >= number2; i--)
                {
                    result /= number1;
                }
                return result;
            }
        }

        public static double Sqrt(double number1)
        {
            if (number1 > 0)
            {
                double root = number1 / 3;
                for (int i = 0; i < number1; i++)
                {
                    root = (root + number1 / root) / 2;
                }
                return root;
            }
            else 
            {
                return 0;
            };
        }
    }
}
