using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal class NegativeOrZeroTests : BaseTests
    {
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Int16))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Int32))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Int64))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.SByte))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Single))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Decimal))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Int16))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Int32))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Int64))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.SByte))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Double))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Single))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Decimal))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Int16))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Int32))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Int64))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.SByte))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.UInt16))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.UInt32))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.UInt64))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Byte))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Single))]
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Decimal))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Int16))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Int32))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Int64))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.SByte))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.UInt16))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.UInt32))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.UInt64))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Byte))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Double))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Single))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Decimal))]
#if NET5_0_OR_GREATER
        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Half))]
        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Half))]
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Half))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Half))]
#endif
        public void LowerOrEqualThanZero_ReturnsValue<TValue>(TValue value)
        {
            CreateValidator_ValidValues_ReturnsValue<NegativeOrZero<TValue>,TValue>(value);
        }

        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int16))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int32))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int64))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.SByte))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Single))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Decimal))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int16))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int32))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int64))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.SByte))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Double))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Single))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Decimal))]
#if NET5_0_OR_GREATER
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Half))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Half))]
#endif
        public void GreaterThanZero_ReturnsException<TValue>(TValue value)
        {
            CreateValidator_InvalidValues_ThrowsException<NegativeOrZero<TValue>, TValue, ArgumentOutOfRangeException>(value);
        }

        #region Implicit conversion
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Int16))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Int16))]
        public void ImplicitConversion_ReturnsUnderlyingType<Tvalue>(Tvalue value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(NegativeOrZero<Tvalue>), value);
        }       
        #endregion Implicit conversion
    }
}

