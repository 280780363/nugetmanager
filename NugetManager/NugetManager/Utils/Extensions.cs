using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public static class Extensions
{
    public static T ConvertTo<T>(this object value)
    {
        if (value == null)
            return default(T);

        var destinationType = typeof(T);
        var sourceType = value.GetType();
        if (destinationType == typeof(bool) || destinationType == typeof(bool?))
            value = Convert.ToBoolean(value);

        TypeConverter destinationConverter = TypeDescriptor.GetConverter(destinationType);
        TypeConverter sourceConverter = TypeDescriptor.GetConverter(sourceType);
        if (destinationConverter != null && destinationConverter.CanConvertFrom(value.GetType()))
            return (T)destinationConverter.ConvertFrom(value);
        if (sourceConverter != null && sourceConverter.CanConvertTo(destinationType))
            return (T)sourceConverter.ConvertTo(value, destinationType);
        if (destinationType.IsEnum && value is int)
            return (T)Enum.ToObject(destinationType, (int)value);
        if (!destinationType.IsInstanceOfType(value))
            return (T)Convert.ChangeType(value, destinationType);
        return (T)value;
    }


    public static bool IsNullOrWhiteSpace(this string str)
    {
        return string.IsNullOrWhiteSpace(str);
    }

    public static List<T> Split<T>(this string str, params string[] separators)
    {
        if (string.IsNullOrWhiteSpace(str))
            return new List<T>();
        return str.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(ConvertTo<T>).ToList();
    }

    public static bool Contains(this string source, string value, StringComparison stringComparison)
    {
        if (source == null || value == null) { return false; }
        if (value == "") { return true; }
        return (source.IndexOf(value, stringComparison) >= 0);
    }
}