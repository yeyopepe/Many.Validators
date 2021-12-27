using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;
using System.Collections;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal partial class NotNullOrEmptyArrayTests : BaseTests
    {
		[Test]
		public void NullValue_ReturnsNullException()
		{
			string[] value = null;
			CreateValidator_InvalidValues_ThrowsException<NotNullOrEmptyArray<string[]>, string[], ArgumentNullException>(value);
		}
		[TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.EmptyList))]
        public void EmptyValue_ReturnsException<TValue>(TValue value)
            where TValue : IEnumerable
        {
            CreateValidator_InvalidValues_ThrowsException<NotNullOrEmptyArray<TValue>, TValue, ArgumentException>(value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmptyList))]
        public void NotEmptyValue_ReturnsValue<TValue>(TValue value)
            where TValue : IEnumerable
        {
            CreateValidator_ValidValues_ReturnsValue<NotNullOrEmptyArray<TValue>, TValue>(value);
        }

        #region Implicit conversion
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmptyList))]
        public void ImplicitConversion_ReturnsUnderlyingType<TValue>(TValue value)
            where TValue : IEnumerable
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(NotNullOrEmptyArray<TValue>), value);
        }
        #endregion Implicit conversion
    }
}
