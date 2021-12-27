using BenchmarkDotNet.Attributes;
using System;
using System.Collections;

namespace Many.Validators.Benchmark.Benchmarks.NotNullOrEmptyIEnumerable
{
	[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(3)]
    [WarmupCount(1)]
    public class NotNullOrEmptyIEnumerableValidatorBenchmarkBase<TValue>
        where TValue : IEnumerable
    {
        public readonly TValue _argumentsToFail;
        public readonly TValue _argumentsToSuccess;
        public readonly Func<TValue, TValue> _withNoValidatorImplementationFunc; //Function to use a custom implementation with no validators

        public NotNullOrEmptyIEnumerableValidatorBenchmarkBase(TValue argumentsToFail,
                                                                 TValue argumentsToSuccess)
        {
            _argumentsToSuccess = argumentsToSuccess;
            _argumentsToFail = argumentsToFail;
        }
        public NotNullOrEmptyIEnumerableValidatorBenchmarkBase(TValue argumentsToFail,
                                                                 TValue argumentsToSuccess,
                                                                 Func<TValue, TValue> withNoValidatorImplementationFunc)
            :this(argumentsToFail, argumentsToSuccess)
        {
            if (withNoValidatorImplementationFunc != null)
                _withNoValidatorImplementationFunc = withNoValidatorImplementationFunc;
            else
                _withNoValidatorImplementationFunc = new Func<TValue, TValue>((a) => WithNoValidatorImplementation(a));
        }
        //TODO: test de carga también

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
                ValidatorImplementation(new NotNullOrEmptyArray<TValue>(_argumentsToFail));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        public void Success_WithoutValidator() => WithNoValidatorImplementation(_argumentsToSuccess);
        [Benchmark]
        public void Success_WithValidator_Conversion() => ValidatorImplementation(_argumentsToSuccess);
        [Benchmark]
        public void Success_WithValidator_NoConversion() => ValidatorImplementation(new NotNullOrEmptyArray<TValue>(_argumentsToSuccess));

        private static TValue WithNoValidatorImplementation(TValue value)
        {
            if (value == null ||
                !value.GetEnumerator().MoveNext())
                throw new ArgumentNullException(nameof(value));

            return value;
        }
       
        private static TValue ValidatorImplementation(NotNullOrEmptyArray<TValue> value)
        {
            return value;
        }
    }
}
