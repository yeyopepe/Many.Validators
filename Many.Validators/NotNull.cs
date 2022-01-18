using Many.Validators.Statics;
using System;

namespace Many.Validators
{
	/// <summary>
	/// Validation type to check if value is not null
	/// </summary>
	/// <typeparam name="TValue">Underlying value type</typeparam>
	/// <exception cref="ArgumentNullException"></exception>
	public readonly struct NotNull<TValue> : IValidator<TValue>
	{
		/// <inheritdoc/>
		public TValue Value { get; }

		public NotNull(TValue value)
		{
			this.Value = value;
			Validate(value);
		}

		#region Converters and operators
		/// <summary>
		/// Implicit conversion method from <see cref="TValue"/> to current
		/// </summary>
		/// <param name="value">Underlying value</param>
		public static implicit operator NotNull<TValue>(TValue value)
		{
			return new NotNull<TValue>(value);
		}
		/// <summary>
		/// Implicit conversion method from current to <see cref="TValue"/>
		/// </summary>
		/// <param name="value">Current value</param>
		/// <exception cref="ArgumentNullException"></exception>
		public static implicit operator TValue(NotNull<TValue> value)
		{
			value.ThrowExceptionIfNull<NotNull<TValue>, TValue>();
			return value.Value;
		}
		public static bool operator ==(object source, NotNull<TValue> other) => source.Equals(other);
		public static bool operator !=(object source, NotNull<TValue> other) => !source.Equals(other);
		#endregion Converters and operators

		#region Overrides
		/// <inheritdoc/>
		public override bool Equals(object obj) => this.Value.OverrideEquals<NotNull<TValue>, TValue>(obj);
		/// <inheritdoc/>
		public override string ToString() => Value.OverrideToString();
		/// <inheritdoc/>
		public override int GetHashCode() => Value.OverrideGetHashCode();
		#endregion Overrides

		#region Explicit validation
		/// <summary>
		/// Validates given value and throws an exception in case of failure 
		/// </summary>
		/// <param name="value">Value to validate</param>
		/// <exception cref="ArgumentNullException"></exception>
		private static void Validate(TValue value)
			=> value.ThrowExceptionIfNull<NotNull<TValue>, TValue>();

		/// <summary>
		/// Validates given values and throws an exception in case of failure
		/// </summary>
		/// <param name="values">Values to validate</param>
		/// <exception cref="ArgumentNullException"></exception>
		public static void Validate(TValue[] values)
			=> ValidationExtensions.TryValidateFirst(validation: (s) => Validate(s),
																	throwException: true,
																	out _,
																	values);

		/// <summary>
		/// Tries to validate given values and get first error
		/// </summary>
		/// <param name="values">Values to validate</param>
		/// <param name="firstError">First erroneous value if found</param>
		/// <returns>TRUE if validation is success. FALSE otherwise.</returns>
		public static bool IsValid(TValue[] values,
										out TValue firstError)
			=> ValidationExtensions.TryValidateFirst(validation: (s) => Validate(s),
														throwException: false,
														out firstError,
														values);
		/// <summary>
		/// Tries to validate given values and get all errors
		/// </summary>
		/// <param name="values">Values to validate</param>
		/// <param name="errors">Erroneous values if found</param>
		/// <returns>TRUE if validation is success. FALSE otherwise.</returns>
		public static bool IsValid(TValue[] values,
										out TValue[] errors)
			=> ValidationExtensions.TryValidateAll(validation: (s) => Validate(s),
													out errors,
													values);

		#endregion Explicit validation
	}
}
