using Many.Validators.Range;
using System;

namespace Many.Validators.Tests.Fixtures
{
	internal class Range_Int_1_100 : RangeBase<int?>
	{
		public override int? Min => 1;

		public override int? Max => 100;
	}
}
