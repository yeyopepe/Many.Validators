using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;

namespace Many.Validators.Tests
{
	[TestFixture]
    internal partial class NotNullTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void EqualityOperator_ValidCases_ReturnsTrue<TValue> (TValue value1, TValue value2)
        {
            NotNull<TValue> a1 = value1;
            NotNull<TValue> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<TValue> (TValue value1, TValue value2)
        {
            NotNull<TValue> a1 = value1;
            NotNull<TValue> a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void InequalityOperator_InvalidCases_ReturnsFalse<TValue> (TValue value1, TValue value2)
        {
            NotNull<TValue> a1 = value1;
            NotNull<TValue> a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void InequalityOperator_ValidCases_ReturnsTrue<TValue> (TValue value1, TValue value2)
        {
            NotNull<TValue> a1 = value1;
            NotNull<TValue> a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void Equals_ValidCases_ReturnsTrue<TValue> (TValue value1, TValue value2)
        {
            NotNull<TValue> a1 = value1;
            NotNull<TValue> a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void Equals_InvalidCases_ReturnsTrue<TValue> (TValue value1, TValue value2)
        {
            NotNull<TValue> a1 = value1;
            NotNull<TValue> a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }

        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Double))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int64))]
        public void ToString_ReturnsValueAsString<TValue>(TValue value1)
        {
            NotNull<TValue> a1 = value1;
            Assert.AreEqual(value1.ToString(), a1.ToString());
        }
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Double))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int64))]
        public void GetHashCode_ReturnsSameHashCode<TValue>(TValue value1)
        {
            NotNull<TValue> a1 = value1;
            Assert.AreEqual(value1.GetHashCode(), a1.GetHashCode());
        }
    }
}
