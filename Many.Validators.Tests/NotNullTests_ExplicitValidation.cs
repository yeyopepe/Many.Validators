using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Many.Validators.Tests
{
	[TestFixture]
	internal partial class NotNullTests
	{
		[TestCase(false, true)]
		[TestCase(true, false)]
		public void TryValidate_ReturnsFirstError(bool includeErrors, bool expectedResult)
		{
			//Arrange
			var errorsInput = new string[] { null, null };
			var validInput = new string[] { "1", "5", "234" };
			var input = validInput;
			if (includeErrors)
				input = input.Concat(errorsInput).ToArray();

			//Test
			var result = NotNull<string>.TryValidate(values: input,
													errors: out string[] errors);
			//Assert
			Assert.AreEqual(expectedResult, result);
			Assert.AreEqual(expectedResult ? 0 : errorsInput.Length, errors.Length);
		}
		[TestCase(false, true)]
		[TestCase(true, false)]
		public void TryValidate_ReturnsAllErrors(bool includeErrors, bool expectedResult)
		{
			//Arrange
			var errorsInput = new string[] { null, null };
			var validInput = new string[] { "1", "5", "234" };
			var input = validInput;
			if (includeErrors)
				input = input.Concat(errorsInput).ToArray();
			
			//Test
			var result = NotNull<string>.TryValidate(values: input,
													firstError: out string error);
			//Assert
			Assert.AreEqual(expectedResult, result);
			if (!expectedResult)
				Assert.IsNotEmpty(error);
			else
				Assert.IsNull(error);
		}
		[Test]
		public void Validate_MultipleValues_ThrowsException()
		{
			//Arrange
			var errorsInput = new string[] { null, null };
			var validInput = new string[] { "1", "5", "234" };
			var input = validInput.Concat(errorsInput).ToArray();

			//Test
			Assert.Throws<ArgumentNullException>(() => NotNull<string>.Validate(values: input));
		}
		[Test]
		public void Validate_MultipleValues_Returns()
		{
			//Arrange
			var validInput = new string[] { "1", "5", "234" };

			//Test
			Assert.DoesNotThrow(() => NotNull<string>.Validate(values: validInput));
		}
	}
}

