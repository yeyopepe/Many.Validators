using Many.Validators.Statics;
using System;

namespace Many.Validators
{
    /// <summary>
    /// Validation type to check if value is not null
    /// </summary>
    /// <typeparam name="TValue">Underlying value type</typeparam>
    /// <exception cref="ArgumentNullException"></exception>
    public readonly struct NotNull<TValue>: IValidator<TValue>
    {
        /// <inheritdoc/>
        public TValue Value { get; }

        public NotNull(TValue value)
        {
            this.Value = value;
            value.ThrowExceptionIfNull<NotNull<TValue>, TValue>();
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

        #region Explicit methods
        public static void Validate(params TValue[] values)
        {
            throw new NotImplementedException();
        }
        #endregion Explicit methods
    }
}
