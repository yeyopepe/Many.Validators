using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal partial class NotNullTests: BaseTests
    {
        #region Class
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.Null))]
        public void NullValue_ReturnsException(string value)
        {
            CreateValidator_InvalidValues_ThrowsException<NotNull<string>, string, ArgumentNullException>(value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.Empty))]
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void NotNullValue_ReturnsValue(string value)
        {
            NotNullValue_ReturnsValue<string>(value);
        }
        #endregion Class

        #region Struct
        [TestCaseSource(typeof(StructTestCaseSources), nameof(StructTestCaseSources.NotEmpty))]
        [TestCaseSource(typeof(StructTestCaseSources), nameof(StructTestCaseSources.NotEmpty))]
        public void NotNullValue_ReturnsValue(int value)
        {
            NotNullValue_ReturnsValue<int>(value);
        }
        #endregion Struct

        #region Nullable
        [TestCaseSource(typeof(NullableTestCaseSources), nameof(NullableTestCaseSources.NotEmpty))]
        public void NotNullValue_ReturnsValue<TValue>(TValue value)
        {
            CreateValidator_ValidValues_ReturnsValue<NotNull<TValue>, TValue>(value);
        }

        [TestCaseSource(typeof(NullableTestCaseSources), nameof(NullableTestCaseSources.Null))]
        public void NullValue_ReturnsException(int? value)
        {
            CreateValidator_InvalidValues_ThrowsException<NotNull<int?>, int?, ArgumentNullException>(value);
        }
        #endregion Nullable

        #region Implicit conversion
        [TestCaseSource(typeof(StructTestCaseSources), nameof(StructTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(int value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(NotNull<int>), value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(string value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(NotNull<string>), value);
        }
        [TestCaseSource(typeof(NullableTestCaseSources), nameof(NullableTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(int? value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(NotNull<int?>), value);
        }
        #endregion Implicit conversion
    }
}
