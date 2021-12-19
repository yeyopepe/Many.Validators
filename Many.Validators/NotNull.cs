using System;

namespace Many.Validators
{
    /// <summary>
    /// Validation type to check if value is not null
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    /// <exception cref="ArgumentNullException"></exception>
    public sealed class NotNull<V>
    {
        /// <summary>
        /// Gets the value
        /// </summary>
        public V Value { get; private set; }
        public NotNull(V value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

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
#if NET5_0_OR_GREATER
            return value.Value ?? throw new ArgumentNullException(nameof(value));
#else
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            return value.Value;
#endif

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

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Value != null ?
                Value.ToString() :
                String.Empty;
        }
        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return Value != null ?
                Value.GetHashCode() :
                0;
        }
    }
}
