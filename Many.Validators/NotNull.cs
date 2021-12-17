using System;

namespace Many.Validators
{
    /// <summary>
    /// Validation type for non-null values
    /// </summary>
    /// <typeparam name="T">Underlying value type</typeparam>
    /// <exception cref="ArgumentNullException"></exception>
    public sealed class NotNull<T>: ValidatorTypeBase<T>
    {
        public NotNull(T value):base(value)
        {
            if (value == null)
                throw new ArgumentNullException();
        }

        /// <summary>
        /// Implicit conversion method from <see cref="T"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator NotNull<T>(T value)
        {
            return new NotNull<T>(value);
        }
    }
}
