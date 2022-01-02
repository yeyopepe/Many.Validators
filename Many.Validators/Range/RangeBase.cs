using System;
using static Many.Validators.Statics.DynamicObjectsHelper;

namespace Many.Validators.Range
{
	/// <summary>
	/// Represents a range for <see cref="TValue"/> values
	/// </summary>
	/// <typeparam name="TValue">Underlying value type</typeparam>
	public abstract class RangeBase<TValue>
	{
		/// <summary>
		/// Gets the minimum value of the range (exclusive)
		/// </summary>
		public abstract TValue Min { get; }
		/// <summary>
		/// Gets the maximum value of the range (inclusive)
		/// </summary>
		public abstract TValue Max { get; }

		/// <summary>
		/// Checks if given value is valid for range
		/// </summary>
		/// <param name="value"></param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public void Validate(dynamic value)
		{
			if (value <= Min ||
				value > Max)
			{
				throw new ArgumentOutOfRangeException(paramName: nameof(value), message: GetExceptionMessageaForRange<TValue>(this.GetType(), value, $"must be  >{Min} and <={Max}"));
			}
		}
	}
}
