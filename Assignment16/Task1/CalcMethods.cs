using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class CalcMethods
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Substract(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Devide(double number1, double number2)
        {
            return number1 / number2;
        }

        public static double Pow(double number1, double number2)
        {
            return Math.Pow(number1,number2);
        }

        public static double Sqrt(double number1)
        {
            return Math.Sqrt(number1);
        }
    }
}
