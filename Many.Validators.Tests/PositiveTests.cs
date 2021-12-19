using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal class PositiveTests: BaseTests
    {
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int16))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int32))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int64))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.SByte))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.UInt16))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.UInt32))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.UInt64))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Byte))]        
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Single))]
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Decimal))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int16))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int32))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int64))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.SByte))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.UInt16))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.UInt32))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.UInt64))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Byte))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Double))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Single))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Decimal))]
#if NET5_0_OR_GREATER
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Half))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Half))]
#endif
        public void GreaterThanZero_ReturnsValue<V>(V value)
        {
            CreateValidator_ValidValues_ReturnsValue<Positive<V>,V>(value);
        }

        [TestCaseSource(typeof(NumericRangeNegativeTestCaseSources), nameof(NumericRangeNegativeTestCaseSources.Int16))]
        [TestCaseSource(typeof(NumericRangeNegativeTestCaseSources), nameof(NumericRangeNegativeTestCaseSources.Int32))]
        [TestCaseSource(typeof(NumericRangeNegativeTestCaseSources), nameof(NumericRangeNegativeTestCaseSources.Int64))]
        [TestCaseSource(typeof(NumericRangeNegativeTestCaseSources), nameof(NumericRangeNegativeTestCaseSources.SByte))]
        [TestCaseSource(typeof(NumericRangeNegativeTestCaseSources), nameof(NumericRangeNegativeTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericRangeNegativeTestCaseSources), nameof(NumericRangeNegativeTestCaseSources.Single))]
        [TestCaseSource(typeof(NumericRangeNegativeTestCaseSources), nameof(NumericRangeNegativeTestCaseSources.Decimal))]
        [TestCaseSource(typeof(NullableNumericRangeNegativeTestCaseSources), nameof(NullableNumericRangeNegativeTestCaseSources.Int16))]
        [TestCaseSource(typeof(NullableNumericRangeNegativeTestCaseSources), nameof(NullableNumericRangeNegativeTestCaseSources.Int32))]
        [TestCaseSource(typeof(NullableNumericRangeNegativeTestCaseSources), nameof(NullableNumericRangeNegativeTestCaseSources.Int64))]
        [TestCaseSource(typeof(NullableNumericRangeNegativeTestCaseSources), nameof(NullableNumericRangeNegativeTestCaseSources.SByte))]
        [TestCaseSource(typeof(NullableNumericRangeNegativeTestCaseSources), nameof(NullableNumericRangeNegativeTestCaseSources.Double))]
        [TestCaseSource(typeof(NullableNumericRangeNegativeTestCaseSources), nameof(NullableNumericRangeNegativeTestCaseSources.Single))]
        [TestCaseSource(typeof(NullableNumericRangeNegativeTestCaseSources), nameof(NullableNumericRangeNegativeTestCaseSources.Decimal))]
#if NET5_0_OR_GREATER
        [TestCaseSource(typeof(NumericRangeNegativeTestCaseSources), nameof(NumericRangeNegativeTestCaseSources.Half))]
        [TestCaseSource(typeof(NullableNumericRangeNegativeTestCaseSources), nameof(NullableNumericRangeNegativeTestCaseSources.Half))]
#endif
        public void LowerThanZero_ReturnsException<V>(V value)
        {
            CreateValidator_InvalidValues_ThrowsException<Positive<V>, V, ArgumentOutOfRangeException>(value);
        }

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
#endif
        public void Zero_ReturnsException<V>(V value)
        {
            CreateValidator_InvalidValues_ThrowsException<Positive<V>, V, ArgumentOutOfRangeException>(value);
        }

        #region Implicit conversion
        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int16))]
        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int16))]
        public void ImplicitConversion_ReturnsUnderlyingType<V>(V value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(Positive<V>), value);
        }       
        #endregion Implicit conversion
    }
}

