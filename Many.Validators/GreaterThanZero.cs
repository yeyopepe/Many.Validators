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
    public sealed class GreaterThanZero<V>: ValidatorTypeBase<V>
    {
        public GreaterThanZero(V value) : base(value)
        {
            //Nothing to do
        }

        /// <summary>
        /// Implicit conversion method from <see cref="V"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator GreaterThanZero<V>(V value)
        {
            return new GreaterThanZero<V>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="V"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator V(GreaterThanZero<V> value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            return value.Value;
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected override void Validate(V value)
        {
            base.Validate(value);

            var result = false;
            var t = typeof(V);
            if (t.Equals(typeof(Int16)))
                result = Int16.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Int32)))
                result = Int32.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Int64)))
                result = Int64.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(SByte)))
                result = SByte.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt16)))
                result = UInt16.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt32)))
                result = UInt32.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(UInt64)))
                result = UInt64.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Byte)))
                result = Byte.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Single)))
                result = Single.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Double)))
                result = Double.Parse(value.ToString()) > 0;
            else if (t.Equals(typeof(Decimal)))
                result = Decimal.Parse(value.ToString()) > 0;
#if NET5_0_OR_GREATER
            else if (t.Equals(typeof(Half)))
                result = Half.Parse(value.ToString()) > (Half)0;
#endif
            else
                throw new ArgumentException($"Value {value} can not be evaluated because type is not recognized ({t})");

            if (!result)
                throw new ArgumentOutOfRangeException($"Value {value} must be greater than zero.");
        }

    }
}
