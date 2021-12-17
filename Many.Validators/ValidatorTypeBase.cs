using System;

namespace Many.Validators
{
    /// <summary>
    /// Base type for validators
    /// </summary>
    /// <typeparam name="T">Underlying value type</typeparam>
    public abstract class ValidatorTypeBase<T>
    {
        /// <summary>
        /// Gets the value
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="value">Value</param>
        protected ValidatorTypeBase(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null ||
                !(obj is ValidatorTypeBase<T>))
                return false;

            var comparison = this.Value?.Equals(((ValidatorTypeBase<T>)obj).Value);
            if (!comparison.HasValue)
                return false;

            return comparison.Value;
        }

        public static bool operator ==(object source, ValidatorTypeBase<T> other)
        {
            return source.Equals(other);
        }
        public static bool operator !=(object source, ValidatorTypeBase<T> other)
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
