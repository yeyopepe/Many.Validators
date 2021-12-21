using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;

namespace Many.Validators.Tests
{
	[TestFixture]
    internal partial class PositiveTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void EqualityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            Positive<TValue> a1 = value1;
            Positive<TValue> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
        {
            Positive<TValue> a1 = value1;
            Positive<TValue> a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void InequalityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
        {
            Positive<TValue> a1 = value1;
            Positive<TValue> a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void InequalityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            Positive<TValue> a1 = value1;
            Positive<TValue> a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void Equals_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            Positive<TValue> a1 = value1;
            Positive<TValue> a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void Equals_InvalidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            Positive<TValue> a1 = value1;
            Positive<TValue> a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }
    }
}

