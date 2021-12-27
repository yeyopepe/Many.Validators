using Many.Validators.Range;
using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators.Tests.Fixtures
{
	internal class Range_Int64_0_100 : Range<Int64>
	{
		public override long Max => 100;

		public override long Min => 0;
	}
}
