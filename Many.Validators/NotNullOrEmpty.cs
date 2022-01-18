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

        #region Explicit validation
        /// <summary>
        /// Validates given value and throws an exception in case of failure 
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <exception cref="ArgumentException">Value is empty</exception>
        /// <exception cref="ArgumentNullException">Value is null</exception>
        private static void Validate(string value)
        {
            value.ThrowExceptionIfNull<NotNullOrEmpty, string>();

            if (string.IsNullOrWhiteSpace(value)) //In this point value can not be null because ThrowExceptionIfNull
                throw new ArgumentException(paramName: nameof(value), message: value.GetExceptionMessage<NotNullOrEmpty, string>("must have a value"));
        }

        /// <summary>
        /// Validates given values and throws an exception in case of failure 
        /// </summary>
        /// <param name="values">Values to validate</param>
        /// <exception cref="ArgumentException">Value is empty</exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Validate(string[] values)
            => ValidationExtensions.TryValidateFirst(validation: (s) => Validate(s),
                                                                    throwException: true,
                                                                    out _,
                                                                    values);

        /// <summary>
        /// Tries to validate given values and get first error
        /// </summary>
        /// <param name="values">Values to validate</param>
        /// <param name="firstError">First erroneous value if found</param>
        /// <returns>TRUE if validation is success. FALSE otherwise.</returns>
        public static bool IsValid(string[] values,
                                        out string firstError)
            => ValidationExtensions.TryValidateFirst(validation: (s) => Validate(s),
                                                        throwException: false,
                                                        out firstError,
                                                        values);
        /// <summary>
        /// Tries to validate given values and get all errors
        /// </summary>
        /// <param name="values">Values to validate</param>
        /// <param name="errors">Erroneous values if found</param>
        /// <returns>TRUE if validation is success. FALSE otherwise.</returns>
        public static bool IsValid(string[] values,
                                        out string[] errors)
            => ValidationExtensions.TryValidateAll(validation: (s) => Validate(s),
                                                    out errors,
                                                    values);

        #endregion Explicit validation
    }
}
