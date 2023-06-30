using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Person
    {
         
        SortedList sortList = new SortedList();
        int length = 100;

        [Benchmark]
        public void Add()
        {
            for (int i = 0; i < length; i++)
            {
                sortList.Add(5, "Five");
                sortList.Add(3, "Three");
                sortList.Add(1, "One");
                sortList.Add(2, "Two");
                sortList.Add(4, "Four");
            }
        }
        [Benchmark]
        public void Remove()
        { 
            for (int i = 0; i < length; i++)
            {
                sortList.Remove(5);
                sortList.Remove(1);
                sortList.Remove(4);
            }
        }
    }
}
