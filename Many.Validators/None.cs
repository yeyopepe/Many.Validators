using System;

namespace Many.Validators
{
    /// <summary>
    /// Non-validations type. Only for test porpuse
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    internal class None<V>: ValidatorTypeBase<V>
    {
        public None(V value):base(value)
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
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            return value.Value;
        }

        /// <inheritdoc/>
        protected override void Validate(V value)
        {
            //Nothing to do
        }
    }
}
