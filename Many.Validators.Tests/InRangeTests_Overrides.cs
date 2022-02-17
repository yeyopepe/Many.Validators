using System;
using Many.Validators.Tests.Fixtures;
using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;

namespace Many.Validators.Tests
{
	[TestFixture]
    internal partial class InRangeTests_Overrides
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative_InRange_neg100_1))]
        public void EqualityOperator_ValidCases_ReturnsTrue(Int64 value1, Int64 value2)
        {
            InRange<Range_Int64_neg100_1, Int64> a1 = value1;
            InRange<Range_Int64_neg100_1, Int64> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative_Range_neg100_1))]
        public void EqualityOperator_ValidCases_ReturnsTrue(double value1, double value2)
        {
            InRange<Range_Double_neg100_1, double> a1 = value1;
            InRange<Range_Double_neg100_1, double> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative_Range_neg100_1))]
		public void EqualityOperator_InvalidCases_ReturnsFalse(Int64 value1, Int64 value2)
		{
			InRange<Range_Int64_neg100_1, Int64> a1 = value1;
            InRange<Range_Int64_neg100_1, Int64> a2 = value2;
			Assert.IsFalse(a1 == a2);
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative_Range_neg100_1))]
		public void EqualityOperator_InvalidCases_ReturnsFalse(double value1, double value2)
		{
			InRange<Range_Double_neg100_1, double> a1 = value1;
			InRange<Range_Double_neg100_1, double> a2 = value2;
			Assert.IsFalse(a1 == a2);
		}
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative_InRange_neg100_1))]
		public void InequalityOperator_InvalidCases_ReturnsFalse(Int64 value1, Int64 value2)
		{
			InRange<Range_Int64_neg100_1, Int64> a1 = value1;
			InRange<Range_Int64_neg100_1, Int64> a2 = value2;
			Assert.IsFalse(a1 != a2);
		}
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative_Range_neg100_1))]
		public void InequalityOperator_InvalidCases_ReturnsFalse(double value1, double value2)
		{
			InRange<Range_Double_neg100_1, double> a1 = value1;
			InRange<Range_Double_neg100_1, double> a2 = value2;
			Assert.IsFalse(a1 != a2);
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative_Range_neg100_1))]
		public void InequalityOperator_ValidCases_ReturnsTrue(Int64 value1, Int64 value2)
		{
			InRange<Range_Int64_neg100_1, Int64> a1 = value1;
			InRange<Range_Int64_neg100_1, Int64> a2 = value2;
			Assert.IsTrue(a1 != a2);
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative_Range_neg100_1))]
		public void InequalityOperator_ValidCases_ReturnsTrue(double value1, double value2)
		{
			InRange<Range_Double_neg100_1, double> a1 = value1;
			InRange<Range_Double_neg100_1, double> a2 = value2;
			Assert.IsTrue(a1 != a2);
		}
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative_InRange_neg100_1))]
		public void Equals_ValidCases_ReturnsTrue(Int64 value1, Int64 value2)
		{
			InRange<Range_Int64_neg100_1, Int64> a1 = value1;
			InRange<Range_Int64_neg100_1, Int64> a2 = value2;
			Assert.IsTrue(a1.Equals(a2));
		}
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative_Range_neg100_1))]
		public void Equals_ValidCases_ReturnsTrue(double value1, double value2)
		{
			InRange<Range_Double_neg100_1, double> a1 = value1;
			InRange<Range_Double_neg100_1, double> a2 = value2;
			Assert.IsTrue(a1.Equals(a2));
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative_Range_neg100_1))]
		public void Equals_InvalidCases_ReturnsTrue(Int64 value1, Int64 value2)
		{
			InRange<Range_Int64_neg100_1, Int64> a1 = value1;
			InRange<Range_Int64_neg100_1, Int64> a2 = value2;
			Assert.IsFalse(a1.Equals(a2));
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative_Range_neg100_1))]
		public void Equals_InvalidCases_ReturnsTrue(double value1, double value2)
		{
			InRange<Range_Double_neg100_1, double> a1 = value1;
			InRange<Range_Double_neg100_1, double> a2 = value2;
			Assert.IsFalse(a1.Equals(a2));
		}

		[TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Double_InRange_neg100_1))]
		public void ToString_ReturnsValueAsString(double value1)
		{
			InRange<Range_Double_neg100_1, double> a1 = value1;
			Assert.AreEqual(value1.ToString(), a1.ToString());
		}
		[TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Double_InRange_neg100_1))]
		public void GetHashCode_ReturnsSameHashCode(double value1)
		{
			InRange<Range_Double_neg100_1, double> a1 = value1;
			Assert.AreEqual(value1.GetHashCode(), a1.GetHashCode());
		}
	}
}
