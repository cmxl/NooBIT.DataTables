using System;
using System.Linq.Expressions;
using LinqKit;

namespace NooBIT.DataTables.Helpers
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> firstExpression, Expression<Func<T, bool>> secondExpression)
        {
            return PredicateBuilder.New(firstExpression).Or(secondExpression).Expand();
        }
    }
}
