﻿using Many.Validators.Range;
using System;

namespace Many.Validators.Tests.Fixtures
{
	internal class Range_Double_neg100_1 : RangeBase<Double>
	{
		public override double Min => -100.0;

		public override double Max => 1.0;
	}
}
