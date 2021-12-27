using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal partial class NotNullOrEmptyTests: BaseTests
    {
        [Test]
        public void NullValue_ReturnsNullException()
        {
            string value = null;
            CreateValidator_InvalidValues_ThrowsException<NotNullOrEmpty, string, ArgumentNullException>(value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.Empty))]
        public void EmptyValue_ReturnsException(string value)
        {
            CreateValidator_InvalidValues_ThrowsException<NotNullOrEmpty, string, ArgumentException>(value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void NotEmptyValue_ReturnsValue(string value)
        {
            CreateValidator_ValidValues_ReturnsValue<NotNullOrEmpty, string>(value);
        }

        #region Implicit conversion
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(string value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(NotNullOrEmpty), value);
        }
        #endregion Implicit conversion
    }
}
