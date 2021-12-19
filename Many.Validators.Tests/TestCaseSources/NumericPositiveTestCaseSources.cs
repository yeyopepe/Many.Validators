using System;

namespace Many.Validators.Tests.TestCaseSources
{
    internal class NumericPositiveTestCaseSources
    {
        public static readonly Int16[] Int16 =
        {
            1,
            short.MaxValue,
        };
        public static readonly Int32[] Int32 =
        {
            1,
            int.MaxValue
        };
        public static readonly Int64[] Int64 =
        {
            1,
            long.MaxValue
        };
        public static readonly SByte[] SByte =
        {
            1,
            sbyte.MaxValue
        };
        public static readonly UInt16[] UInt16 =
        {
            1,
            ushort.MaxValue
        };
        public static readonly UInt32[] UInt32 =
        {
            1,
            uint.MaxValue
        };
        public static readonly UInt64[] UInt64 =
        {
            1,
            ulong.MaxValue
        };
        public static readonly Byte[] Byte =
        {
            1,
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
            0.000000000000000000000000000000000000000000001f, 
            float.MaxValue
        };
        public static readonly Double[] Double =
        {
            0.000000000000000000000000000000000000000000001f,
#if NET47_OR_GREATER
            1.797693134862315E+308 //Accuracy bug in this version
#else
            double.MaxValue
#endif

        };
        public static readonly Decimal[] Decimal =
        {
            0.0000000000000000000000000001M, 
            decimal.MaxValue
        };
    }
}
