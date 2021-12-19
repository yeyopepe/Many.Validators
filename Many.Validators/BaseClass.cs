using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators
{
    public abstract class BaseClass<V>
    {
        /// <summary>
        /// Gets the value
        /// </summary>
        public V Value { get; protected set; }

        public override string ToString()
        {
            return Value != null ?
               Value.ToString() :
               String.Empty;
        }

        public override int GetHashCode()
        {
            return Value != null ?
               Value.GetHashCode() :
               0;
        }

        protected static void ThrowExceptionIfNull<V>(V value)
        {
            if (value == null)
                throw new ArgumentNullException($"Validator: value '{value}' can not be null.");
        }

    }
}
