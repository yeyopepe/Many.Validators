using System;

namespace Many.Validators
{
    /// <summary>
    /// Validation type to check if value is not null
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    /// <exception cref="ArgumentNullException"></exception>
    public readonly struct NotNull<V>: IValidator<V>
    {
        /// <inheritdoc/>
        public V Value { get; }

        public NotNull(V value)
        {
            value.ThrowExceptionIfNull<NotNull<V>, V>();
            this.Value = value;
        }

        /// <summary>
        /// Implicit conversion method from <see cref="V"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator NotNull<V>(V value)
        {
            return new NotNull<V>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="V"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator V(NotNull<V> value)
        {
            value.ThrowExceptionIfNull<NotNull<V>, V>();
            return value.Value;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Value.OverrideEquals<NotNull<V>, V>(obj);
        public static bool operator ==(object source, NotNull<V> other) => source.Equals(other);
        public static bool operator !=(object source, NotNull<V> other) => !source.Equals(other);
        /// <inheritdoc/>
        public override string ToString() => Value.OverrideToString();
        /// <inheritdoc/>
        public override int GetHashCode() => Value.OverrideGetHashCode();
    }
}
