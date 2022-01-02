using Many.Validators.Range;
using System;

namespace Many.Validators.Tests.Fixtures
{
	internal class Range_Int64_neg100_1 : RangeBase<Int64>
	{
		public override long Max => 1;

		public override long Min => -100;
	}
}
