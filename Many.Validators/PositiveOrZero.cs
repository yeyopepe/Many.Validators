﻿using System;

namespace Many.Validators
{
    /// <summary>
    /// Numeric validation type to check if a number is greater or equal than zero
    /// </summary>
    /// <typeparam name="TValue">Underlying value type</typeparam>
    /// <see cref="Validate(TValue)"/>
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
        private void Validate(TValue value)
        {
            value.ThrowExceptionIfNull<PositiveOrZero<TValue>, TValue>();

            var result = false;
            var t = typeof(TValue);
            if (t.Equals(typeof(Int16)) || t.Equals(typeof(Int16?)))
                result = Int16.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(Int32)) || t.Equals(typeof(Int32?)))
                result = Int32.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(Int64)) || t.Equals(typeof(Int64?)))
                result = Int64.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(SByte)) || t.Equals(typeof(SByte?)))
                result = SByte.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(UInt16)) || t.Equals(typeof(UInt16?)))
                result = UInt16.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(UInt32)) || t.Equals(typeof(UInt32?)))
                result = UInt32.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(UInt64)) || t.Equals(typeof(UInt64?)))
                result = UInt64.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(Byte)) || t.Equals(typeof(Byte?)))
                result = Byte.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(Single)) || t.Equals(typeof(Single?)))
                result = Single.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(Double)) || t.Equals(typeof(Double?)))
                result = Double.Parse(value.ToString()) >= 0;
            else if (t.Equals(typeof(Decimal)) || t.Equals(typeof(Decimal?)))
                result = Decimal.Parse(value.ToString()) >= 0;
#if NET5_0_OR_GREATER
            else if (t.Equals(typeof(Half)) || t.Equals(typeof(Half?)))
                result = Half.Parse(value.ToString()) >= (Half)0;
#endif
            else
                throw new InvalidCastException(value.GetExceptionMessage<PositiveOrZero<TValue>, TValue>("can not be evaluated because type is not recognized ({t})"));

            if (!result)
                throw new ArgumentOutOfRangeException(value.GetExceptionMessage<PositiveOrZero<TValue>, TValue>("must be greater or equal than zero"));
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