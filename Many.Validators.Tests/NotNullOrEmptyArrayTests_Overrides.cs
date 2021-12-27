using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System.Collections;

namespace Many.Validators.Tests
{
	[TestFixture]
    internal partial class NotNullOrEmptyArrayTests
    {
        [TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyLists))]
        public void EqualityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
            where TValue: IEnumerable
        {
            NotNullOrEmptyArray<TValue> a1 = value1;
            NotNullOrEmptyArray<TValue> a2 = value2;
            Assert.IsTrue(a1 == a2);
        }
        [TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyLists))]
        public void EqualityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
            where TValue : IEnumerable
        {
            NotNullOrEmptyArray<TValue> a1 = value1;
            NotNullOrEmptyArray<TValue> a2 = value2;
            Assert.IsFalse(a1 == a2);
        }
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyLists))]
		public void InequalityOperator_InvalidCases_ReturnsFalse<TValue>(TValue value1, TValue value2)
			where TValue : IEnumerable
		{
			NotNullOrEmptyArray<TValue> a1 = value1;
			NotNullOrEmptyArray<TValue> a2 = value2;
			Assert.IsFalse(a1 != a2);
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyLists))]
		public void InequalityOperator_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
			where TValue : IEnumerable
		{
			NotNullOrEmptyArray<TValue> a1 = value1;
			NotNullOrEmptyArray<TValue> a2 = value2;
			Assert.IsTrue(a1 != a2);
		}
		[TestCaseSource(typeof(EqualityTestCaseSources), nameof(EqualityTestCaseSources.NotEmptyLists))]
		public void Equals_ValidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
			where TValue : IEnumerable
		{
			NotNullOrEmptyArray<TValue> a1 = value1;
			NotNullOrEmptyArray<TValue> a2 = value2;
			Assert.IsTrue(a1.Equals(a2));
		}
		[TestCaseSource(typeof(InequalityTestCaseSources), nameof(InequalityTestCaseSources.NotEmptyLists))]
		public void Equals_InvalidCases_ReturnsTrue<TValue>(TValue value1, TValue value2)
			where TValue : IEnumerable
		{
			NotNullOrEmptyArray<TValue> a1 = value1;
			NotNullOrEmptyArray<TValue> a2 = value2;
			Assert.IsFalse(a1.Equals(a2));
		}
	}
}
