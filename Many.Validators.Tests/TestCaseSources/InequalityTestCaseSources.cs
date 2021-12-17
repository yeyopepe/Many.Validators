namespace Many.Validators.Tests.TestCaseSources
{
    internal class InequalityTestCaseSources
    {
       public static readonly object[] Int =
       {
            new object[] { 10, 0 },
            new object[] { 0, -10 },
            new object[] { -123, -1230 },
            new object[] { 13, 123 },
        };
        public static readonly object[] String =
        {
            new object[] { "", " " },
            new object[] { " ", "  " },
            new object[] { "asdasdff", "asdf" },
            new object[] { "", null }
        };
        public static readonly object[] Bool =
        {
            new object[] { false, true },
            new object[] { true, false },
        };
        public static readonly object[] Double =
        {
            new object[] { 1.0, 1.01 },
            new object[] { 0.001, 0.0 },
            new object[] { 1.01, -1.01 },
        };
    }
}
