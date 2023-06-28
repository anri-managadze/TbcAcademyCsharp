using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Storage<T>
    {
        private T[] _x;

        private int count = 0;
        public Storage(int size)
        {
            _x = new T[size];
        }
        public void Add(T temp)
        {
            if (count < _x.Length)
            {
                _x[count] =temp;
                count++;
            }
            Console.WriteLine($" Added : {temp} ,");
        }

        public void Remove(int index)
        {
            if (index >= 0)
            {
                Array.Clear(_x, index, 1);
                count--;
                Console.WriteLine("Element was Deleted: " + index); 
            }       
        }
        public void Update(int index, T item)
        {
            if (index >= 0 && index < count)
                _x[index] = item;
                Console.WriteLine("Element Update:" + item);
        }
    }
}
