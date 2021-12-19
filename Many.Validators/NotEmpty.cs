using System;

namespace Many.Validators
{
    /// <summary>
    /// Validation type to check if value is set (not null) but is empty
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    public readonly struct NotEmpty: IValidator<string>
    {
        /// <inheritdoc/>
        public string Value { get; }

        public NotEmpty(string value)
        {
            this.Value = value;
            Validate(value);
        }
        /// <inheritdoc/>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        private void Validate(string value)
        {
            value.ThrowExceptionIfNull<Negative<string>, string>();
            
            if (string.IsNullOrWhiteSpace(value)) //In this point value can not be null because ThrowExceptionIfNull
                throw new ArgumentException(value.GetExceptionMessage<NotEmpty, string>("must have a value"));
        }

        #region Converters and operators
        /// <summary>
        /// Implicit conversion method from string to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator NotEmpty(string value)
        {
            return new NotEmpty(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="V"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator string(NotEmpty value)
        {
            value.ThrowExceptionIfNull<NotEmpty, string>();
            return value.Value;
        }
        public static bool operator ==(object source, NotEmpty other) => source.Equals(other);
        public static bool operator !=(object source, NotEmpty other) => !source.Equals(other);
        #endregion Converters and operators

        #region Overrides
        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Value.OverrideEquals<NotEmpty, string>(obj);
        /// <inheritdoc/>
        public override string ToString() => Value.OverrideToString();
        /// <inheritdoc/>
        public override int GetHashCode() => Value.OverrideGetHashCode();
        #endregion Overrides

       
    }
}
