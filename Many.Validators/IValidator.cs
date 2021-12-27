namespace Many.Validators
{
    /// <summary>
    /// Represents a validator
    /// </summary>
    public interface IValidator
    {
        bool Equals(object obj);
        string ToString();
        int GetHashCode();
    }
}
