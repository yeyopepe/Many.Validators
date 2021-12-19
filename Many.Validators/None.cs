using System;

namespace Many.Validators
{
    //TODO: REmove???
    /// <summary>
    /// Non-validations type. Only for test porpuse
    /// </summary>
    /// <typeparam name="V">Underlying value type</typeparam>
    internal readonly struct None<V>: IValidator<V>
    {
        /// <inheritdoc/>
        public V Value { get; }

        public None(V value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Implicit conversion method from <see cref="V"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator None<V>(V value)
        {
            return new None<V>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="V"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator V(None<V> value)
        {
            value.ThrowExceptionIfNull<None<V>, V>();
            return value.Value;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Value.OverrideEquals<None<V>, V>(obj);
        public static bool operator ==(object source, None<V> other) => source.Equals(other);
        public static bool operator !=(object source, None<V> other) => !source.Equals(other);
        /// <inheritdoc/>
        public override string ToString() => Value.OverrideToString();
        /// <inheritdoc/>
        public override int GetHashCode() => Value.OverrideGetHashCode();
    }
}
