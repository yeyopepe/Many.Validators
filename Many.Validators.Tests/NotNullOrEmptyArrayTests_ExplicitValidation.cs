using NUnit.Framework;
using System;
using System.Linq;

namespace Many.Validators.Tests
{
	[TestFixture]
	internal partial class NotNullOrEmptyArrayTests
	{
		readonly int?[][] _inputErrors = new int?[][] { new int?[0] , null };
		readonly int?[][] _inputValid = new int?[][] { new int?[] { 1, 5, 234 }, new int?[] { 1,10 } };

		private int?[][] GetInput(bool includeErrors = true)
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
			var result = NotNullOrEmptyArray<int?[]>.IsValid(values: input,
													errors: out int?[][] errors);
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
			var result = NotNullOrEmptyArray<int?[]>.IsValid(values: input,
													firstError: out int?[] error);
			//Assert
			Assert.AreEqual(expectedResult, result);
			if (expectedResult)
				Assert.IsNull(error);
			else
				Assert.AreEqual(_inputErrors.First(), error);
		}
		[Test]
		public void Validate_MultipleValues_ThrowsException()
		{
			//Arrange
			var input = GetInput();

			//Test
			Assert.Throws<ArgumentException>(() => NotNullOrEmptyArray<int?[]>.Validate(values: input));
		}
		[Test]
		public void Validate_MultipleValues_Returns()
		{
			//Arrange
			var input = GetInput(includeErrors: false);

			//Test
			Assert.DoesNotThrow(() => NotNullOrEmptyArray<int?[]>.Validate(values: input));
		}
	}
}

