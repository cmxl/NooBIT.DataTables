using System;
using System.Linq.Expressions;

namespace NooBIT.DataTables.Helpers
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<TSource, bool>> Or<TSource>(this Expression<Func<TSource, bool>> firstExpression, Expression<Func<TSource, bool>> secondExpression)
        {
            var parameter = Expression.Parameter(typeof(TSource), "x");
            var body = Expression.OrElse(Expression.Invoke(firstExpression, parameter), Expression.Invoke(secondExpression, parameter));
            return Expression.Lambda<Func<TSource, bool>>(body, parameter);
        }
    }
}
