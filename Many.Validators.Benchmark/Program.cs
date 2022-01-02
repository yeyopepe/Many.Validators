using BenchmarkDotNet.Running;

namespace Many.Validators.Benchmark
{
	internal class Program
    {
        static void Main(string[] args)
        {
            OtherTest();

            //var summary = BenchmarkRunner.Run<Implementations.GreaterThanZeroImplementation>();

            //var summary1 = BenchmarkRunner.Run<Benchmarks.NotNull.NotNullValidatorNullableClassBenchmark>();
            //var summary2 = BenchmarkRunner.Run<Benchmarks.NotNull.NotNullValidatorNullableStructBenchmark>();
            //var summary3 = BenchmarkRunner.Run<Benchmarks.NotNullOrEmptyValidatorBenchmark>();
            //var summary4 = BenchmarkRunner.Run<Benchmarks.NotNullOrEmptyIEnumerable.NotNullOrEmptyArrayValidator_Null_IEnumerableBenchmark>();
            //var summary41 = BenchmarkRunner.Run<Benchmarks.NotNullOrEmptyIEnumerable.NotNullOrEmptyArrayValidator_Empty_IEnumerableBenchmark>();
            //var summary42 = BenchmarkRunner.Run<Benchmarks.NotNullOrEmptyIEnumerable.NotNullOrEmptyArrayValidator_AnyMethodBenchmark>();
            //var summary44 = BenchmarkRunner.Run<Benchmarks.NotNullOrEmptyIEnumerable.NotNullOrEmptyArrayValidator_CountMethodBenchmark>();
            //var summary45 = BenchmarkRunner.Run<Benchmarks.NotNullOrEmptyIEnumerable.NotNullOrEmptyArrayValidator_LengthPropertyBenchmark>();

            //var summary5 = BenchmarkRunner.Run<Benchmarks.Positive.PositiveValidatorIntBenchmark>();
            //var summary6 = BenchmarkRunner.Run<Benchmarks.Positive.PositiveValidatorNullableIntBenchmark>();
            //var summary7 = BenchmarkRunner.Run<Benchmarks.Positive.PositiveOrZeroValidatorIntBenchmark>();
            //var summary8 = BenchmarkRunner.Run<Benchmarks.Positive.PositiveOrZerValidatorNullableIntBenchmark>();

            //var summary9 = BenchmarkRunner.Run<Benchmarks.Negative.NegativeValidatorIntBenchmark>();
            //var summary10 = BenchmarkRunner.Run<Benchmarks.Negative.NegativeValidatorNullableIntBenchmark>();
            //var summary11 = BenchmarkRunner.Run<Benchmarks.Negative.NegativeOrZeroValidatorIntBenchmark>();
            //var summary12 = BenchmarkRunner.Run<Benchmarks.Negative.NegativeOrZerValidatorNullableIntBenchmark>();

            var summary13 = BenchmarkRunner.Run<Benchmarks.InRange.InRangeValidatorBenchmark>();
        }

        private static void OtherTest()
		{
            
            //string z = "true";
            //var temp = Get(z);
        }
       
        private static bool Get(NotNull<string> value)
		{
            return bool.Parse(value);
		}
    }
}

    
