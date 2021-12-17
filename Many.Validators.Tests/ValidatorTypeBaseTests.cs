using Many.Validators;
using Many.Validators.Tests.Fixtures;
using NUnit.Framework;

namespace Many.Validatos.Tests
{
    [TestFixture]
    public class ValidatorTypeBaseTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.String))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Int))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        public void EqualityOperator_ValidCases_ReturnsTrue<T>(T a, T b)
        {
            None<T> a1 = a;
            None<T> a2 = b;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.String))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Int))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<T>(T a, T b)
        {
            None<T> a1 = a;
            None<T> a2 = b;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.String))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Int))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        public void InequalityOperator_InvalidCases_ReturnsFalse<T>(T a, T b)
        {
            None<T> a1 = a;
            None<T> a2 = b;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.String))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Int))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        public void InequalityOperator_ValidCases_ReturnsTrue<T>(T a, T b)
        {
            None<T> a1 = a;
            None<T> a2 = b;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.String))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Int))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        public void Equals_ValidCases_ReturnsTrue<T>(T a, T b)
        {
            None<T> a1 = a;
            None<T> a2 = b;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.String))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Int))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        public void Equals_InvalidCases_ReturnsTrue<T>(T a, T b)
        {
            None<T> a1 = a;
            None<T> a2 = b;
            Assert.IsFalse(a1.Equals(a2));
        }

    }
}