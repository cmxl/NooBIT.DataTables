using System;

namespace NooBIT.DataTables.Helpers
{
    public static class ConvertTypeHelper
    {
        public static bool TryConvert<T>(string obj, out T value)
        {
            if (Nullable.GetUnderlyingType(typeof(T)) != null)
            {
                return TryConvertNullable(obj, out value);
            }

            if (typeof(T) == typeof(DateTime))
            {
                return TryParseDateTime(obj, out value);
            }

            try
            {
                value = (T)Convert.ChangeType(obj, typeof(T));
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        private static bool TryConvertNullable<T>(string obj, out T value)
        {
            if (string.IsNullOrWhiteSpace(obj))
            {
                value = default;
                return true;
            }

            if (Nullable.GetUnderlyingType(typeof(T)) == typeof(DateTime))
            {
                return TryParseDateTime(obj, out value);
            }

            try
            {
                value = (T)Convert.ChangeType(obj, Nullable.GetUnderlyingType(typeof(T)) ?? throw new InvalidOperationException());
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        private static bool TryParseDateTime<T>(string obj, out T value)
        {
            var success = DateTime.TryParse(obj, out var dateTime);
            value = success ? (T)(object)dateTime : (default);
            return success;
        }

        public static bool TryConvert(object obj, Type destinationType, out object value)
        {
            try
            {
                value = Convert.ChangeType(obj, destinationType);
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }
    }
}