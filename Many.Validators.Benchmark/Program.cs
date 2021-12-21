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

            //var summary1 = BenchmarkRunner.Run<Benchmarks.NotNull.NotNullValidatorNullableClassBenchmark>();
            //var summary2 = BenchmarkRunner.Run<Benchmarks.NotNull.NotNullValidatorNullableStructBenchmark>();
            //var summary3 = BenchmarkRunner.Run<Benchmarks.NotNullOrEmptyValidatorBenchmark>();

            //var summary4 = BenchmarkRunner.Run<Benchmarks.Positive.PositiveValidatorIntBenchmark>();
            //var summary5 = BenchmarkRunner.Run<Benchmarks.Positive.PositiveValidatorNullableIntBenchmark>();
            var summary6 = BenchmarkRunner.Run<Benchmarks.Positive.PositiveOrZeroValidatorIntBenchmark>();
            var summary7 = BenchmarkRunner.Run<Benchmarks.Positive.PositiveOrZerValidatorNullableIntBenchmark>();

            var summary8 = BenchmarkRunner.Run<Benchmarks.Negative.NegativeValidatorIntBenchmark>();
            var summary9 = BenchmarkRunner.Run<Benchmarks.Negative.NegativeValidatorNullableIntBenchmark>();
            var summary10 = BenchmarkRunner.Run<Benchmarks.Negative.NegativeOrZeroValidatorIntBenchmark>();
            var summary11 = BenchmarkRunner.Run<Benchmarks.Negative.NegativeOrZerValidatorNullableIntBenchmark>();

            Console.WriteLine($">>>>>>>>>>>>>>> {DateTime.Now}");
        }
    }
}

    
