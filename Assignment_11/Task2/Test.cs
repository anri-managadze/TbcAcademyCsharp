using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Test
    {
        Storage<string> storage1 = new Storage<string>(3);
        
        [Benchmark]
        public void Add()
        {
            storage1.Add("hey");
            storage1.Add("yes");
            storage1.Add("no");
        }
        [Benchmark]
        public void Remove()
        {
            storage1.Remove(1);
        }
        [Benchmark]
        public void Update()
        {
            storage1.Update(0, "hi");
        }
    }
}
