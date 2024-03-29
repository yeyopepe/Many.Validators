﻿using NUnit.Framework;
using System;
using System.Linq;

namespace Many.Validators.Tests
{
	[TestFixture]
	internal partial class NotNullTests
	{
		readonly int?[] _inputErrors = new int?[] { null, null };
		readonly int?[] _inputValid = new int?[] { 1, 5, 234, -100 };

		private int?[] GetInput(bool includeErrors = true)
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
			var result = NotNull<int?>.IsValid(values: input,
													errors: out int?[] errors);
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
			var result = NotNull<int?>.IsValid(values: input,
													firstError: out int? error);
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
			Assert.Throws<ArgumentNullException>(() => NotNull<int?>.Validate(values: input));
		}
		[Test]
		public void Validate_MultipleValues_Returns()
		{
			//Arrange
			var input = GetInput(includeErrors: false);

			//Test
			Assert.DoesNotThrow(() => NotNull<int?>.Validate(values: input));
		}
	}
}

