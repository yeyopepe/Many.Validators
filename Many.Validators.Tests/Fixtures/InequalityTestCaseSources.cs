﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many.Validators.Tests.Fixtures
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
    }
}
