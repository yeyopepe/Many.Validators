using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks.Positive
{
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(3)]
    [WarmupCount(1)]
    public abstract class PositiveOrZeroValidatorBenchmarkBase<TValue>
    {
        public readonly TValue _argumentsToFail;
        public readonly TValue _argumentsToSuccess;
        public PositiveOrZeroValidatorBenchmarkBase(TValue argumentsToFail,
                                                TValue argumentsToSuccess)
        {
            _argumentsToSuccess = argumentsToSuccess;
            _argumentsToFail = argumentsToFail;
        }


        [Benchmark]
        public virtual void Fail_WithoutValidator()
        {
            try
            {
                WithNoValidatorImplementation(_argumentsToFail);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        public void Fail_WithValidator_Conversion()
        {
            try
            {
                ValidatorImplementation(_argumentsToFail);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        public void Fail_WithValidator_NoConversion()
        {
            try
            {
                ValidatorImplementation(new Positive<TValue>(_argumentsToFail));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        public void Success_WithoutValidator() => WithNoValidatorImplementation(_argumentsToSuccess);
        [Benchmark]
        public void Success_WithValidator_Conversion() => ValidatorImplementation(_argumentsToSuccess);
        [Benchmark]
        public void Success_WithValidator_NoConversion() => ValidatorImplementation(new Positive<TValue>(_argumentsToSuccess));

        private static TValue WithNoValidatorImplementation(dynamic value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            return value;
        }
        private static TValue ValidatorImplementation(Positive<TValue> value)
        {
            return value;
        }
    }
}

