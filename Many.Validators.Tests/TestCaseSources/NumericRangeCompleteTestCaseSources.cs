using System;

namespace Many.Validators.Tests.TestCaseSources
{
    internal class NumericRangeCompleteTestCaseSources
    {
        public static readonly Int16[] Int16 =
        {
            short.MinValue,
            short.MaxValue,
        };
        public static readonly Int32[] Int32 =
        {
            int.MinValue,
            int.MaxValue
        };
        public static readonly Int64[] Int64 =
        {
            long.MinValue,
            long.MaxValue
        };
        public static readonly SByte[] SByte =
        {
            sbyte.MinValue,
            sbyte.MaxValue
        };
        public static readonly UInt16[] UInt16 =
        {
            ushort.MinValue,
            ushort.MaxValue
        };
        public static readonly UInt32[] UInt32 =
        {
            uint.MinValue,
            uint.MaxValue
        };
        public static readonly UInt64[] UInt64 =
        {
            ulong.MinValue,
            ulong.MaxValue
        };
        public static readonly Byte[] Byte =
        {
            byte.MinValue,
            byte.MaxValue
        };
#if NET5_0_OR_GREATER
        public static readonly Half[] Half =
        {
           (Half)(0.0000001),
           (Half)(65550)
        };
#endif
        public static readonly Single[] Single =
        {
            float.MinValue,
            float.MaxValue
        };
        public static readonly Double[] Double =
        {
            double.MinValue,
            double.MaxValue
        };
        public static readonly Decimal[] Decimal =
        {
            decimal.MinValue,
            decimal.MaxValue
        };
    }
}
