﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace IntegrationTests
{
    public delegate void MethodThatThrows();

    /// <summary>
    /// Extention methods that make unit test asserts more fluid and readable.
    ///
    /// Modified from CodeIncubator: http://code.google.com/p/codeincubator/
    /// </summary>
    public static class NUnitSpecExtensions
    {
        public static void ShouldBeFalse(this bool condition)
        {
            Assert.IsFalse(condition);
        }

        public static void ShouldBeTrue(this bool condition)
        {
            Assert.IsTrue(condition);
        }

        public static object ShouldEqual(this object actual, object expected)
        {
            Assert.AreEqual(expected, actual);
            return expected;
        }

        public static object ShouldNotEqual(this object actual, object expected)
        {
            Assert.AreNotEqual(expected, actual);
            return expected;
        }

        public static void ShouldBeNull(this object anObject)
        {
            Assert.IsNull(anObject);
        }

        public static void ShouldNotBeNull(this object anObject)
        {
            Assert.IsNotNull(anObject);
        }

        public static object ShouldBeTheSameAs(this object actual, object expected)
        {
            Assert.AreSame(expected, actual);
            return expected;
        }

        public static object ShouldNotBeTheSameAs(this object actual, object expected)
        {
            Assert.AreNotSame(expected, actual);
            return expected;
        }

        public static void ShouldBeOfType(this object actual, Type expected)
        {
            Assert.IsInstanceOfType(expected, actual);
        }

        public static void ShouldNotBeOfType(this object actual, Type expected)
        {
            Assert.IsNotInstanceOfType(expected, actual);
        }

        public static void ShouldContain(this IList actual, object expected)
        {
            Assert.Contains(expected, actual);
        }

        public static IComparable ShouldBeGreaterThan(this IComparable arg1, IComparable arg2)
        {
            Assert.Greater(arg1, arg2);
            return arg2;
        }

        public static IComparable ShouldBeLessThan(this IComparable arg1, IComparable arg2)
        {
            Assert.Less(arg1, arg2);
            return arg2;
        }

        public static void ShouldBeEmpty(this ICollection collection)
        {
            Assert.IsEmpty(collection);
        }

        public static void ShouldBeEmpty(this string aString)
        {
            Assert.IsEmpty(aString);
        }

        public static void ShouldNotBeEmpty(this ICollection collection)
        {
            Assert.IsNotEmpty(collection);
        }

        public static void ShouldNotBeEmpty(this string aString)
        {
            Assert.IsNotEmpty(aString);
        }

        public static void ShouldContain(this string actual, string expected)
        {
            StringAssert.Contains(expected, actual);
        }

        public static string ShouldBeEqualIgnoringCase(this string actual, string expected)
        {
            StringAssert.AreEqualIgnoringCase(expected, actual);
            return expected;
        }

        public static void ShouldEndWith(this string actual, string expected)
        {
            StringAssert.EndsWith(expected, actual);
        }

        public static void ShouldStartWith(this string actual, string expected)
        {
            StringAssert.StartsWith(expected, actual);
        }

        public static void ShouldContainErrorMessage(this Exception exception, string expected)
        {
            StringAssert.Contains(expected, exception.Message);
        }

        public static Exception ShouldBeThrownBy(this Type exceptionType, MethodThatThrows method)
        {
            Exception exception = null;

            try
            {
                method();
            }
            catch (Exception e)
            {
                Assert.AreEqual(exceptionType, e.GetType());
                exception = e;
            }

            if (exception == null)
            {
                Assert.Fail(String.Format("Expected {0} to be thrown.", exceptionType.FullName));
            }

            return exception;
        }

        public static void ShouldEqualSqlDate(this DateTime actual, DateTime expected)
        {
            TimeSpan timeSpan = actual - expected;
            Assert.Less(Math.Abs(timeSpan.TotalMilliseconds), 3);
        }
    }
}
