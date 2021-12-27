namespace Many.Validators
{
    /// <summary>
    /// Represents a generic validator
    /// </summary>
    /// <typeparam name="TValue">Underlying value type</typeparam>
    public interface IValidator<TValue>: IValidator
    {
        /// <summary>
        /// Gets the value
        /// </summary>
        TValue Value { get; }
    }
}
