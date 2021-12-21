using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(3)]
    [WarmupCount(1)]
    public class NotNullOrEmptyValidatorBenchmark 
    {
        [Benchmark]
        [Arguments(null)]
        [Arguments("")]
        [Arguments(" ")]
        public virtual void Fail_WithoutValidator(string value)
        {
            try
            {
                WithNoValidatorImplementation(value);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        [Arguments(null)]
        [Arguments("")]
        [Arguments(" ")]
        public void Fail_WithValidator_Conversion(string value)
        {
            try
            {
                ValidatorImplementation(value);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        [Arguments(null)]
        [Arguments("")]
        [Arguments(" ")]
        public void Fail_WithValidator_NoConversion(string value)
        {
            try
            {
                ValidatorImplementation(new NotNullOrEmpty(value));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        [Arguments("asdfadf")]
        public void Success_WithoutValidator(string value) => WithNoValidatorImplementation(value);
        [Benchmark]
        [Arguments("asdfadf")]
        public void Success_WithValidator_Conversion(string value) => ValidatorImplementation(value);
        [Benchmark]
        [Arguments("asdfadf")]
        public void Success_WithValidator_NoConversion(string value) => ValidatorImplementation(new NotNullOrEmpty(value));

        private static string WithNoValidatorImplementation(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));

            return value;
        }
        private static string ValidatorImplementation(NotNullOrEmpty value)
        {
            return value;
        }
    }
}
