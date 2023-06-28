using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Test
    {
        IGeneric<int> intCalc = new GenGeneric<int>();
        IGeneric<decimal> decimalCalc = new GenGeneric<decimal>();
        IGeneric<double> doubleCalc = new GenGeneric<double>();

        [Benchmark]
        public void Add()
        {
            intCalc.Add(1, 5);
            decimalCalc.Add(1.5M, 2.8M);
            doubleCalc.Add(1.5D, 2.8D);
        }
        [Benchmark]
        public void Subtract()
        {
            intCalc.Subtract(1, 5);
            decimalCalc.Subtract(1.5M, 2.8M);
            doubleCalc.Subtract(1.5D, 2.8D);
        }
        [Benchmark]
        public void Multiply()
        {
            intCalc.Multiply(1, 5);
            decimalCalc.Multiply(1.5M, 2.8M);
            doubleCalc.Multiply(2.5D, 2.8D);
        }
    }
}
