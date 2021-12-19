using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal partial class NotEmtpyTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        public void EqualityOperator_ValidCases_ReturnsTrue(string value1, string value2)
        {
            NotEmpty a1 = value1;
            NotEmpty a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        public void EqualityOperator_InvalidCases_ReturnsFalse(string value1, string value2)
        {
            NotEmpty a1 = value1;
            NotEmpty a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        public void InequalityOperator_InvalidCases_ReturnsFalse(string value1, string value2)
        {
            NotEmpty a1 = value1;
            NotEmpty a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        public void InequalityOperator_ValidCases_ReturnsTrue(string value1, string value2)
        {
            NotEmpty a1 = value1;
            NotEmpty a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        public void Equals_ValidCases_ReturnsTrue(string value1, string value2)
        {
            NotEmpty a1 = value1;
            NotEmpty a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        public void Equals_InvalidCases_ReturnsTrue(string value1, string value2)
        {
            NotEmpty a1 = value1;
            NotEmpty a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }
    }
}
