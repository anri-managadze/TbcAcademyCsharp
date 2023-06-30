using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser]
    public class BenchTestHashTable
    {
        Hashtable hashTable = new Hashtable();

        [Benchmark]
        public void Add()
        {
            hashTable.Add(5, "Five");
            hashTable.Add(3, "Three");
            hashTable.Add(1, "One");
            hashTable.Add(2, "Two");
            hashTable.Add(4, "Four");
        }
        [Benchmark]
        public void Remove()
        {
            hashTable.Remove(5);
        }
    }
}



