using System;

namespace Many.Validators
{
    /// <summary>
    /// Validation type to check if value is not null
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    /// <exception cref="ArgumentNullException"></exception>
    public sealed class NotNull<V>: ValidatorTypeBase<V>
    {
        public NotNull(V value) : base(value)
        {
            //Nothing to do
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
            value.ThrowExceptionIfNull();
            return value.Value;
#endif

        }

        //Same validation as base. No override needed
    }
}
