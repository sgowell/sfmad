using System;
using System.Collections.Generic;

namespace Web
{
    public static class StringExtensions
    {
        public static string AppSetting(this string SettingName)
        {
            return System.Configuration.ConfigurationManager.AppSettings[SettingName];
        }

        public static int ToInt(this string item)
        {
            return Int32.Parse(item);
        }
    }

    public static class EnumerableExtensions
    {
        public static void Each<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }
    }
    public static class Check
    {
        /// <summary>
        /// Ensure A property is not null.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="message"></param>
        public static void Require(object property, string message)
        {
            if (property == null)
                throw new ArgumentNullException(message);
        }
    }
}