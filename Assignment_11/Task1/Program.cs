using BenchmarkDotNet.Running;
using Task1;

GenGeneric<int> intCalc = new GenGeneric<int>();
//int result = intCalc.Add(1, 5);
//int result = intCalc.Add(1, 5);
int result = intCalc.Multiply(1, 5);
Console.WriteLine(result);

GenGeneric<decimal> decimalCalc = new GenGeneric<decimal>();
//decimal result1 = decimalCalc.Add(1.5M, 2.8M);
//decimal result1 = decimalCalc.Subtract(1.5M, 2.8M);
decimal result1 = decimalCalc.Multiply(1.5M, 2.8M);
Console.WriteLine(result1);

GenGeneric<double> doubleCalc = new GenGeneric<double>();
//double result2 = doubleCalc.Add(1.5D, 2.8D);
//double result2 = doubleCalc.Subtract(1.5D, 2.8D);
double result2 = doubleCalc.Multiply(1.5D, 2.8D);
Console.WriteLine(result2);

// Benchmark ის გამშვები
//BenchmarkRunner.Run<Test>();