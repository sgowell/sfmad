using System;
using System.Collections.Generic;

namespace Web.Services
{
    /// <summary>
    /// Converts any object to a dictinoary using reflection
    /// </summary>
    public class ObjectConverter
    {
        /// <summary>
        /// Convert incoming object's fields and properties into a dictionary. Ignores complex types.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public IDictionary<string, object> ToDictionary(object value)
        {
            return ToDictionary(value, false);
        }

        /// <summary>
        /// Convert incoming object's fields and properties into a dictionary.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="includeComplexTypes">If true, complex types will be included, if false only System.* types will be included.</param>
        /// <returns></returns>
        public IDictionary<string, object> ToDictionary(object value, bool includeComplexTypes)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            var objectType = value.GetType();

            var rv = new Dictionary<string, object>();

            _LoadProperties(objectType, value, rv, includeComplexTypes);
            _LoadFields(objectType, value, rv, includeComplexTypes);

            return rv;
        }

        private static void _LoadProperties(Type objectType, object value, IDictionary<string, object> rv, bool includeComplexTypes)
        {
            var propertyList = objectType.GetProperties();

            foreach (var property in propertyList)
            {
                if (_ShouldTypeBeIncluded(includeComplexTypes, property.PropertyType))
                {
                    string propertyName = property.Name;
                    object propertyValue = property.GetValue(value, null);

                    rv.Add(propertyName, propertyValue);
                }
            }
        }

        private static void _LoadFields(Type objectType, object value, IDictionary<string, object> rv, bool includeComplexTypes)
        {
            var fieldList = objectType.GetFields();

            foreach (var field in fieldList)
            {
                if (_ShouldTypeBeIncluded(includeComplexTypes, field.FieldType))
                {
                    string fieldName = field.Name;
                    object fieldValue = field.GetValue(value);
                    rv.Add(fieldName, fieldValue);
                }
            }
        }

        private static bool _ShouldTypeBeIncluded(bool includeComplexTypes, Type type)
        {
            if (includeComplexTypes) // if complex types are allowed, anything goes
                return true;

            return type.Namespace == "System";
        }
    }
}