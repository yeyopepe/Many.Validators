using System;

namespace Many.Validators.Statics
{
	internal static class BaseValidatorExtensions
    {
        /// <summary>
        /// Overrides validator's ToString() method
        /// </summary>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <returns>String representation</returns>
        public static string OverrideToString<TValue>(this TValue value)
        {
            return value != null ?
               value.ToString() :
               String.Empty;
        }
        /// <summary>
        /// Overrides validator's GetHashCode() method
        /// </summary>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <returns>Object's HashCode</returns>
        public static int OverrideGetHashCode<TValue>(this TValue value)
        {
            return value != null ?
               value.GetHashCode() :
               0;
        }
       
    }
}
