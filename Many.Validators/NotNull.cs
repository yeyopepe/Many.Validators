using System;

namespace Many.Validators
{
    /// <summary>
    /// Validation type to check if value is not null
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    /// <exception cref="ArgumentNullException"></exception>
    public sealed class NotNull<V>:BaseClass<V>
    {
        public NotNull(V value)
        {
            ThrowExceptionIfNull(value);
            this.Value = value;
        }

        /// <summary>
        /// Implicit conversion method from <see cref="V"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator NotNull<V>(V value)
        {
            return new NotNull<V>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="V"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator V(NotNull<V> value)
        {
            ThrowExceptionIfNull(value);
            return value.Value;
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
                !(obj is NotNull<V>))
                return false;
            else
                comparison = this.Value?.Equals(((NotNull<V>)obj).Value);

            return comparison.HasValue && comparison.Value;
        }

        public static bool operator ==(object source, NotNull<V> other)
        {
            return source.Equals(other);
        }
        public static bool operator !=(object source, NotNull<V> other)
        {
            return !source.Equals(other);
        }
     
    }
}
