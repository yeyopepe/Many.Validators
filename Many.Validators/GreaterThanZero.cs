﻿using System;
using System.Linq;

namespace Many.Validators
{
    /// <summary>
    /// Numeric validation type to check if a number is greater than zero
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    /// <see cref="Validate(V)"/>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public sealed class GreaterThanZero<V>:BaseClass<V>
    {
        public GreaterThanZero(V value)
        {
            Validate(value);
            Value = value;
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
            ThrowExceptionIfNull(value);
            return value.Value;
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void Validate(V value)
        {
            ThrowExceptionIfNull(value);

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


        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            bool? comparison;
            if (obj is V)
                comparison = this.Value?.Equals(((V)obj));
            else if (obj == null ||
                !(obj is GreaterThanZero<V>))
                return false;
            else
                comparison = this.Value?.Equals(((GreaterThanZero<V>)obj).Value);

            return comparison.HasValue && comparison.Value;
        }

        public static bool operator ==(object source, GreaterThanZero<V> other)
        {
            return source.Equals(other);
        }
        public static bool operator !=(object source, GreaterThanZero<V> other)
        {
            return !source.Equals(other);
        }
      
    }
}
