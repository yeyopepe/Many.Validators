using NUnit.Framework;
using System;

namespace Many.Validators.Tests
{
    public abstract class BaseTests
    {
        /// <summary>
        /// Tries to instance a validator expectoing that passes
        /// </summary>
        /// <typeparam name="T">Validator Type</typeparam>
        /// <typeparam name="V">Value type</typeparam>
        /// <param name="value"></param>
        protected void CreateValidator_ValidValues_ReturnsValue<T,V>(V value)
        {
            Assert.DoesNotThrow(() =>
            {
                var validator = Activator.CreateInstance(typeof(T), new object[]{ value });
                Assert.IsNotNull(validator);
            });
        }

        /// <summary>
        /// Tries to instance a validator expectoing that fails
        /// </summary>
        /// <typeparam name="T">Validator Type</typeparam>
        /// <typeparam name="V">Value type</typeparam>
        /// <typeparam name="Ex">Expected exception</typeparam>
        /// <param name="value"></param>
        protected void CreateValidator_InvalidValues_ThrowsException<T,V,Ex>(V value)
            where Ex: Exception
        {
            Assert.Throws<Ex>(() =>
            {
                var validator = Activator.CreateInstance(typeof(T), new object[] { value });
            });
        }

        /// <summary>
        /// Implicit conversion from value type to ValidatorType
        /// </summary>
        /// <typeparam name="V">Value type</typeparam>
        /// <param name="validatorType"></param>
        /// <param name="value"></param>
        public static void ImplicitConversion_ReturnsUnderlyingType<V>(Type validatorType, V value)
        {
            dynamic validatorInstance = Activator.CreateInstance(validatorType, value);

            V result = validatorInstance;

            Assert.AreEqual(value, result);
        }
    }
}
