using Many.Validators.Clauses.S2;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests.Clauses.S2
{
	[TestFixture]
	internal partial class AllTests
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

		private bool Do(All<Positive<int?>, NotNull<int?>, int?> param1) => true;
	}
}
