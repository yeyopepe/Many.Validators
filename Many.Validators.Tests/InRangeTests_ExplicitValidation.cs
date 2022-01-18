using Many.Validators.Tests.Fixtures;
using NUnit.Framework;
using System;
using System.Linq;

namespace Many.Validators.Tests
{
	[TestFixture]
	internal partial class InRangeTests
	{
		readonly Int64[] _inputErrors = new Int64[] { -342, 1230 }; //Range Range_Int64_neg100_1
		readonly Int64[] _inputValid = new Int64[] { -1, -5, -100 };

		private Int64[] GetInput(bool includeErrors = true)
			=> includeErrors ?
				_inputValid.Concat(_inputErrors).ToArray() :
				_inputValid;


		[TestCase(false, true)]
		[TestCase(true, false)]
		public void IsValid_ReturnsAllErrors(bool includeErrors, bool expectedResult)
		{
			//Arrange
			var input = GetInput(includeErrors);

			//Test
			var result = InRange<Range_Int64_neg100_1, Int64>.IsValid(values: input,
																		errors: out Int64[] errors);
			//Assert
			Assert.AreEqual(expectedResult, result);
			Assert.AreEqual(expectedResult ? 0 : _inputErrors.Length, errors.Length);
		}
		[TestCase(false, true)]
		[TestCase(true, false)]
		public void IsValid_ReturnsFirstError(bool includeErrors, bool expectedResult)
		{
			//Arrange
			var input = GetInput(includeErrors);

			//Test
			var result = InRange<Range_Int64_neg100_1, Int64>.IsValid(values: input, firstError: out Int64 error);

			//Assert
			Assert.AreEqual(expectedResult, result);
			if (!expectedResult)
				Assert.IsNotNull(error);
			else
				Assert.AreEqual(0, error);
		}
		[Test]
		public void Validate_MultipleValues_ThrowsException()
		{
			//Arrange
			var input = GetInput();

			//Test
			Assert.Throws<ArgumentOutOfRangeException>(() => InRange<Range_Int64_neg100_1, Int64>.Validate(values: input));
		}
		[Test]
		public void Validate_MultipleValues_Returns()
		{
			//Arrange
			var input = GetInput(includeErrors: false);

			//Test
			Assert.DoesNotThrow(() => InRange<Range_Int64_neg100_1, Int64>.Validate(values: input));
		}
	}
}

