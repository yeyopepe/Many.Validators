using System;

namespace Many.Validators
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
        /// <summary>
        /// Overrides validator's Equals() method
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <param name="obj"></param>
        /// <returns>True if the objects are considered equal; otherwise, false. 
        /// If both value and objB are null, the method returns true.</returns>
        public static bool OverrideEquals<TValidator,TValue>(this TValue value, object obj)
            where TValidator: IValidator<TValue>
        {
            bool? comparison;
            if (obj is TValue)
                comparison = value?.Equals(((TValue)obj));
            else if (obj == null)
                return true;
            else if (!(obj is TValidator))
                return false;
            else
                comparison = value?.Equals(((TValidator)obj).Value);

            return comparison.HasValue && comparison.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowExceptionIfNull<TValidator, TValue>(this TValue value)
            where TValidator : IValidator<TValue>
        {
            if (value == null)
                throw new ArgumentNullException(paramName: nameof(value), message: value.GetExceptionMessage<TValidator, TValue>("can not be null"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowExceptionIfNull<TValidator, TValue>(this TValidator value)
           where TValidator : IValidator<TValue>
        {
            if (value == null)
                throw new ArgumentNullException(paramName: nameof(value), message: value.GetExceptionMessage<TValidator, TValue>("can not be null"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <param name="reasonOfError"></param>
        /// <returns>Exception message</returns>
        public static string GetExceptionMessage<TValidator, TValue>(this TValue value, string reasonOfError)
            where TValidator : IValidator<TValue>
            => $"Validator {GetValidatorInfo<TValidator, TValue>()}: value '{value}' {reasonOfError}";
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="validator"></param>
        /// <param name="reasonOfError"></param>
        /// <returns>Exception message</returns>
        private static string GetExceptionMessage<TValidator, TValue>(this TValidator validator, string reasonOfError)
            where TValidator : IValidator<TValue>
            => $"Validator {GetValidatorInfo<TValidator, TValue>()}: value '{validator}' {reasonOfError}";

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <returns>Validator information</returns>
        public static string GetValidatorInfo<TValidator, TValue>()
            where TValidator : IValidator<TValue>
            => $"{typeof(TValidator).Name} of {typeof(TValue).Name}";


    }
}
