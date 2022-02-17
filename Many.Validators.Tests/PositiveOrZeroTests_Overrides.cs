using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;

namespace Many.Validators.Tests
{
	[TestFixture]
    internal partial class PositiveOrZeroTests 
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void EqualityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            PositiveOrZero<TValue> a1 = value1;
            PositiveOrZero<TValue> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
        {
            PositiveOrZero<TValue> a1 = value1;
            PositiveOrZero<TValue> a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void InequalityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
        {
            PositiveOrZero<TValue> a1 = value1;
            PositiveOrZero<TValue> a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void InequalityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            PositiveOrZero<TValue> a1 = value1;
            PositiveOrZero<TValue> a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void Equals_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            PositiveOrZero<TValue> a1 = value1;
            PositiveOrZero<TValue> a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void Equals_InvalidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            PositiveOrZero<TValue> a1 = value1;
            PositiveOrZero<TValue> a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }

        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int64))]
        public void ToString_ReturnsValueAsString<TValue>(TValue value1)
        {
            PositiveOrZero<TValue> a1 = value1;
            Assert.AreEqual(value1.ToString(), a1.ToString());
        }
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int64))]
        public void GetHashCode_ReturnsSameHashCode<TValue>(TValue value1)
        {
            PositiveOrZero<TValue> a1 = value1;
            Assert.AreEqual(value1.GetHashCode(), a1.GetHashCode());
        }
    }
}

