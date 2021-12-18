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
        public static implicit operator V(NotNull<V> value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            return value.Value;
        }

        /// <inheritdoc/>
        protected override void Validate(V value)
        {
            base.Validate(value); //Same validation as base
        }
    }
}
