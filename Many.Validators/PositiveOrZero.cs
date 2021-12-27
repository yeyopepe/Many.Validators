using Many.Validators.Statics;
using System;
using static Many.Validators.Statics.DynamicObjectsHelper;

namespace Many.Validators
{
    /// <summary>
    /// Numeric validation type to check if a number is greater or equal than zero
    /// </summary>
    /// <typeparam name="TValue">Underlying value type</typeparam>
    /// <exception cref="InvalidCastException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public readonly struct PositiveOrZero<TValue>:IValidator<TValue>
    {
        /// <inheritdoc/>
        public TValue Value { get; }

        public PositiveOrZero(TValue value)
        {
            this.Value = value;
            Validate(value);
        }

        /// <inheritdoc/>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		private void Validate(dynamic value)
        {
            ThrowExceptionIfNull<PositiveOrZero<TValue>, TValue>(value);

            var condition = false;
            try
            {
#if NET5_0_OR_GREATER
                if (value is Half)
                    condition = value >= (Half)0;
                else
#endif
                    condition = value >= 0;
            }
            catch
            {
                throw new InvalidCastException(message: GetExceptionMessageForValidator<PositiveOrZero<TValue>, TValue>(value, "can not be evaluated because type is not recognized ({t})"));
            }

            if (!condition)
                throw new ArgumentOutOfRangeException(paramName: nameof(value), message: GetExceptionMessageForValidator<PositiveOrZero<TValue>, TValue>(value, "must be greater or equal than zero"));
        }

        #region Converters and operators
        /// <summary>
        /// Implicit conversion method from <see cref="TValue"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator PositiveOrZero<TValue>(TValue value)
        {
            return new PositiveOrZero<TValue>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="TValue"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator TValue(PositiveOrZero<TValue> value)
        {
            value.ThrowExceptionIfNull<PositiveOrZero<TValue>, TValue>();
            return value.Value;
        }
        public static bool operator ==(object source, PositiveOrZero<TValue> other) => source.Equals(other);
        public static bool operator !=(object source, PositiveOrZero<TValue> other) => !source.Equals(other);
        #endregion Converters and operators

        #region Overrides
        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Value.OverrideEquals<PositiveOrZero<TValue>, TValue>(obj);
        /// <inheritdoc/>
        public override string ToString() => Value.OverrideToString();
        /// <inheritdoc/>
        public override int GetHashCode() => Value.OverrideGetHashCode();
        #endregion Overrides
    }
}
