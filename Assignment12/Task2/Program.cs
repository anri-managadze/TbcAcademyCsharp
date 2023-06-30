using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using System.Collections;
using Task2;

//BenchmarkRunner.Run<BenchTestArrayList>();
//BenchmarkRunner.Run<BenchTestList>();
//BenchmarkRunner.Run<BenchTestDictionary>();
BenchmarkRunner.Run<BenchTestSortedList>();
//BenchmarkRunner.Run<BenchTestHashTable>();
//BenchmarkRunner.Run<BenchTestQueue>();
