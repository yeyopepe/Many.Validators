using NUnit.Framework;
using System;
using System.Reflection;

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
            where T : IValidator<V>
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
            where T: IValidator<V>
            where Ex: Exception
        {
            var result = Assert.Throws<TargetInvocationException>(() =>
            {
                var validator = Activator.CreateInstance(typeof(T), new object[] { value });
            });
            Assert.AreEqual(result.InnerException.GetType(), typeof(Ex), "Unexpected exception type");

            var msgToCheck = $"{typeof(T).Name} of {typeof(V).Name}";
            Assert.IsTrue(result.InnerException.Message.Contains(msgToCheck), "Unexpected exception message");
        }

        /// <summary>
        /// Implicit conversion from value type to ValidatorType
        /// </summary>
        /// <typeparam name="V">Value type</typeparam>
        /// <param name="validatorType"></param>
        /// <param name="validValueForCurrentValidator"></param>
        public static void ImplicitConversion_ReturnsUnderlyingType<V>(Type validatorType, V validValueForCurrentValidator)
        {
            dynamic validatorInstance = Activator.CreateInstance(validatorType, validValueForCurrentValidator);

            V result = validatorInstance;

            Assert.AreEqual(validValueForCurrentValidator, result);
        }

    }
}
