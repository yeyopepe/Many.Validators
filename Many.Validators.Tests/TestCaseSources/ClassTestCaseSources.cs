namespace Many.Validators.Tests.TestCaseSources
{
	internal class ClassTestCaseSources
    {
        public static readonly string[] NotEmpty =
        {
            "asdf"
        };
        public static readonly object[] NotEmptyList =
        {
            new string[]{ "asdf","asdf"}
        };
        public static readonly string[] Empty =
        {
            "",
            " ",
            "      "
        };
        public static readonly object[] EmptyList =
        {
           new string[0],
           new string[] { },
        };

    }
}
