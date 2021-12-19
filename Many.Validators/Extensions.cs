using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators
{
    internal static class Extensions
    {
        public static void ThrowExceptionIfNull<V>(this V value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
        }
    }
}
