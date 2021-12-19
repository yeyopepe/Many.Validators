using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks
{
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472, warmupCount: 1)]
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60, warmupCount: 1)]
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(2)]
    public class NotNullValidatorNullableIntBenchmark : ValidatorBenchmarkBase<int?>
    {
        public NotNullValidatorNullableIntBenchmark() : base(124)
        {
        }
    }
}
