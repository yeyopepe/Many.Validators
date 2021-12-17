namespace Many.Validators.Tests.TestCaseSources
{
    internal static class EqualityTestCaseSources
    {
       public static readonly object[] String =
       {
            new object[] { "", "" },
            new object[] { " ", " " },
            new object[] { "asdf", "asdf" },
            new object[] { "1212", "1212" },
        };
        public static readonly object[] Int =
        {
            new object[] { 0, 0 },
            new object[] { -1230, -1230 },
            new object[] { 123, 123 },
        };
        public static readonly object[] Bool =
        {
            new object[] { true, true },
            new object[] { false, false },
        };
        public static readonly object[] Double =
        {
            new object[] { 0, 0 },
            new object[] { 1.00, 1 },
            new object[] { 1.0, 1.0 },
            new object[] { 12.234, 12.234 },
            new object[] { -13.3, -13.3 },
        };
    }
}
