using Many.Validators.Tests.Fixtures;
using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal class NotNullTests
    {
        #region String
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.Null))]
        public void NullValue_ReturnsException(string value)
        {
            NullValue_ReturnsException<string>(value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.Emtpy))]
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void NonNullValue_ReturnsValue(string value)
        {
            NonNullValue_ReturnsValue<string>(value);
        }
        #endregion String

        #region Int
        [TestCaseSource(typeof(StructTestCaseSources), nameof(StructTestCaseSources.NotEmpty))]
        [TestCaseSource(typeof(StructTestCaseSources), nameof(StructTestCaseSources.NotEmpty))]
        public void NonNullValue_ReturnsValue(int value)
        {
            NonNullValue_ReturnsValue<int>(value);
        }
        #endregion Int

        #region Nullable
        [TestCaseSource(typeof(NullableTestCaseSources), nameof(NullableTestCaseSources.NotEmpty))]
        public void NonNullValue_ReturnsValue<T>(T value)
        {
            Assert.DoesNotThrow(() =>
            {
                NotNull<T> a1 = value;
                Assert.IsNotNull(a1);
            });
        }

        [TestCaseSource(typeof(NullableTestCaseSources), nameof(NullableTestCaseSources.Null))]
        public void NullValue_ReturnsException(int? value)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                NotNull<int?> a1 = value;
            });
        }
        #endregion Nullable

        #region Implicit conversion
        [TestCaseSource(typeof(StructTestCaseSources), nameof(StructTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(int value)
        {
            ImplicitConversionFixture.ImplicitConversion_ReturnsUnderlyingType(typeof(NotNull<int>), value);
        }
        [TestCaseSource(typeof(ClassTestCaseSources), nameof(ClassTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(string value)
        {
            ImplicitConversionFixture.ImplicitConversion_ReturnsUnderlyingType(typeof(NotNull<string>), value);
        }
        [TestCaseSource(typeof(NullableTestCaseSources), nameof(NullableTestCaseSources.NotEmpty))]
        public void ImplicitConversion_ReturnsUnderlyingType(int? value)
        {
            ImplicitConversionFixture.ImplicitConversion_ReturnsUnderlyingType(typeof(NotNull<int?>), value);
        }
        #endregion Implicit conversion

        private void NullValue_ReturnsException<T>(T value)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                NotNull<T> a1 = value;
            });
        }
    }
}
