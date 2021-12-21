using System;

namespace Many.Validators
{
	internal static class DynamicHelper
	{
        public static void ThrowExceptionIfNull<TValidator, TValue>(dynamic value)
          where TValidator : IValidator<TValue>
        {
            if (value == null)
                throw new ArgumentNullException(value.GetExceptionMessage<TValidator, TValue>("can not be null"));
        }
        public static string GetExceptionMessage<TValidator, TValue>(dynamic value, string reasonOfError)
           where TValidator : IValidator<TValue>
           => $"Validator {BaseValidatorExtensions.GetValidatorInfo<TValidator, TValue>()}: value '{value}' {reasonOfError}";
    }
}
