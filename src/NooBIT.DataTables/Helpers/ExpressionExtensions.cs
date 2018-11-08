using System;
using System.Linq.Expressions;

namespace NooBIT.DataTables.Helpers
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> firstExpression, Expression<Func<T, bool>> secondExpression)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var body = Expression.OrElse(Expression.Invoke(firstExpression, parameter), Expression.Invoke(secondExpression, parameter));
            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }
    }
}
