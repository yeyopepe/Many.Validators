using BenchmarkDotNet.Attributes;
using System;

namespace Many.Validators.Benchmark.Benchmarks.Negative
{
	[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class NegativeValidatorIntBenchmark : NegativeValidatorBenchmarkBase<int>
    {
        public NegativeValidatorIntBenchmark() : base(122341,-2314)
        {
        }
    }
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class NegativeValidatorNullableIntBenchmark : NegativeValidatorBenchmarkBase<int?>
    {
        public NegativeValidatorNullableIntBenchmark() : base(122341, -2314)
        {
        }
    }

    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class NegativeValidatorDecimalBenchmark : NegativeValidatorBenchmarkBase<Decimal>
    {
        public NegativeValidatorDecimalBenchmark() : base(231.0m, -2314.23m)
        {
        }
    }
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
    public class NegativeValidatorNullableDecimalBenchmark : NegativeValidatorBenchmarkBase<Decimal?>
    {
        public NegativeValidatorNullableDecimalBenchmark() : base(231.0m, -2314.23m)
        {
        }
    }

}
