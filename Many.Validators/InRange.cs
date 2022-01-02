using Many.Validators.Range;
using Many.Validators.Statics;
using System;
using static Many.Validators.Statics.DynamicObjectsHelper;

namespace Many.Validators
{
    /// <summary>
    /// Numeric validation type to check if a number is lower than zero
    /// </summary>
    /// <typeparam name="TRange">Range type</typeparam>
    /// <typeparam name="TValue">Underlying value type</typeparam>
    /// <exception cref="InvalidCastException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public readonly struct InRange<TRange, TValue> : IValidator<TValue>
        where TRange : RangeBase<TValue>
    {
        /// <inheritdoc/>
        public TValue Value { get; }

        public InRange(TValue value)
        {
            this.Value = value;
            Validate(value);
        }
        /// <inheritdoc/>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		private void Validate(TValue value)
        {
            ThrowExceptionIfNull<InRange<TRange,TValue>, TValue>(value);

            var ranges = Activator.CreateInstance<TRange>();
			ranges.Validate(value);           
        }

        #region Converters and operators
        /// <summary>
        /// Implicit conversion method from <see cref="TValue"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator InRange<TRange, TValue>(TValue value)
        {
            return new InRange<TRange, TValue>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="TValue"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator TValue(InRange<TRange, TValue> value)
        {
            value.ThrowExceptionIfNull<InRange<TRange, TValue>, TValue>();
            return value.Value;
        }
        public static bool operator ==(object source, InRange<TRange, TValue> other) => source.Equals(other);
        public static bool operator !=(object source, InRange<TRange, TValue> other) => !source.Equals(other);
        #endregion Converters and operators

        #region Overrides
        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Value.OverrideEquals<InRange<TRange, TValue>, TValue>(obj);
        /// <inheritdoc/>
        public override string ToString() => Value.OverrideToString();
        /// <inheritdoc/>
        public override int GetHashCode() => Value.OverrideGetHashCode();
        #endregion Overrides
    }
}
