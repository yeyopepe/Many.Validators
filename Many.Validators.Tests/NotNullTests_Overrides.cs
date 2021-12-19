using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

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
        public void EqualityOperator_ValidCases_ReturnsTrue<TValidator> (TValidator value1, TValidator value2)
        {
            NotNull<TValidator> a1 = value1;
            NotNull<TValidator> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<TValidator> (TValidator value1, TValidator value2)
        {
            NotNull<TValidator> a1 = value1;
            NotNull<TValidator> a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void InequalityOperator_InvalidCases_ReturnsFalse<TValidator> (TValidator value1, TValidator value2)
        {
            NotNull<TValidator> a1 = value1;
            NotNull<TValidator> a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void InequalityOperator_ValidCases_ReturnsTrue<TValidator> (TValidator value1, TValidator value2)
        {
            NotNull<TValidator> a1 = value1;
            NotNull<TValidator> a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoublePositive))]
        public void Equals_ValidCases_ReturnsTrue<TValidator> (TValidator value1, TValidator value2)
        {
            NotNull<TValidator> a1 = value1;
            NotNull<TValidator> a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.EmptyString))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntPositive))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoublePositive))]
        public void Equals_InvalidCases_ReturnsTrue<TValidator> (TValidator value1, TValidator value2)
        {
            NotNull<TValidator> a1 = value1;
            NotNull<TValidator> a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }
    }
}
