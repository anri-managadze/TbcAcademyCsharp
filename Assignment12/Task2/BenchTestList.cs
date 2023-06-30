using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BenchTestList
    {
        List<string> list = new List<string>();
        [Benchmark]
        public void Add()
        {
            list.Add("5");
            list.Add("Anri");
        }
        [Benchmark]
        public void Remove()
        {
            list.Remove("5");
        }
        [Benchmark]
        public void Insert()
        {
            list.Insert(0, "Managadze");
            list.InsertRange(2, new List<string>() { "Developer", "TBC" });
        }
    }  
}
