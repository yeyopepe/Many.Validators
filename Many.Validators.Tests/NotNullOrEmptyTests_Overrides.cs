using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;

namespace Many.Validators.Tests
{
	[TestFixture]
    internal partial class NotNullOrEmptyTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        public void EqualityOperator_ValidCases_ReturnsTrue(string value1, string value2)
        {
            NotNullOrEmpty a1 = value1;
            NotNullOrEmpty a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        public void EqualityOperator_InvalidCases_ReturnsFalse(string value1, string value2)
        {
            NotNullOrEmpty a1 = value1;
            NotNullOrEmpty a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        public void InequalityOperator_InvalidCases_ReturnsFalse(string value1, string value2)
        {
            NotNullOrEmpty a1 = value1;
            NotNullOrEmpty a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        public void InequalityOperator_ValidCases_ReturnsTrue(string value1, string value2)
        {
            NotNullOrEmpty a1 = value1;
            NotNullOrEmpty a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyString))]
        public void Equals_ValidCases_ReturnsTrue(string value1, string value2)
        {
            NotNullOrEmpty a1 = value1;
            NotNullOrEmpty a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyString))]
        public void Equals_InvalidCases_ReturnsTrue(string value1, string value2)
        {
            NotNullOrEmpty a1 = value1;
            NotNullOrEmpty a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }

        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void ToString_ReturnsValueAsString(string value1)
        {
            NotNullOrEmpty a1 = value1;
            Assert.AreEqual(value1.ToString(), a1.ToString());
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void GetHashCode_ReturnsSameHashCode(string value1)
        {
            NotNullOrEmpty a1 = value1;
            Assert.AreEqual(value1.GetHashCode(), a1.GetHashCode());
        }
    }
}
