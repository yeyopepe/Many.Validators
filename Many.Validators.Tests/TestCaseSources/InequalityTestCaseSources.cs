namespace Many.Validators.Tests.TestCaseSources
{
    internal class InequalityTestCaseSources
    {
       public static readonly object[] IntPositive =
       {
            new object[] { 10, 1 },
            new object[] { 1, 10 },
            new object[] { 123, 1230 },
            new object[] { 13, 123 },
        };
        public static readonly object[] IntNegative =
        {
            new object[] { -10, -1 },
            new object[] { -1, -10 },
            new object[] { -123, -1230 },
            new object[] { -13, -123 },
        };
        public static readonly object[] IntNegative_Range_neg100_1 =
        {
            new object[] { -10, -1 },
            new object[] { -1, -10 },
            new object[] { -13, -99 },
        };
        
        public static readonly object[] EmptyString =
        {
            new object[] { "", " " },
            new object[] { " ", "  " },
        };
        public static readonly object[] NotEmptyString =
        {
            new object[] { "asdasdff", "asdf" },
        };
        public static readonly object[] NotEmptyLists =
        {
            new object[] { new[]{"234", "asdf" }, new[] { "asdf", "asdf" } },
            new object[] { new[]{ "asdf", "234" }, new[] { "asdf", "asdf" } }
        };
        public static readonly object[] Bool =
        {
            new object[] { false, true },
            new object[] { true, false },
        };
        public static readonly object[] DoublePositive =
        {
            new object[] { 1.0, 1.01 },
            new object[] { 0.001, 0.1 },
            new object[] { 1.01, 1.011 },
        };
        public static readonly object[] DoubleNegative =
        {
            new object[] { -1.0, -1.01 },
            new object[] { -0.001, -0.1 },
            new object[] { -1.01, -1.011 },
        };
        public static readonly object[] DoubleNegative_Range_neg100_1 =
        {
            new object[] { -19.0, -95.01 },
            new object[] { -0.001, -0.1 },
            new object[] { -1.01, -1.011 },
        };
        
    }
}
