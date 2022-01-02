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
        /// <typeparam name="TValidator">Validator Type</typeparam>
        /// <typeparam name="TValue">Value type</typeparam>
        /// <param name="value"></param>
        protected void CreateValidator_ValidValues_ReturnsValue<TValidator,TValue>(TValue value)
            where TValidator : IValidator<TValue>
        {
            Assert.DoesNotThrow(() =>
            {
                var validator = Activator.CreateInstance(typeof(TValidator), new object[]{ value });
                Assert.IsNotNull(validator);
            });
        }

        /// <summary>
        /// Tries to instance a validator expectoing that fails
        /// </summary>
        /// <typeparam name="TValidator">Validator Type</typeparam>
        /// <typeparam name="TValue">Value type</typeparam>
        /// <typeparam name="TException">Expected exception</typeparam>
        /// <param name="value"></param>
        protected void CreateValidator_InvalidValues_ThrowsException<TValidator,TValue,TException>(TValue value)
            where TValidator: IValidator<TValue>
            where TException: Exception
        {
            var result = Assert.Throws<TargetInvocationException>(() =>
            {
                var validator = Activator.CreateInstance(typeof(TValidator), new object[] { value });
            });
            Assert.AreEqual(typeof(TException), result.InnerException.GetType(), "Unexpected exception type");

            var msgToCheck = $"of {typeof(TValue).Name}";
            Assert.IsTrue(result.InnerException.Message.Contains(msgToCheck), "Unexpected exception message");
        }

        /// <summary>
        /// Implicit conversion from value type to ValidatorType
        /// </summary>
        /// <typeparam name="TValue">Value type</typeparam>
        /// <param name="validatorType"></param>
        /// <param name="validValueForCurrentValidator"></param>
        public static void ImplicitConversion_ReturnsUnderlyingType<TValue>(Type validatorType, TValue validValueForCurrentValidator)
        {
            dynamic validatorInstance = Activator.CreateInstance(validatorType, validValueForCurrentValidator);

            TValue result = validatorInstance;

            Assert.AreEqual(validValueForCurrentValidator, result);
        }

    }
}
