
using System;
using System.Linq;

namespace Many.Validators.Benchmark.Benchmarks.NotNullOrEmptyIEnumerable
{
	public class NotNullOrEmptyArrayValidator_Null_IEnumerableBenchmark : NotNullOrEmptyIEnumerableValidatorBenchmarkBase<System.Collections.Generic.List<string>>
    {
        public NotNullOrEmptyArrayValidator_Null_IEnumerableBenchmark() 
            : base(argumentsToFail: null,
                   argumentsToSuccess: Utils.GetList(2))
        {
        }
    }
    public class NotNullOrEmptyArrayValidator_Empty_IEnumerableBenchmark : NotNullOrEmptyIEnumerableValidatorBenchmarkBase<System.Collections.Generic.List<string>>
    {
        public NotNullOrEmptyArrayValidator_Empty_IEnumerableBenchmark()
            : base(argumentsToFail: new System.Collections.Generic.List<string>(),
                   argumentsToSuccess: Utils.GetList(2))
        {
        }
    }

    public class NotNullOrEmptyArrayValidator_AnyMethodBenchmark : NotNullOrEmptyIEnumerableValidatorBenchmarkBase<string[]>
    {
        public NotNullOrEmptyArrayValidator_AnyMethodBenchmark()
            : base(argumentsToFail: null,
                   argumentsToSuccess: Utils.GetArray(2),
                   withNoValidatorImplementationFunc: new Func<string[], string[]>((a) => WithNoValidatorImplementation(a)))
        {
        }

        public static string[] WithNoValidatorImplementation(string[] value)
        {
            if (value == null ||
                !value.Any())
                throw new ArgumentNullException(nameof(value));

            return value;
        }
    }

    public class NotNullOrEmptyArrayValidator_CountMethodBenchmark : NotNullOrEmptyIEnumerableValidatorBenchmarkBase<string[]>
    {
        public NotNullOrEmptyArrayValidator_CountMethodBenchmark()
            : base(argumentsToFail: null,
                   argumentsToSuccess: Utils.GetArray(2),
                   withNoValidatorImplementationFunc: new Func<string[], string[]>((a) => WithNoValidatorImplementation(a)))
        {
        }

        private static string[] WithNoValidatorImplementation(string[] value)
        {
            if (value == null ||
                value.Count() < 1)
                throw new ArgumentNullException(nameof(value));

            return value;
        }
    }

    public class NotNullOrEmptyArrayValidator_LengthPropertyBenchmark : NotNullOrEmptyIEnumerableValidatorBenchmarkBase<string[]>
    {
        public NotNullOrEmptyArrayValidator_LengthPropertyBenchmark()
            : base(argumentsToFail: null,
                   argumentsToSuccess: Utils.GetArray(2),
                   withNoValidatorImplementationFunc: new Func<string[], string[]>((a) => WithNoValidatorImplementation(a)))
        {
        }

        private static string[] WithNoValidatorImplementation(string[] value)
        {
            if (value == null ||
                value.Length < 1)
                throw new ArgumentNullException(nameof(value));

            return value;
        }
    }

    public class Utils
	{
        public static System.Collections.Generic.List<string> GetList(int count)
        {
            return Enumerable.Range(1, count)
                .Select(x => x.ToString())
                .ToList();
        }
        public static string[] GetArray(int count)
        {
            return Enumerable.Range(1, count)
                .Select(x => x.ToString())
                .ToArray();
        }
    }
   
}
