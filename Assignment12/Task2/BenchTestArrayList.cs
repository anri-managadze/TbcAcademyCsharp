using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchTestArrayList
    {
        ArrayList array = new ArrayList();
        [Benchmark]
        public void Add () 
        {
            array.Add(5);
            array.Add("Anri");
        }
        [Benchmark]
        public void Remove() 
        {
            array.Remove(5);   
        }
        [Benchmark]
        public void Insert() 
        {
            array.Insert(0, "Managadze");
            array.InsertRange(2, new ArrayList() { "Developer", "TBC" });
        }  
    }
}
