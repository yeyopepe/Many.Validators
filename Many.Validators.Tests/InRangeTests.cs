using Many.Validators.Tests.Fixtures;
using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal partial class InRangeTests: BaseTests
    {
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
        public void InRange_ReturnsValue(Half value)
        {
            CreateValidator_ValidValues_ReturnsValue<InRange<Range_Half_neg100_1, Half>, Half>(value);
        }
#endif
        
        [TestCaseSource(typeof(NumericRangeCompleteTestCaseSources), nameof(NumericRangeCompleteTestCaseSources.Double))]
        public void NotInRange_ReturnsException(double value)
        {
            CreateValidator_InvalidValues_ThrowsException<InRange<Range_Double_neg100_1, double>, double, ArgumentOutOfRangeException>(value);
        }


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

