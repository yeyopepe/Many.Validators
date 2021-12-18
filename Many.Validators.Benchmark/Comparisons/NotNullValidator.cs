using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Comparisons
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60, warmupCount: 1)]
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(2)]
    public class NotNullValidator
    {
        [Benchmark(Baseline = true)]
        [Arguments(null)]
        public void Fail_String_WithoutValidator(string value)
        {
            try
            {
                WithoutValidatorMethod(value);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        [Arguments(null)]
        public void Fail_String_Conversion_WithValidator(string value)
        {
            try
            {
                WithValidatorMethod<string>(value);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        [Arguments(null)]
        public void Fail_String_NoConversion_WithValidator(string value)
        {
            try
            {
                WithValidatorMethod(new NotNull<string>(value));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        [Arguments("something")]
        public void Success_String_WithoutValidator(string value) => WithoutValidatorMethod(value);
        [Benchmark]
        [Arguments("something")]
        public void Success_String_Conversion_WithValidator(string value) => WithValidatorMethod<string>(value);
        [Benchmark]
        [Arguments("something")]
        public void Success_String_NoConversion_WithValidator(string value) => WithValidatorMethod(new NotNull<string>(value));

        private static void WithoutValidatorMethod<V>(V notNullValue)
        {
            if (notNullValue == null)
                throw new ArgumentNullException(nameof(notNullValue));

            return;
        }
        private static void WithValidatorMethod<V>(NotNull<V> notNullValue)
        {
            return;
        }
    }
}
