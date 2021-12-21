using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks.Positive
{
	[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class PositiveValidatorIntBenchmark : PositiveValidatorBenchmarkBase<int>
    {
        public PositiveValidatorIntBenchmark() : base(-1,2314)
        {
        }
    }
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class PositiveValidatorNullableIntBenchmark : PositiveValidatorBenchmarkBase<int?>
    {
        public PositiveValidatorNullableIntBenchmark() : base(-1, 2314)
        {
        }
    }

    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class PositiveValidatorDecimalBenchmark : PositiveValidatorBenchmarkBase<Decimal>
    {
        public PositiveValidatorDecimalBenchmark() : base(-1.0m, 2314.23m)
        {
        }
    }
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class PositiveValidatorNullableDecimalBenchmark : PositiveValidatorBenchmarkBase<Decimal?>
    {
        public PositiveValidatorNullableDecimalBenchmark() : base(-1.0m, 2314.23m)
        {
        }
    }

}
