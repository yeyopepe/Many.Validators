namespace Many.Validators
{
    /// <summary>
    /// Represents a validator
    /// </summary>
    /// <typeparam name="TValue">Underlying value type</typeparam>
    public interface IValidator<TValue>
    {
        /// <summary>
        /// Gets the value
        /// </summary>
        TValue Value { get; }
    }
}
