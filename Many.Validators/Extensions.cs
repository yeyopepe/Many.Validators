using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators
{
    internal static class Extensions
    {
        public static string OverrideToString<V>(this V value)
        {
            return value != null ?
               value.ToString() :
               String.Empty;
        }

        public static int OverrideGetHashCode<V>(this V value)
        {
            return value != null ?
               value.GetHashCode() :
               0;
        }

        public static bool OverrideEquals<T,V>(this V value, object obj)
            where T: IValidator<V>
        {
            bool? comparison;
            if (obj is V)
                comparison = value?.Equals(((V)obj));
            else if (obj == null ||
                !(obj is T))
                return false;
            else
                comparison = value?.Equals(((T)obj).Value);

            return comparison.HasValue && comparison.Value;
        }

        public static void ThrowExceptionIfNull<T, V>(this V value)
            where T : IValidator<V>
        {
            if (value == null)
                throw new ArgumentNullException(value.GetExceptionMessage<T, V>("can not be null"));
        }
        public static void ThrowExceptionIfNull<T, V>(this T value)
           where T : IValidator<V>
        {
            if (value == null)
                throw new ArgumentNullException(value.GetExceptionMessage<T, V>("can not be null"));
        }

        public static string GetExceptionMessage<T, V>(this V value, string reasonOfError)
            where T : IValidator<V>
            => $"Validator {GetValidatorInfo<T, V>()}: value '{value}' {reasonOfError}";
        public static string GetExceptionMessage<T, V>(this T value, string reasonOfError)
            where T : IValidator<V>
            => $"Validator {GetValidatorInfo<T, V>()}: value '{value}' {reasonOfError}";

        private static string GetValidatorInfo<T, V>()
            where T : IValidator<V>
            => $"{typeof(T).Name} of {typeof(V).Name}";
    }
}
