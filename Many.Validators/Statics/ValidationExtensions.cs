using System;
using System.Collections.Generic;
using System.Linq;

namespace Many.Validators.Statics
{
	internal static class ValidationExtensions
	{
		/// <summary>
		/// Tries to validate all values
		/// </summary>
		/// <param name="validation">Validation function</param>
		/// <param name="errors">Erroneous values if found</param>
		/// <param name="values">Values to validate</param>
		/// <returns>TRUE if validation is success. FALSE if validation fails.</returns>
		public static bool TryValidateAll<TValue>(Action<TValue> validation,
													out TValue[] errors,
													params TValue[] values)
		{
			errors = new TValue[0];
			if (values != null &&
				values.Any())
			{
				var errFound = new List<TValue>(values.Length);
				for (int i = 0; i < values.Length; i++)
				{
					try
					{
						validation(values[i]);
					}
					catch
					{
						errFound.Add(values[i]);
					}
				}

				errors = errFound.ToArray();
			}

			return !errors.Any();
		}
		/// <summary>
		/// Tries to validate values
		/// </summary>
		/// <param name="validation">Validation function</param>
		/// <param name="throwException">TRUE if an exception must be thrown when a validation fails. FALSE otherwise.</param>
		/// <param name="error">Erroneous value</param>
		/// <param name="values">Values to validate</param>
		/// <returns>TRUE if validation is success. FALSE if validation fails and <paramref name="throwException"/> is false.</returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static bool TryValidateFirst<TValue>(Action<TValue> validation,
													bool throwException,
													out TValue error,
													params TValue[] values)
		{

			for (int i = 0; i < values?.Length; i++)
			{
				try
				{
					validation(values[i]);
				}
				catch
				{
					if (throwException)
						throw;

					error = values[i];
					return false;
				}
			}
			error = default(TValue);
			return true;
		}
	}
}
