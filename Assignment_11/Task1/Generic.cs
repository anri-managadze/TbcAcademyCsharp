using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface IGeneric<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
    }
    public class GenGeneric<T> : IGeneric<T> where T : struct
    {
        public T Add(T a, T b)
        {
            dynamic n = a;
            dynamic m = b;
            dynamic result = n + m;
            return result;
        }

        public T Subtract(T a, T b)
        {
            dynamic n = a;
            dynamic m = b;
            dynamic result = n - m;
            return result;
        }

        public T Multiply(T a, T b)
        {
            dynamic n = a;
            dynamic m = b;
            dynamic result = n * m;
            return result;
        }
    }


}
