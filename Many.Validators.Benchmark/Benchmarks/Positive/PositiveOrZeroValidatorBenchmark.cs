using BenchmarkDotNet.Attributes;

namespace Many.Validators.Benchmark.Benchmarks.Positive
{
	[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class PositiveOrZeroValidatorIntBenchmark : PositiveOrZeroValidatorBenchmarkBase<int>
    {
        public PositiveOrZeroValidatorIntBenchmark() : base(-1, 2314)
        {
        }
    }
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class PositiveOrZerValidatorNullableIntBenchmark : PositiveOrZeroValidatorBenchmarkBase<int?>
    {
        public PositiveOrZerValidatorNullableIntBenchmark() : base(-1, 2314)
        {
        }
    }

}

