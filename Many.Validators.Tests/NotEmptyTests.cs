using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal class NotEmtpyTests: BaseTests
    {
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.Empty))]
        public void EmptyValue_ReturnsException(string value)
        {
            CreateValidator_InvalidValues_ThrowsException<NotEmpty, string, ArgumentException>(value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void NotEmptyValue_ReturnsValue(string value)
        {
            CreateValidator_ValidValues_ReturnsValue<NotEmpty, string>(value);
        }

        #region Implicit conversion
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(string value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(NotNull<string>), value);
        }
        #endregion Implicit conversion
    }
}
