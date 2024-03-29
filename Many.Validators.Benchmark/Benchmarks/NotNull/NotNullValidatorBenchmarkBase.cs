﻿using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks.NotNull
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(3)]
    [WarmupCount(1)]
    public abstract class NotNullValidatorBenchmarkBase<TValue>
    {
        public readonly TValue _argumentsToFail;
        public readonly TValue _argumentsToSuccess;
        public NotNullValidatorBenchmarkBase(TValue argumentsToSuccess)
        {
            _argumentsToSuccess = argumentsToSuccess;
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
                ValidatorImplementation(new NotNull<TValue>(_argumentsToFail));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        public void Success_WithoutValidator() => WithNoValidatorImplementation(_argumentsToSuccess);
        [Benchmark]
        public void Success_WithValidator_Conversion() => ValidatorImplementation(_argumentsToSuccess);
        [Benchmark]
        public void Success_WithValidator_NoConversion() => ValidatorImplementation(new NotNull<TValue>(_argumentsToSuccess));

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

