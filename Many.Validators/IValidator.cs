using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Validators
{
    public interface IValidator<V>
    {
        /// <summary>
        /// Gets the value
        /// </summary>
        V Value { get; }
    }
}
