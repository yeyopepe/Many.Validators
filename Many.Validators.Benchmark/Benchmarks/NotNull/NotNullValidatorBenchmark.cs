namespace Many.Validators.Benchmark.Benchmarks.NotNull
{
	public class NotNullValidatorNullableClassBenchmark : NotNullValidatorBenchmarkBase<string>
    {
        public NotNullValidatorNullableClassBenchmark() : base("something")
        {
        }
    }

    public class NotNullValidatorNullableStructBenchmark : NotNullValidatorBenchmarkBase<int?>
    {
        public NotNullValidatorNullableStructBenchmark() : base(124)
        {
        }
    }
}
