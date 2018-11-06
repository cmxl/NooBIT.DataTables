using System;

namespace NooBIT.DataTables.Helpers
{
    public static class ConvertTypeHelper
    {
        public static bool TryConvert<TValue>(string obj, out TValue value)
        {
            if (Nullable.GetUnderlyingType(typeof(TValue)) != null)
            {
                return TryConvertNullable(obj, out value);
            }

            if (typeof(TValue) == typeof(DateTime))
            {
                return TryParseDateTime(obj, out value);
            }

            try
            {
                value = (TValue) Convert.ChangeType(obj, typeof(TValue));
                return true;
            }
            catch
            {
                value = default(TValue);
                return false;
            }
        }

        private static bool TryConvertNullable<TValue>(string obj, out TValue value)
        {
            if (string.IsNullOrWhiteSpace(obj))
            {
                value = default(TValue);
                return true;
            }

            if (Nullable.GetUnderlyingType(typeof(TValue)) == typeof(DateTime))
            {
                return TryParseDateTime(obj, out value);
            }

            try
            {
                value = (TValue)Convert.ChangeType(obj, Nullable.GetUnderlyingType(typeof(TValue)) ?? throw new InvalidOperationException());
                return true;
            }
            catch
            {
                value = default(TValue);
                return false;
            }
        }

        private static bool TryParseDateTime<TValue>(string obj, out TValue value)
        {
            var success = DateTime.TryParse(obj, out var dateTime);

            if (success)
                value = (TValue)(object)dateTime;
            else
                value = default(TValue);

            return success;
        }

        public static bool TryConvert(string obj, Type destinationType, out object value)
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