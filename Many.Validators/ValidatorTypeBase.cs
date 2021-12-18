using System;

namespace Many.Validators
{
    /// <summary>
    /// Base type for validators
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    public abstract class ValidatorTypeBase<V>
    {
        /// <summary>
        /// Gets the value
        /// </summary>
        public V Value { get; private set; }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="value">Value</param>
        public ValidatorTypeBase(V value)
        {
            Validate(value);
            this.Value = value;
        }

        /// <summary>
        /// Validates given value
        /// </summary>
        /// <param name="value">Value</param>
        /// <exception cref="ArgumentNullException">When value is null</exception>
        protected virtual void Validate(V value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
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
                !(obj is ValidatorTypeBase<V>))
                return false;
            else
                comparison = this.Value?.Equals(((ValidatorTypeBase<V>)obj).Value);

            return comparison.HasValue && comparison.Value;
        }

        public static bool operator ==(object source, ValidatorTypeBase<V> other)
        {
            return source.Equals(other);
        }
        public static bool operator !=(object source, ValidatorTypeBase<V> other)
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
