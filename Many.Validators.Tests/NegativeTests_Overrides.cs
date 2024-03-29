﻿using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;

namespace Many.Validators.Tests
{
	[TestFixture]
    internal partial class NegativeTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
        public void EqualityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            Negative<TValue> a1 = value1;
            Negative<TValue> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
        {
            Negative<TValue> a1 = value1;
            Negative<TValue> a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
        public void InequalityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
        {
            Negative<TValue> a1 = value1;
            Negative<TValue> a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
        public void InequalityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            Negative<TValue> a1 = value1;
            Negative<TValue> a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.DoubleNegative))]
        public void Equals_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            Negative<TValue> a1 = value1;
            Negative<TValue> a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.IntNegative))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.DoubleNegative))]
        public void Equals_InvalidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
        {
            Negative<TValue> a1 = value1;
            Negative<TValue> a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }

        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Int64))]
        public void ToString_ReturnsValueAsString<TValue>(TValue value1)
        {
            Negative<TValue> a1 = value1;
            Assert.AreEqual(value1.ToString(), a1.ToString());
        }
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Int64))]
        public void GetHashCode_ReturnsSameHashCode<TValue>(TValue value1)
        {
            Negative<TValue> a1 = value1;
            Assert.AreEqual(value1.GetHashCode(), a1.GetHashCode());
        }

    }
}
