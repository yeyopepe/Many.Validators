using BenchmarkDotNet.Attributes;

namespace Many.Validators.Benchmark.Benchmarks.Negative
{
	[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class NegativeOrZeroValidatorIntBenchmark : NegativeOrZeroValidatorBenchmarkBase<int>
    {
        public NegativeOrZeroValidatorIntBenchmark() : base(541, -1)
        {
        }
    }
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class NegativeOrZerValidatorNullableIntBenchmark : NegativeOrZeroValidatorBenchmarkBase<int?>
    {
        public NegativeOrZerValidatorNullableIntBenchmark() : base(541, -1)
        {
        }
    }

}

