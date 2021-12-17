namespace Many.Validators
{
    /// <summary>
    /// Non-validations type
    /// </summary>
    /// <typeparam name="T">Underlying value type</typeparam>
    internal sealed class None<T>: ValidatorTypeBase<T>
    {
        public None(T value):base(value)
        {
        }

        /// <summary>
        /// Implicit conversion method from <see cref="T"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator None<T>(T value)
        {
            return new None<T>(value);
        }

    }
}
