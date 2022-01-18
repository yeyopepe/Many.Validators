using NUnit.Framework;
using System;
using System.Linq;

namespace Many.Validators.Tests
{
	[TestFixture]
	internal partial class NotNullOrEmptyTests
	{
		readonly string[] _inputErrors = new string[] { null, "" };
		readonly string[] _inputValid = new string[] { "1", "5", "234" };

		private string[] GetInput(bool includeErrors = true)
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
			var result = NotNullOrEmpty.IsValid(values: input,
													errors: out string[] errors);
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
			var result = NotNullOrEmpty.IsValid(values: input,
													firstError: out string error);
			//Assert
			Assert.AreEqual(expectedResult, result);
			Assert.IsNull(error);
		}
		[Test]
		public void Validate_MultipleValues_ThrowsException()
		{
			//Arrange
			var input = GetInput();

			//Test
			Assert.Throws<ArgumentNullException>(() => NotNullOrEmpty.Validate(values: input));
		}
		[Test]
		public void Validate_MultipleValues_Returns()
		{
			//Arrange
			var input = GetInput(includeErrors: false);

			//Test
			Assert.DoesNotThrow(() => NotNullOrEmpty.Validate(values: input));
		}
	}
}

