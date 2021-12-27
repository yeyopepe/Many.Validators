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
        public static void ThrowExceptionIfNull<TValidator, TValue>(dynamic value)
          where TValidator : IValidator<TValue>
        {
            if (value is null)
                throw new ArgumentNullException(paramName: nameof(value), message: GetExceptionMessage<TValidator, TValue>(value, "can not be null"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValidator">Validator type</typeparam>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="value"></param>
        /// <param name="reasonOfError"></param>
        /// <returns>Exception message</returns>
        public static string GetExceptionMessage<TValidator, TValue>(dynamic value, string reasonOfError)
           where TValidator : IValidator<TValue>
           => $"Validator {ErrorHandlingExtensions.GetValidatorInfo<TValidator, TValue>()}: value '{value}' {reasonOfError}";

        
    }
}
