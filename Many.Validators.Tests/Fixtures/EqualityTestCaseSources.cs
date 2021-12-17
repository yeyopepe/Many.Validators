using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many.Validators.Tests.Fixtures
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
    }
}
