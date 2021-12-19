using BenchmarkDotNet.Running;
using System;

namespace Many.Validators.Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($">>>>>>>>>>>>>>> {DateTime.Now}");

            //var summary = BenchmarkRunner.Run<Implementations.GreaterThanZeroImplementation>();

            //var summary1 = BenchmarkRunner.Run<Benchmarks.NotNullValidatorStringBenchmark>();
            var summary2 = BenchmarkRunner.Run<Benchmarks.NotNullValidatorNullableIntBenchmark>();

            Console.WriteLine($">>>>>>>>>>>>>>> {DateTime.Now}");
        }
    }
}

    
