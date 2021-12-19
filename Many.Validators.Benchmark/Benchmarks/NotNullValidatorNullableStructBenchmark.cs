using BenchmarkDotNet.Attributes;

namespace Many.Validators.Benchmark.Benchmarks
{
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472, warmupCount: 1)]
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60, warmupCount: 1)]
    [MemoryDiagnoser]
    [MedianColumn]
    [IterationCount(3)]
    public class NotNullValidatorNullableStructBenchmark : NotNullValidatorBenchmarkBase<int?>
    {
        public NotNullValidatorNullableStructBenchmark() : base(124)
        {
        }
    }
}
