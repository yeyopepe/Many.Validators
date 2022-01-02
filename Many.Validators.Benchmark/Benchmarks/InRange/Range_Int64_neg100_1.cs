using Many.Validators.Range;
using System;

namespace Many.Validators.Benchmark.Benchmarks.InRange
{
	internal class Range_1_100 : RangeBase<Int64>
	{
		public override long Max => 100;

		public override long Min => 1;
	}
}
