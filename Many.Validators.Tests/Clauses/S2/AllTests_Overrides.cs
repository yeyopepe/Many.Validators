﻿using Many.Validators.Clauses.S2;
using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;

namespace Many.Validators.Tests.Clauses.S2
{
	[TestFixture]
	internal partial class AllTests
	{
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
		public void EqualityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
		{
			All<TValue, NotNull<TValue>, Negative<TValue>> a1 = value1;
			All<TValue, NotNull<TValue>, Negative<TValue>> a2 = value2;
			Assert.IsTrue(a1 == a2);
		}
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
		public void EqualityOperator_ValidCases_Inverted_ReturnsTrue<TValue>(TValue value1, TValue value2)
		{
			All<TValue, Negative<TValue>, NotNull<TValue>> a1 = value1;
			All<TValue, Negative<TValue>, NotNull<TValue>> a2 = value2;
			Assert.IsTrue(a1 == a2);
		}

		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
		public void EqualityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
		{
			All<TValue, NotNull<TValue>, Negative<TValue>> a1 = value1;
			All<TValue, NotNull<TValue>, Negative<TValue>> a2 = value2;
			Assert.IsFalse(a1 == a2);
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
		public void EqualityOperator_InvalidCases_Inverted_ReturnsFalse<TValue>(TValue value1, TValue value2)
		{
			All<TValue, Negative<TValue>, NotNull<TValue>> a1 = value1;
			All<TValue, Negative<TValue>, NotNull<TValue>> a2 = value2;
			Assert.IsFalse(a1 == a2);
		}

		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
		public void InequalityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
		{
			All<TValue, NotNull<TValue>, Negative<TValue>> a1 = value1;
			All<TValue, NotNull<TValue>, Negative<TValue>> a2 = value2;
			Assert.IsFalse(a1 != a2);
		}
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
		public void InequalityOperator_InvalidCases_Inverted_ReturnsFalse<TValue>(TValue value1, TValue value2)
		{
			All<TValue, Negative<TValue>, NotNull<TValue>> a1 = value1;
			All<TValue, Negative<TValue>, NotNull<TValue>> a2 = value2;
			Assert.IsFalse(a1 != a2);
		}

		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
		public void InequalityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
		{
			All<TValue, NotNull<TValue>, Negative<TValue>> a1 = value1;
			All<TValue, NotNull<TValue>, Negative<TValue>> a2 = value2;
			Assert.IsTrue(a1 != a2);
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
		public void InequalityOperator_ValidCases_Inverted_ReturnsTrue<TValue>(TValue value1, TValue value2)
		{
			All<TValue, Negative<TValue>, NotNull<TValue>> a1 = value1;
			All<TValue, Negative<TValue>, NotNull<TValue>> a2 = value2;
			Assert.IsTrue(a1 != a2);
		}

		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
		public void Equals_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
		{
			All<TValue, NotNull<TValue>, Negative<TValue>> a1 = value1;
			All<TValue, NotNull<TValue>, Negative<TValue>> a2 = value2;
			Assert.IsTrue(a1.Equals(a2));
		}
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
		public void Equals_ValidCases_Inverted_ReturnsTrue<TValue>(TValue value1, TValue value2)
		{
			All<TValue, Negative<TValue>, NotNull<TValue>> a1 = value1;
			All<TValue, Negative<TValue>, NotNull<TValue>> a2 = value2;
			Assert.IsTrue(a1.Equals(a2));
		}

		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
		public void Equals_InvalidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
		{
			All<TValue, NotNull<TValue>, Negative<TValue>> a1 = value1;
			All<TValue, NotNull<TValue>, Negative<TValue>> a2 = value2;
			Assert.IsFalse(a1.Equals(a2));
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
		public void Equals_InvalidCases_Inverted_ReturnsTrue<TValue>(TValue value1, TValue value2)
		{
			All<TValue, Negative<TValue>, NotNull<TValue>> a1 = value1;
			All<TValue, Negative<TValue>, NotNull<TValue>> a2 = value2;
			Assert.IsFalse(a1.Equals(a2));
		}

	}
}