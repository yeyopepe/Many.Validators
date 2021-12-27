using Many.Validators.Statics;
using System;

namespace Many.Validators
{
    /// <summary>
    /// Validation type to check if value is null or empty (only non-enumerable types)
    /// For enumerables use <see cref="NotNullOrEmptyArray{TValue}"/>
    /// </summary>
    /// <exception cref="ArgumentException">Value is empty</exception>
    /// <exception cref="ArgumentNullException">Value is null</exception>
    public readonly struct NotNullOrEmpty: IValidator<string>
    {
        /// <inheritdoc/>
        public string Value { get; }

        public NotNullOrEmpty(string value)
        {
            this.Value = value;
            Validate(value);
        }
        /// <inheritdoc/>
        /// <exception cref="ArgumentException">Value is empty</exception>
        /// <exception cref="ArgumentNullException">Value is null</exception>
        private void Validate(string value)
        {
            value.ThrowExceptionIfNull<NotNullOrEmpty, string>();
            
            if (string.IsNullOrWhiteSpace(value)) //In this point value can not be null because ThrowExceptionIfNull
                throw new ArgumentException(paramName: nameof(value), message: value.GetExceptionMessage<NotNullOrEmpty, string>("must have a value"));
        }

        #region Converters and operators
        /// <summary>
        /// Implicit conversion method from string to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator NotNullOrEmpty(string value)
        {
            return new NotNullOrEmpty(value);
        }
        /// <summary>
        /// Implicit conversion method from current to string/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator string(NotNullOrEmpty value)
        {
            value.ThrowExceptionIfNull<NotNullOrEmpty, string>();
            return value.Value;
        }
        public static bool operator ==(object source, NotNullOrEmpty other) => source.Equals(other);
        public static bool operator !=(object source, NotNullOrEmpty other) => !source.Equals(other);
        #endregion Converters and operators

        #region Overrides
        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Value.OverrideEquals<NotNullOrEmpty, string>(obj);
        /// <inheritdoc/>
        public override string ToString() => Value.OverrideToString();
        /// <inheritdoc/>
        public override int GetHashCode() => Value.OverrideGetHashCode();
        #endregion Overrides

       
    }
}
