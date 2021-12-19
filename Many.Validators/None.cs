using System;

namespace Many.Validators
{
    /// <summary>
    /// Non-validations type. Only for test porpuse
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    internal class None<V>:BaseClass<V>
    {
        public None(V value)
        {
            //Nothing to do
        }

        /// <summary>
        /// Implicit conversion method from <see cref="V"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator None<V>(V value)
        {
            return new None<V>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="V"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator V(None<V> value)
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
                !(obj is None<V>))
                return false;
            else
                comparison = this.Value?.Equals(((None<V>)obj).Value);

            return comparison.HasValue && comparison.Value;
        }

        public static bool operator ==(object source, None<V> other)
        {
            return source.Equals(other);
        }
        public static bool operator !=(object source, None<V> other)
        {
            return !source.Equals(other);
        }
       
    }
}
