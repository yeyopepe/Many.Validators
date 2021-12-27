using System.Collections;

namespace Many.Validators.Statics
{
	internal static class EqualsExtensions
	{
        /// <summary>
        /// Overrides validator's Equals() method
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <param name="obj"></param>
        /// <returns>True if the objects are considered equal; otherwise, false. 
        /// If both value and objB are null, the method returns true.</returns>
        public static bool OverrideEquals<TValidator, TValue>(this TValue value, object obj)
            where TValidator : IValidator<TValue>
        {
            bool? comparison;
            if (obj is TValue)
                comparison = value?.Equals(((TValue)obj));
            else if (obj == null && value == null)
                return true;
            else if (obj == null ||
                !(obj is TValidator))
                return false;
            else
                comparison = value?.Equals(((TValidator)obj).Value);

            return comparison.HasValue && comparison.Value;
        }

        /// <summary>
        /// Overrides validator's Equals() method for IEnumerable values
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <param name="obj"></param>
        /// <returns>True if the objects are considered equal; otherwise, false. 
        /// If both value and objB are null, the method returns true.</returns>
        public static bool OverrideIEnumerableEquals<TValidator, TValue>(this TValue value, object obj)
            where TValidator : IValidator<TValue>
        {
            if (obj is IValidator &&
                 value != null)
            {
                var objIEnumerable = (IEnumerable)((TValidator)obj).Value;
                var objEnumerator = objIEnumerable.GetEnumerator();
                var valueEnumerator = ((IEnumerable)value).GetEnumerator();
                objEnumerator.Reset();
                valueEnumerator.Reset();
                var result = true;
                while (result &&
                        objEnumerator.MoveNext() &&
                        valueEnumerator.MoveNext())
                {
                    if (!objEnumerator.Current.Equals(valueEnumerator.Current))
                        result = false;
                };
                return result;
            }

            if (obj == null && value == null)
                return true;

            return false;
        }
	}
}
