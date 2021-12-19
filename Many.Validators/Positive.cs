using System;
using System.Linq;

namespace Many.Validators
{
    /// <summary>
    /// Numeric validation type to check if a number is greater than zero
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    /// <see cref="Validate(V)"/>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public readonly struct Positive<V>:IValidator<V>
    {
        /// <inheritdoc/>
        public V Value { get; }

        public Positive(V value)
        {
            this.Value = value;
            Validate(value);
        }
        /// <inheritdoc/>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void Validate(V value)
        {
            value.ThrowExceptionIfNull<Positive<V>, V>();

            var result = false;
            var t = typeof(V);
            if (t.Equals(typeof(Int16)) || t.Equals(typeof(Int16?)))
                result = Int16.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Int32)) || t.Equals(typeof(Int32?)))
                result = Int32.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Int64)) || t.Equals(typeof(Int64?)))
                result = Int64.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(SByte)) || t.Equals(typeof(SByte?)))
                result = SByte.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt16)) || t.Equals(typeof(UInt16?)))
                result = UInt16.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt32)) || t.Equals(typeof(UInt32?)))
                result = UInt32.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt64)) || t.Equals(typeof(UInt64?)))
                result = UInt64.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Byte)) || t.Equals(typeof(Byte?)))
                result = Byte.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Single)) || t.Equals(typeof(Single?)))
                result = Single.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Double)) || t.Equals(typeof(Double?)))
                result = Double.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Decimal)) || t.Equals(typeof(Decimal?)))
                result = Decimal.Parse(value.ToString()) > 0;
#if NET5_0_OR_GREATER
            else if (t.Equals(typeof(Half)) || t.Equals(typeof(Half?)))
                result = Half.Parse(value.ToString()) > (Half)0;
#endif
            else
                throw new ArgumentException(value.GetExceptionMessage<Positive<V>, V>("can not be evaluated because type is not recognized ({t})"));

            if (!result)
                throw new ArgumentOutOfRangeException(value.GetExceptionMessage<Positive<V>, V>("must be greater than zer"));
        }

        #region Converters and operators
        /// <summary>
        /// Implicit conversion method from <see cref="V"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator Positive<V>(V value)
        {
            return new Positive<V>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="V"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator V(Positive<V> value)
        {
            value.ThrowExceptionIfNull<Positive<V>, V>();
            return value.Value;
        }
        public static bool operator ==(object source, Positive<V> other) => source.Equals(other);
        public static bool operator !=(object source, Positive<V> other) => !source.Equals(other);
        #endregion Converters and operators

        #region Overrides
        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Value.OverrideEquals<Positive<V>, V>(obj);
        /// <inheritdoc/>
        public override string ToString() => Value.OverrideToString();
        /// <inheritdoc/>
        public override int GetHashCode() => Value.OverrideGetHashCode();
        #endregion Overrides
    }
}
