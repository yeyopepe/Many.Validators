using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks.InRange
{
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(3)]
    [WarmupCount(1)]
    public class InRangeValidatorBenchmark
    {
        [Benchmark]
        [Arguments(1000)]
        [Arguments(-1000)]
        public virtual void Fail_WithoutValidator(long value)
        {
            try
            {
                WithNoValidatorImplementation(value);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        [Arguments(1000)]
        [Arguments(-1000)]
        public void Fail_WithValidator_Conversion(long value)
        {
            try
            {
                ValidatorImplementation(value);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        [Arguments(1000)]
        [Arguments(-1000)]
        public void Fail_WithValidator_NoConversion(long value)
        {
            try
            {
                ValidatorImplementation(new InRange<Range_1_100,long>(value));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        [Arguments(10)]
        public void Success_WithoutValidator(long value) => WithNoValidatorImplementation(value);
        [Benchmark]
        [Arguments(10)]
        public void Success_WithValidator_Conversion(long value) => ValidatorImplementation(value);
        [Benchmark]
        [Arguments(10)]
        public void Success_WithValidator_NoConversion(long value) => ValidatorImplementation(new InRange<Range_1_100, long>(value));

        private static long WithNoValidatorImplementation(long value)
        {
            if (value < 1 ||
                value > 100)
                throw new ArgumentOutOfRangeException(nameof(value));

            return value;
        }
        private static long ValidatorImplementation(InRange<Range_1_100, long> value)
        {
            return value;
        }
    }
}
