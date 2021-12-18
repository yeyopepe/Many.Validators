using System;

namespace Many.Validators.HiddenDrafts
{
    //TODO: Unfinished
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="V"></typeparam>
    /// <typeparam name="R"></typeparam>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    internal sealed class InRange<V, R> : ValidatorTypeBase<V>
        where R: IRange<V>
    {
        public InRange(V value) : base(value)
        {
            //Nothing to do
        }

        /// <summary>
        /// Implicit conversion method from <see cref="V"/> to current
        /// </summary>
        /// <param name="value">Underlying value</param>
        public static implicit operator InRange<V,R>(V value)
        {
            return new InRange<V,R>(value);
        }
        /// <summary>
        /// Implicit conversion method from current to <see cref="V"/>
        /// </summary>
        /// <param name="value">Current value</param>
        public static implicit operator V(InRange<V,R> value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            return value.Value;
        }

        protected override void Validate(V value)
        {
            var ranges = default(R);
            if (!ranges.Validate(value))
            {
                (RangeCondition minCondition, V min) = ranges.Min;
                (RangeCondition maxCondition, V max) = ranges.Max;
                throw new ArgumentOutOfRangeException($"Value {value} must be between: {min},{minCondition} and {max},{maxCondition}");
            }
                
        }
    }
}
