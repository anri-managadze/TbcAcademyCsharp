using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Task2;

Storage<int> storage = new Storage<int> (2);
//storage.Add(1);
//storage.Add(5);
//storage.Add(8);
//storage.Add(10);


Storage<string> storage1 = new Storage<string>(3);
storage1.Add("hey");
storage1.Add("yes");
storage1.Add("no");
storage1.Remove(1);
storage1.Update(0, "hi");

// Benchmark ის გამშვები
//BenchmarkRunner.Run<Test>();