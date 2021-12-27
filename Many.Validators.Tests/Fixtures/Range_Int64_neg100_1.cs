using Many.Validators.Range;
using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators.Tests.Fixtures
{
	internal class Range_Int64_neg100_1 : Range<Int64>
	{
		public override long Max => 1;

		public override long Min => -100;
	}
}
