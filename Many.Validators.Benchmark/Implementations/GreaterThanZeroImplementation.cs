using BenchmarkDotNet.Attributes;
using System;
using System.Linq;

namespace Many.Validators.Benchmark.Implementations
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net472, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31, warmupCount: 1)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60, warmupCount: 1)]
    [IterationCount(2)]
    public class GreaterThanZeroImplementation
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int16.MaxValue)]
        public void Validate1_Int16(Int16 value) => Validate1(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int32.MaxValue)]
        public void Validate1_Int32(Int32 value) => Validate1(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int64.MaxValue)]
        public void Validate1_Int64(Int64 value) => Validate1(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(SByte.MaxValue)]
        public void Validate1_SByte(SByte value) => Validate1(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(UInt16.MaxValue)]
        public void Validate1_UInt16(UInt16 value) => Validate1(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int32.MaxValue)]
        public void Validate1_UInt32(UInt32 value) => Validate1(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int64.MaxValue)]
        public void Validate1_UInt64(UInt64 value) => Validate1(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Byte.MaxValue)]
        public void Validate1_Byte(Byte value) => Validate1(value);
        [Benchmark]
        [Arguments(0.000000000000000000000000000000000000000000001f)]
        [Arguments(Single.MaxValue)]
        public void Validate1_Single(Single value) => Validate1(value);
        [Benchmark]
        [Arguments(0.000000000000000000000000000000000000000000001f)]
        [Arguments(Double.MaxValue)]
        public void Validate1_Double(Double value) => Validate1(value);
        [Benchmark]
        [Arguments(0.0000000000000000000000000001)]
        [Arguments(7000000000000000000)]
        public void Validate1_Decimal(Decimal value) => Validate1(value);
#if NET5_0_OR_GREATER
        [Benchmark]
        [Arguments(0.0000001)]
        [Arguments(65550)]
        public void Validate1_Half(Half value) => Validate1(value);
#endif

        [Benchmark]
        [Arguments(1)]
        [Arguments(Int16.MaxValue)]
        public void Validate2_Int16(Int16 value) => Validate2(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int32.MaxValue)]
        public void Validate2_Int32(Int32 value) => Validate2(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int64.MaxValue)]
        public void Validate2_Int64(Int64 value) => Validate2(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(SByte.MaxValue)]
        public void Validate2_SByte(SByte value) => Validate2(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(UInt16.MaxValue)]
        public void Validate2_UInt16(UInt16 value) => Validate2(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int32.MaxValue)]
        public void Validate2_UInt32(UInt32 value) => Validate2(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Int64.MaxValue)]
        public void Validate2_UInt64(UInt64 value) => Validate2(value);
        [Benchmark]
        [Arguments(1)]
        [Arguments(Byte.MaxValue)]
        public void Validate2_ByteMin(Byte value) => Validate2(value);
        [Benchmark]
        [Arguments(0.000000000000000000000000000000000000000000001f)]
        [Arguments(Single.MaxValue)]
        public void Validate2_Single(Single value) => Validate2(value);
        [Benchmark]
        [Arguments(0.000000000000000000000000000000000000000000001f)]
        [Arguments(Double.MaxValue)]
        public void Validate2_Double(Double value) => Validate2(value);
        [Benchmark]
        [Arguments(0.0000000000000000000000000001)]
        [Arguments(7000000000000000000)]
        public void Validate2_Decimal(Decimal value) => Validate2(value);
#if NET5_0_OR_GREATER
        [Benchmark]
        [Arguments(0.0000001)]
        [Arguments(65550)]
        public void Validate2_Half(Half value) => Validate2(value);
#endif


        public static void Validate1<TValue>(TValue value)
        {
            //First iteration to support all types adn write as less code as possible including Half
            //String representation without notation signs
            var cleanedStringValue = value.ToString()
                                        .Replace(",", "")
                                        .Replace(".", "")
                                        .Replace("E+", "")
                                        .Replace("E-", "");

            var positiveInfinity = new Func<string, bool>((s) => s.Equals("∞"));
            var negativeInfinity = new Func<string, bool>((s) => s.Equals("-∞"));

            if (negativeInfinity(cleanedStringValue) ||
                (!positiveInfinity(cleanedStringValue) && !cleanedStringValue.All(char.IsDigit)))
                throw new ArgumentOutOfRangeException($"Value {value} must be greater than zero.");

            if (!Decimal.TryParse(value.ToString(), out _) &&
                !Double.TryParse(value.ToString(), out _))
                throw new NotImplementedException();

            //Ok
        }
        public static void Validate2<TValue>(TValue value)
        {
            //Second iteration looking for better performance
            var result = false;
            var t = typeof(TValue);
            if (t.Equals(typeof(Int16)))
                result = Int16.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Int32)))
                result = Int32.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Int64)))
                result = Int64.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(SByte)))
                result = SByte.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt16)))
                result = UInt16.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt32)))
                result = UInt32.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt64)))
                result = UInt64.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Byte)))
                result = Byte.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Single)))
                result = Single.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Double)))
                result = Double.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Decimal)))
                result = Decimal.Parse(value.ToString()) > 0;
#if NET5_0_OR_GREATER
            else if (t.Equals(typeof(Half)))
                result = Half.Parse(value.ToString()) > (Half)0;
#endif
            else
                throw new ArgumentException($"Value {value} can not be evaluated because type is not recognized ({t})");

            if (!result)
                throw new ArgumentOutOfRangeException($"Value {value} must be greater than zero.");
        }

    }
}
