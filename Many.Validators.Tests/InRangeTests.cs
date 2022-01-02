using Many.Validators.Tests.Fixtures;
using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal partial class InRangeTests: BaseTests
    {
        //TODO: Terminar
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Double_InRange_neg100_1))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Double_InRange_neg100_1))]
        public void InRange_ReturnsValue(double value)
        {
            CreateValidator_ValidValues_ReturnsValue<InRange<Range_Double_neg100_1,double>, double>(value);
        }

        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Int64_InRange_neg100_1))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Int64_InRange_neg100_1))]
        public void InRange_ReturnsValue(Int64 value)
        {
            CreateValidator_ValidValues_ReturnsValue<InRange<Range_Int64_neg100_1, Int64>, Int64>(value);
        }

#if NET5_0_OR_GREATER
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Half_InRange_neg100_1))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Half_InRange_neg100_1))]
        public void InRange_ReturnsValue(System.Half value)
        {
            CreateValidator_ValidValues_ReturnsValue<InRange<Range_Half_neg100_1, System.Half>, System.Half>(value);
        }
#endif
        //        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int16))]
        //        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int32))]
        //        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Int64))]
        //        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.SByte))]
        //        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Double))]
        //        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Single))]
        //        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Decimal))]
        //        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int16))]
        //        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int32))]
        //        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Int64))]
        //        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.SByte))]
        //        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Double))]
        //        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Single))]
        //        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Decimal))]
        //#if NET5_0_OR_GREATER
        //        [TestCaseSource(typeof(NumericPositiveTestCaseSources), nameof(NumericPositiveTestCaseSources.Half))]
        //        [TestCaseSource(typeof(NullableNumericPositiveTestCaseSources), nameof(NullableNumericPositiveTestCaseSources.Half))]
        //#endif
        //        public void GreaterThanZero_ReturnsException<TValue>(TValue value)
        //        {
        //            CreateValidator_InvalidValues_ThrowsException<Negative<TValue>, TValue, ArgumentOutOfRangeException>(value);
        //        }

        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Int16))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Int32))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Int64))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.SByte))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.UInt16))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.UInt32))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.UInt64))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Byte))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Double))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Single))]
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Decimal))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Int16))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Int32))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Int64))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.SByte))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.UInt16))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.UInt32))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.UInt64))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Byte))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Double))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Single))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NullableNumericZeroTestCaseSources.Decimal))]
        //#if NET5_0_OR_GREATER
        //        [TestCaseSource(typeof(NumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Half))]
        //        [TestCaseSource(typeof(NullableNumericZeroTestCaseSources), nameof(NumericZeroTestCaseSources.Half))]
        //#endif
        //        public void Zero_ReturnsException<TValue>(TValue value)
        //        {
        //            CreateValidator_InvalidValues_ThrowsException<Negative<TValue>, TValue, ArgumentOutOfRangeException>(value);
        //        }

        #region Implicit conversion
        [TestCaseSource(typeof(NumericNegativeTestCaseSources), nameof(NumericNegativeTestCaseSources.Int64_InRange_neg100_1))]
        [TestCaseSource(typeof(NullableNumericNegativeTestCaseSources), nameof(NullableNumericNegativeTestCaseSources.Int64_InRange_neg100_1))]
        public void ImplicitConversion_ReturnsUnderlyingType(Int64 value)
        {
            ImplicitConversion_ReturnsUnderlyingType(typeof(InRange<Range_Int64_neg100_1,Int64>), value);
        }
#endregion Implicit conversion

        
    }
}

