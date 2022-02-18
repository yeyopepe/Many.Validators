using Many.Validators.Statics;
using System;

namespace Many.Validators.Clauses.S3
{
    /// <summary>
    /// Represent a validations' concatenator
    /// </summary>
    /// <typeparam name="TValue">Underlying type</typeparam>
    /// <typeparam name="V1">First validator type</typeparam>
    /// <typeparam name="V2">Second validator type</typeparam>
    /// <typeparam name="V3">Third validator type</typeparam>
    public readonly struct All<V1, V2, V3, TValue>
        where V1 : IValidator<TValue>
        where V2 : IValidator<TValue>
        where V3 : IValidator<TValue>
    {


        /// <inheritdoc/>V1
        public TValue Value { get; }

        public All(TValue value)
        {
            this.Value = value;
            Validate(value);
        }

        #region Converters and operators
        /// <summary>
        /// Implicit conversion method from <see cref="TValue"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator All<V1, V2, V3, TValue>(TValue value) => new All<V1, V2, V3, TValue> (value);

        /// <summary>
        /// Implicit conversion method from current to <see cref="TValue"/>
        /// </summary>
        /// <param name="value">Current value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static implicit operator TValue(All<V1, V2, V3, TValue> value) => value.Value;
        
        public static bool operator ==(object source, All<V1, V2, V3, TValue> other) => source.Equals(other);
        public static bool operator !=(object source, All<V1, V2, V3, TValue> other) => !source.Equals(other);
        #endregion Converters and operators

        #region Overrides
        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            bool? comparison;
            if (obj is TValue)
                comparison = this.Value?.Equals(((TValue)obj));
            else if (obj == null && this.Value == null)
                return true;
            else if (obj == null ||
                !(obj is All<V1, V2, V3, TValue>))
                return false;
            else
                comparison = this.Equals(((All<V1, V2, V3, TValue>)obj).Value);

            return comparison.HasValue && comparison.Value;
        }
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
        /// <exception cref="ArgumentNullException"></exception>
        private static void Validate(TValue value)
		{
            try
            {
                Activator.CreateInstance(typeof(V1), new object[] { value });
                Activator.CreateInstance(typeof(V2), new object[] { value });
                Activator.CreateInstance(typeof(V3), new object[] { value });
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        #endregion Explicit validation
    }
}
