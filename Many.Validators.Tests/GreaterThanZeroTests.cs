using Many.Validators.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    [TestFixture]
    internal class GreaterThanZeroTests: BaseTests
    {
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.Int16))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.Int32))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.Int64))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.SByte))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.UInt16))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.UInt32))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.UInt64))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.Byte))]        
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.Single))]
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.Decimal))]
#if NET5_0_OR_GREATER
        [TestCaseSource(typeof(NumericRangeGreaterThanZeroTestCaseSources), nameof(NumericRangeGreaterThanZeroTestCaseSources.Half))]
#endif
        public void GreaterThanZero_ReturnsValue<V>(V value)
        {
            CreateValidator_ValidValues_ReturnsValue<GreaterThanZero<V>,V>(value);
        }

        [TestCaseSource(typeof(NumericRangeLowerThanZeroTestCaseSources), nameof(NumericRangeLowerThanZeroTestCaseSources.Int16))]
        [TestCaseSource(typeof(NumericRangeLowerThanZeroTestCaseSources), nameof(NumericRangeLowerThanZeroTestCaseSources.Int32))]
        [TestCaseSource(typeof(NumericRangeLowerThanZeroTestCaseSources), nameof(NumericRangeLowerThanZeroTestCaseSources.Int64))]
        [TestCaseSource(typeof(NumericRangeLowerThanZeroTestCaseSources), nameof(NumericRangeLowerThanZeroTestCaseSources.SByte))]
        [TestCaseSource(typeof(NumericRangeLowerThanZeroTestCaseSources), nameof(NumericRangeLowerThanZeroTestCaseSources.Double))]
        [TestCaseSource(typeof(NumericRangeLowerThanZeroTestCaseSources), nameof(NumericRangeLowerThanZeroTestCaseSources.Single))]
        [TestCaseSource(typeof(NumericRangeLowerThanZeroTestCaseSources), nameof(NumericRangeLowerThanZeroTestCaseSources.Decimal))]
#if NET5_0_OR_GREATER
        [TestCaseSource(typeof(NumericRangeLowerThanZeroTestCaseSources), nameof(NumericRangeLowerThanZeroTestCaseSources.Half))]
#endif
        public void LowerThanZero_ReturnsException<V>(V value)
        {
            CreateValidator_InvalidValues_ThrowsException<GreaterThanZero<V>, V, ArgumentOutOfRangeException>(value);
        }
    }
}

