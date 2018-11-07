using System;
using System.Linq.Expressions;
using System.Reflection;

namespace NooBIT.DataTables.Helpers
{
    public static class ExpressionHelper
    {
        private static readonly MethodInfo _compareMethod = typeof(string).GetMethod("IndexOf", new[] { typeof(string), typeof(StringComparison) });

        public static Expression<Func<T, bool>> BuildExpression<T>(PropertyInfo property, object value) => property.PropertyType == typeof(string)
            ? Contains<T>(property, value as string)
            : Equal<T>(property, value);

        public static Expression<Func<T, bool>> Contains<T>(PropertyInfo propertyInfo, string value)
        {
            var parameterExp = Expression.Parameter(typeof(T), "x");
            var propertyExp = Expression.Property(parameterExp, propertyInfo.Name);
            var someValue = Expression.Constant(value, typeof(string));
            var comparison = Expression.Constant(StringComparison.OrdinalIgnoreCase, typeof(StringComparison));
            var containsMethodExp = Expression.Call(propertyExp, _compareMethod, someValue, comparison);
            var compareExpression = Expression.GreaterThanOrEqual(containsMethodExp, Expression.Constant(0));

            return Expression.Lambda<Func<T, bool>>(compareExpression, parameterExp);
        }

        public static Expression<Func<T, bool>> Equal<T>(PropertyInfo propertyInfo, object value)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var left = Expression.Property(parameter, propertyInfo.Name);
            var body = Expression.Equal(left, Expression.Constant(value));

            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }
    }
}
