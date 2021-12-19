using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks
{
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472, warmupCount: 1)]
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60, warmupCount: 1)]
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(3)]
    public class NotNullValidatorNullableClassBenchmark : ValidatorBenchmarkBase<string>
    {
        public NotNullValidatorNullableClassBenchmark() : base("something")
        {
        }
    }
}
