using Many.Validators.Range;
using System;

namespace Many.Validators.Statics
{
	internal static class ErrorHandlingExtensions
    {
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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TValue">Underlying value type</typeparam>
        /// <param name="rangeType">Range type</param>
        /// <returns>Validator information</returns>
        public static string GetRangeInfo<TValue>(Type rangeType)
            => $"{rangeType.Name} of {typeof(TValue).Name}";
    }
}
