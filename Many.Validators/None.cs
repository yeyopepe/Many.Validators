using System;

namespace Many.Validators
{
    /// <summary>
    /// Non-validations type
    /// </summary>
    /// <typeparam name="T">Underlying value type</typeparam>
    public sealed class None<T>: ValidatorTypeBase<T>
    {
        public None(T value):base(value)
        {
        }

        /// <see cref="ValidatorTypeBase.Validation(T)"/>
        protected override void Validation(T value)
        {
            //Nothing to do
        }

        /// <summary>
        /// Implicit conversion method from <see cref="T"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator None<T>(T value)
        {
            return new None<T>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="T"/>
        /// </summary>
        /// <param name="value">Current value</param>
        public static implicit operator T(None<T> value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            return value.Value;
        }
    }
}
