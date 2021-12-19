using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal partial class NegativeOrZeroOrZeroTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
        public void EqualityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            NegativeOrZero<TValue> a1 = value1;
            NegativeOrZero<TValue> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
        {
            NegativeOrZero<TValue> a1 = value1;
            NegativeOrZero<TValue> a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
        public void InequalityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
        {
            NegativeOrZero<TValue> a1 = value1;
            NegativeOrZero<TValue> a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
        public void InequalityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            NegativeOrZero<TValue> a1 = value1;
            NegativeOrZero<TValue> a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
        public void Equals_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            NegativeOrZero<TValue> a1 = value1;
            NegativeOrZero<TValue> a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
        public void Equals_InvalidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            NegativeOrZero<TValue> a1 = value1;
            NegativeOrZero<TValue> a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }
    }
}
