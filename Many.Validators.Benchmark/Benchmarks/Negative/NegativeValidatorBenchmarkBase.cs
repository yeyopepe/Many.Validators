﻿using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks.Negative
{
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(3)]
    [WarmupCount(1)]
    public abstract class NegativeValidatorBenchmarkBase<TValue>
    {
        public readonly TValue _argumentsToFail;
        public readonly TValue _argumentsToPass;
        public NegativeValidatorBenchmarkBase(TValue argumentsToFail,
                                                TValue argumentsWhenNotNull)
        {
            _argumentsToPass = argumentsWhenNotNull;
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
                ValidatorImplementation(new Negative<TValue>(_argumentsToFail));
            }
            catch { return; }

            throw new Exception("Test is not valid");
        }

        [Benchmark(Baseline = true)]
        public void Success_WithoutValidator() => WithNoValidatorImplementation(_argumentsToPass);
        [Benchmark]
        public void Success_WithValidator_Conversion() => ValidatorImplementation(_argumentsToPass);
        [Benchmark]
        public void Success_WithValidator_NoConversion() => ValidatorImplementation(new Negative<TValue>(_argumentsToPass));

        private static TValue WithNoValidatorImplementation(dynamic value)
        {
            if (value >= 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            return value;
        }
        private static TValue ValidatorImplementation(Negative<TValue> value)
        {
            return value;
        }
    }
}

