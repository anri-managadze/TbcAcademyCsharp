using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


const int ArraySize = 10000000;
//int[] numbers = Enumerable.Range(1, ArraySize).ToArray();

    var random = new Random();
    int[] numbers= Enumerable.Range(1, ArraySize).Select(i => random.Next(100)).ToArray();


long calculate(int[] number)
{
    long sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }
    return sum;
}
long CalculateSumParallel(int[] numbers)
{
    long sum = 0;
    Parallel.For(0, numbers.Length, i =>
    {
        sum += numbers[i];
    });
    return sum;
}
//  sequentially
Stopwatch sequentialTimer = Stopwatch.StartNew();
long sequentialSum = calculate(numbers);
sequentialTimer.Stop();
Console.WriteLine($"Sequential Sum: {sequentialSum}");
Console.WriteLine($"Sequential Time: {sequentialTimer.ElapsedMilliseconds} ms");

//  parallel
Stopwatch parallelTimer = Stopwatch.StartNew();
long parallelSum = CalculateSumParallel(numbers);
parallelTimer.Stop();
Console.WriteLine($"Parallel Sum: {parallelSum}");
Console.WriteLine($"Parallel Time: {parallelTimer.ElapsedMilliseconds} ms");

