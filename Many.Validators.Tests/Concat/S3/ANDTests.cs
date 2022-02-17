using Many.Validators.Concat.S3;
using Many.Validators.Tests.Fixtures;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests.Concat.S3
{
	[TestFixture]
	internal class ANDTests
	{
		[Test]
		public void Concatenation_ValidValues_ReturnsTrue()
		{
			int? param1 = 59;
			Assert.AreEqual(true, Do(param1));
		}
		[Test]
		public void Concatenation_InvalidValues_ReturnsFalse()
		{
			int? param1 = 300;
			Assert.Throws<ArgumentOutOfRangeException>(() => Do(param1));
		}

		private bool Do(AND<int?, Positive<int?>, NotNull<int?>, InRange<Range_Int_1_100, int?>> param1) => true;
	}
}
