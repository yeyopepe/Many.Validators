using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks
{
    

    public abstract class ValidatorBenchmarkBase<V>
    {
        public readonly V _argumentsWhenNull;
        public readonly V _argumentsWhenNotNull;
        public ValidatorBenchmarkBase(V argumentsWhenNotNull)
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
                ValidatorImplementation(new NotNull<V>(_argumentsWhenNull));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        public void Success_WithoutValidator() => WithNoValidatorImplementation(_argumentsWhenNotNull);
        [Benchmark]
        public void Success_WithValidator_Conversion() => ValidatorImplementation(_argumentsWhenNotNull);
        [Benchmark]
        public void Success_WithValidator_NoConversion() => ValidatorImplementation(new NotNull<V>(_argumentsWhenNotNull));

        private static void WithNoValidatorImplementation(V notNullValue)
        {
            if (notNullValue == null)
                throw new ArgumentNullException(nameof(notNullValue));

            return;
        }
        private static void ValidatorImplementation(NotNull<V> notNullValue)
        {
            return;
        }
    }
}

