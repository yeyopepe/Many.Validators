using Many.Validators.Statics;
using System;
using System.Collections;
using static Many.Validators.Statics.DynamicObjectsHelper;

namespace Many.Validators
{
    /// <summary>
    /// Validation type to check if value is null or empty
    /// </summary>
    /// <typeparam name="TValue">Underlying value type</typeparam>
    /// <exception cref="ArgumentException">Value is empty</exception>
    /// <exception cref="ArgumentNullException">Value is null</exception>
    public readonly struct NotNullOrEmptyArray<TValue>: IValidator<TValue>
        where TValue : IEnumerable
    {
        /// <inheritdoc/>
        public TValue Value { get; }

		public NotNullOrEmptyArray(TValue value)
        {
            this.Value = value;
            Validate(value);
        }
        /// <inheritdoc/>
        /// <exception cref="ArgumentException">Value is empty</exception>
        /// <exception cref="ArgumentNullException">Value is null</exception>
        private void Validate(TValue value)
        {
            ThrowExceptionIfNull<NotNullOrEmptyArray<TValue>, TValue>(value);
            
            if (!value.GetEnumerator().MoveNext()) 
                throw new ArgumentException(paramName: nameof(value), message: value.GetExceptionMessage<NotNullOrEmptyArray<TValue>, TValue>("must not be empty"));
        }

        #region Converters and operators
        /// <summary>
        /// Implicit conversion method from string to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator NotNullOrEmptyArray<TValue>(TValue value)
        {
            return new NotNullOrEmptyArray<TValue>(value);
        }
        /// <summary>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator TValue(NotNullOrEmptyArray<TValue> value)
        {
            ThrowExceptionIfNull<NotNullOrEmptyArray<TValue>, TValue>(value);
            return value.Value;
        }
        public static bool operator ==(object source, NotNullOrEmptyArray<TValue> other) => other.Value.OverrideIEnumerableEquals<NotNullOrEmptyArray<TValue>, TValue>(source);
        public static bool operator !=(object source, NotNullOrEmptyArray<TValue> other) => !other.Value.OverrideIEnumerableEquals<NotNullOrEmptyArray<TValue>, TValue>(source);

        #endregion Converters and operators

        #region Overrides
        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Value.OverrideIEnumerableEquals<NotNullOrEmptyArray<TValue>, TValue>(obj);
        /// <inheritdoc/>
        public override string ToString() => Value.OverrideToString();
        /// <inheritdoc/>
        public override int GetHashCode() => Value.OverrideGetHashCode();
        #endregion Overrides

       
    }
}
