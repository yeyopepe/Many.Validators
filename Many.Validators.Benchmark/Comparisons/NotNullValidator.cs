using BenchmarkDotNet.Attributes;
using System;
using System.Linq;

namespace Many.Validators.Benchmark.Comparisons
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60, warmupCount: 1)]
    [IterationCount(2)]
    public class NotNullValidator
    {
        //[Benchmark]
        //[Arguments(1)]
        //[Arguments(Int16.MaxValue)]
        //public void Validate1_Int16(Int16 value) => Validate1(value);
        

        public static void WithoutValidator()
        {

        }

        public static void WithValidator()
        {

        }


        private static void WithoutValidatorMethod<T>(T notNullValue)
        {
            if (notNullValue == null)
                throw new ArgumentNullException(nameof(notNullValue));
            
            return;
        }
        private static void WithValidatorMethod<T>(NotNull<T> notNullValue)
        {
            if (notNullValue == null)
                throw new ArgumentNullException(nameof(notNullValue));

            return;
        }
    }
}
