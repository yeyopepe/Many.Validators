using System;

namespace Many.Validators.Tests.TestCaseSources
{
    internal class NumericNegativeTestCaseSources
    {
        public static readonly Int16[] Int16 =
        {
            short.MinValue,
            -1
        };
        public static readonly Int32[] Int32 =
        {
            int.MinValue,
            -1
        };
        public static readonly Int64[] Int64 =
        {
            long.MinValue,
            -1
        };
        public static readonly SByte[] SByte =
        {
            sbyte.MinValue,
            -1
        };
#if NET5_0_OR_GREATER
        public static readonly Half[] Half =
        {
           (Half)(-65550),
           (Half)(-0.0000001)
        };
#endif
        public static readonly Single[] Single =
        {
            float.MinValue,
            -0.000000000000000000000000000000000000000000001f
        };
        public static readonly Double[] Double =
        {
#if NET47_OR_GREATER
            -1.797693134862315E+308 //Accuracy bug in this version
#else
            double.MinValue,
#endif
            -0.000000000000000000000000000000000000000000001f
        };
        public static readonly Decimal[] Decimal =
        {
            decimal.MinValue,
            -0.0000000000000000000000000001M
        };
    }
}
