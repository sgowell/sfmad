using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Web.Models;
using Web.Services;

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

    public static class EnumExtensions
    {
        public static SelectList ToSelectList<T>(this T enumeration)
        {
            var source = Enum.GetValues(typeof(T));
            var items = new Dictionary<object, string>();

            foreach (var value in source)
            {
                FieldInfo field = value.GetType().GetField(value.ToString());                
                items.Add(value, value.ToString());
            }

            return new SelectList(items, "Key", "Value", enumeration);
        }
    }

    public static class TransectExtensions
    {
        public static void WriteTo(this IEnumerable<Transect> transects, ICsvWriter writer)
        {
            var objectCsvWriter = new ObjectCsvWriter();
            objectCsvWriter.WriteToCSV(transects, writer, true);
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