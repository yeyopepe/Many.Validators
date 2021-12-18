using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;

namespace Many.Validators.Tests
{
    [TestFixture]
    public class ValidatorTypeBaseTests: BaseTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.String))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Int))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Double))]
        public void EqualityOperator_ValidCases_ReturnsTrue<T>(T value1, T value2)
        {
            None<T> a1 = value1;
            None<T> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.String))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Int))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Double))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<T>(T value1, T value2)
        {
            None<T> a1 = value1;
            None<T> a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.String))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Int))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Double))]
        public void InequalityOperator_InvalidCases_ReturnsFalse<T>(T value1, T value2)
        {
            None<T> a1 = value1;
            None<T> a2 = value2;
            Assert.IsFalse(a1 != a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.String))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Int))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Double))]
        public void InequalityOperator_ValidCases_ReturnsTrue<T>(T value1, T value2)
        {
            None<T> a1 = value1;
            None<T> a2 = value2;
            Assert.IsTrue(a1 != a2);
        }
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.String))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Int))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Bool))]
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.Double))]
        public void Equals_ValidCases_ReturnsTrue<T>(T value1, T value2)
        {
            None<T> a1 = value1;
            None<T> a2 = value2;
            Assert.IsTrue(a1.Equals(a2));
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.String))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Int))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Bool))]
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.Double))]
        public void Equals_InvalidCases_ReturnsTrue<T>(T value1, T value2)
        {
            None<T> a1 = value1;
            None<T> a2 = value2;
            Assert.IsFalse(a1.Equals(a2));
        }

        #region Implicit conversion
        [TestCaseSource(typeof(StructTestCaseSources), nameof(StructTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(int value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(None<int>), value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(string value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(None<string>), value);
        }
        [TestCaseSource(typeof(NullableTestCaseSources), nameof(NullableTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(int? value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(None<int?>), value);
        }
        #endregion Implicit conversion
    }
}