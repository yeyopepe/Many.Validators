using System;

namespace Many.Validators.Tests.TestCaseSources
{
    internal class NullableNumericZeroTestCaseSources
    {
        public static readonly Int16?[] Int16 =
        {
            0
        };
        public static readonly Int32?[] Int32 =
        {
            0
        };
        public static readonly Int64?[] Int64 =
        {
            0
        };
        public static readonly SByte?[] SByte =
        {
            0
        };
        public static readonly UInt16?[] UInt16 =
        {
            0
        };
        public static readonly UInt32?[] UInt32 =
        {
            0
        };
        public static readonly UInt64?[] UInt64 =
        {
            0
        };
        public static readonly Byte?[] Byte =
        {
           0
        };
#if NET5_0_OR_GREATER
        public static readonly Half?[] Half =
        {
           (Half)(0)
        };
#endif
        public static readonly Single?[] Single =
        {
            0f
        };
        public static readonly Double?[] Double =
        {
            0f
        };
        public static readonly Decimal?[] Decimal =
        {
            0M
        };
    }
}
