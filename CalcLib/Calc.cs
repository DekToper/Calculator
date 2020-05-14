using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    abstract public class Calc 
    {
        static public double Multiplication(double a, double b)
        {
            return a * b;
        }

        static public double Division(double a, double b)
        {
            return a / b;
        }

        static public double Sum(double a, double b)
        {
            return a + b;
        }

        static public double Subtraction(double a, double b) 
        {
            return a - b;
        }

        static public double SqrtX(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }

        static public double DegreeY(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        static public double Square(double a)
        {
            return Math.Pow(a, 2.0);
        }

        static public double Factorial(double a)
        {
            double f = 1;

            for (int i = 1; i <= a; i++)
                f *= (double)i;

            return f;
        }
    }
}
