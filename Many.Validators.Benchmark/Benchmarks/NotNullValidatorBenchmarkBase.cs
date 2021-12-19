using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks
{
    public abstract class NotNullValidatorBenchmarkBase<TValue>
    {
        public readonly TValue _argumentsWhenNull;
        public readonly TValue _argumentsWhenNotNull;
        public NotNullValidatorBenchmarkBase(TValue argumentsWhenNotNull)
        {
            _argumentsWhenNotNull = argumentsWhenNotNull;
        }


        [Benchmark]
        public virtual void Fail_WithoutValidator()
        {
            try
            {
                WithNoValidatorImplementation(_argumentsWhenNull);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        public void Fail_WithValidator_Conversion()
        {
            try
            {
                ValidatorImplementation(_argumentsWhenNull);
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }
        [Benchmark]
        public void Fail_WithValidator_NoConversion()
        {
            try
            {
                ValidatorImplementation(new NotNull<TValue>(_argumentsWhenNull));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        public void Success_WithoutValidator() => WithNoValidatorImplementation(_argumentsWhenNotNull);
        [Benchmark]
        public void Success_WithValidator_Conversion() => ValidatorImplementation(_argumentsWhenNotNull);
        [Benchmark]
        public void Success_WithValidator_NoConversion() => ValidatorImplementation(new NotNull<TValue>(_argumentsWhenNotNull));

        private static TValue WithNoValidatorImplementation(TValue value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return value;
        }
        private static TValue ValidatorImplementation(NotNull<TValue> value)
        {
            return value;
        }
    }
}

