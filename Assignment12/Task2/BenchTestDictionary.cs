using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    
    public class BenchTestDictionary
    {
        IDictionary dictionary = new Dictionary<int, int>();
        [Benchmark]
        public void Add()
        {
            dictionary.Add(1, "5");
            dictionary.Add(2, "Anri");
        }
        [Benchmark]
        public void Remove() 
        {
            dictionary.Remove(1);
        }
        [Benchmark]
        public void Contains() 
        {
            dictionary.Contains(1);
        }
    }
}
