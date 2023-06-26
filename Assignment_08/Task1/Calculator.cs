using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Calculator
    {
        // Add
        public static decimal add(decimal a, decimal b)
        {
            return a + b;
        }

        //Subtract
        public static decimal subtract(decimal a, decimal b) 
        {
            return a - b; 
        }

        //Multiply
        public static decimal multiply(decimal a, decimal b)
        {
            return a * b;
        }

        //Divide
        public static decimal Divide(decimal a, decimal b)
        {
            return (a / b);
        }

        //Pow
        public static double Pow(double a, double b) {
            double result = 1;
            if (b > 0)
            {
                for (double i = 1; i <= b; i++)
                {
                    result *= a;
                }
            }else if (b < 0)
            {
                for(double i = -1; i >= b; --i)
                {
                    result /= a;
                }
            }
            return result;
        }

        //Sqrt
        public static double Sqrt(double a)
        {
            double result = 1;
            double i = 0;
            while (true)
            {
                i++;
                result = (a / result + result) / 2;
                if(i == (int)a+1)
                {
                    break;
                }
            }
            return result;
        }
        
    }
}
