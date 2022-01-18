using System;

namespace Many.Validators.Statics
{
	internal static class DynamicObjectsHelper
	{
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowExceptionIfNull<TValidator, TValue>(object value)
          where TValidator : IValidator<TValue>
         {
            if (value is null)
                throw new ArgumentNullException(paramName: nameof(value), message: GetExceptionMessageForValidator<TValidator, TValue>(value, "can not be null"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <param name="reasonOfError"></param>
        /// <returns>Exception message</returns>
        public static string GetExceptionMessageForValidator<TValidator, TValue>(object value, string reasonOfError)
           where TValidator : IValidator<TValue>
           => $"Validator {ErrorHandlingExtensions.GetValidatorInfo<TValidator, TValue>()}: value '{value}' {reasonOfError}";

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="rangeType">Range type</param>
        /// <param name="value"></param>
        /// <param name="reasonOfError"></param>
        /// <returns>Exception message</returns>
        public static string GetExceptionMessageaForRange<TValue>(Type rangeType, object value, string reasonOfError)
           => $"Validator {ErrorHandlingExtensions.GetRangeInfo<TValue>(rangeType)}: value '{value}' {reasonOfError}";
    }
}
