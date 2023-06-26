using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle
    {
        private double _side1 { get; set; }
        private double _side2 { get; set; }
        private double _side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            if (!checkEqualityOfTriangle())
            {
                throw new ArgumentException("Not valid");
            }
        }

        public double Side1 { get { return _side1; } }
        public double Side2 { get { return _side2; } }
        public double Side3 { get { return _side3; } }

        public double Perimeter()
        {
            double perimeter = _side1 + _side2 + _side3;
            return perimeter;
        }

        public double Area()
        {
            double halfPerimeter = (_side1 + _side2 + _side3) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - _side1) * (halfPerimeter - _side2) * (halfPerimeter - _side3));

            return area;
        }

        public static bool operator ==(Triangle first, Triangle second)
        {
            return first._side1 == second._side1 && first._side2 == second._side2 && first._side3 == second._side3;
        }

        public static bool operator !=(Triangle first, Triangle second)
        {
            return first._side1 != second._side1 || first._side2 != second._side2 || first._side3 != second._side3;
        }

        public static bool operator <(Triangle a, Triangle b)
        {
            return a.Area() < b.Area();
        }

        public static bool operator >(Triangle first, Triangle second)
        {
            return first.Area() > second.Area();
        }

        public bool checkEqualityOfTriangle()
        {
            return _side1 + _side2 > _side3 && _side1 + _side3 > _side2 && _side2 + _side3 > _side1;
        }

        public static explicit operator Triangle(double side)
        {
            Triangle equilateralTriangle = new Triangle(side, side, side);
            return equilateralTriangle;
        }
    }
}
