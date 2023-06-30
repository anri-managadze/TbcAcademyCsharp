using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    [Config(typeof(AntiVirusFriendlyConfig))]
    public class BenchTestQueue
    {
        Queue<int> queues = new Queue<int>();
        
        [Benchmark]
        public void Add()
        {
            queues.Enqueue(5);
            queues.Enqueue(2);
            queues.Enqueue(8);
            queues.Enqueue(1);
            queues.Enqueue(3);
        }
        [Benchmark]
        public void Delete()
        {
            queues.Dequeue();
        }
    }
}
