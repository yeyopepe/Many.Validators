using Many.Validators.Concat.S2;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests.Concat.S2
{
	[TestFixture]
	internal partial class ANDTests
	{
		[Test]
		public void Concatenation_ValidValues_ReturnsTrue()
		{
			int? param1 = 324;
			Assert.AreEqual(true, Do(param1));
		}
		[Test]
		public void Concatenation_InvalidValues_ReturnsFalse()
		{
			int? param1 = -324;
			Assert.Throws<ArgumentOutOfRangeException>(() => Do(param1));
		}

		private bool Do(AND<int?, Positive<int?>, NotNull<int?>> param1) => true;
	}
}
