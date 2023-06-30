using BenchmarkDotNet.Attributes;
using System;
using System.Collections;

namespace Task2
{
    
    public class BenchTestSortedList
    {
        SortedList sortList = new SortedList();
        
        [Benchmark]
        public void Add()
        {
            sortList.Add(5, "Five");
            sortList.Add(3, "Three");
            sortList.Add(1, "One");
            sortList.Add(2, "Two");
            sortList.Add(4, "Four");
        }
        [Benchmark]
        public void Remove()
        {
            sortList.Remove(5);
        }
    }
}


