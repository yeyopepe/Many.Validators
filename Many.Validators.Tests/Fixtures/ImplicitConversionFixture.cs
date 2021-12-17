using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many.Validators.Tests.Fixtures
{
    internal class ImplicitConversionFixture
    {
        public static void ImplicitConversion_ReturnsUnderlyingType<T>(Type validatorType, T value)
        {
            //Implicit conversion from value type to ValidatorType
            dynamic validatorInstance = Activator.CreateInstance(validatorType, value);

            T result = validatorInstance;

            Assert.AreEqual(value, result);
        }
    }
}
