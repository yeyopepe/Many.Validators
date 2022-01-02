#if NET5_0_OR_GREATER
using Many.Validators.Range;

namespace Many.Validators.Tests.Fixtures
{
	internal class Range_Half_neg100_1 : RangeBase<System.Half>
	{
		public override System.Half Min => (System.Half)(-100.0);

		public override System.Half Max => (System.Half)1.0;
	}
}
#endif
