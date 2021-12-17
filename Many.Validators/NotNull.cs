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
        public NotNull(T value) : base(value)
        {
        }

        /// <summary>
        /// Implicit conversion method from <see cref="T"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator NotNull<T>(T value)
        {
            return new NotNull<T>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="T"/>
        /// </summary>
        /// <param name="value">Current value</param>
        public static implicit operator T(NotNull<T> value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            return value.Value;
        }

        /// <see cref="ValidatorTypeBase.Validation(T)"/>
        protected override void Validation(T value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
        }
    }
}
