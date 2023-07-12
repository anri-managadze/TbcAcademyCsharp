using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Devide(double a, double b)
        {
            return a / b;
        }

        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
