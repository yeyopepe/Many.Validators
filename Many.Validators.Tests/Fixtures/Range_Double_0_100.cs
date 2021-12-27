using Many.Validators.Range;
using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators.Tests.Fixtures
{
	internal class Range_Double_0_100 : Range<Double>
	{
		public override Double Min => 0.0;

		public override Double Max => 100.0;
	}
}
