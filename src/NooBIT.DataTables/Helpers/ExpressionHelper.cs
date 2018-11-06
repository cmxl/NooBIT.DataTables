using System;
using System.Linq.Expressions;
using System.Reflection;

namespace NooBIT.DataTables.Helpers
{
    public static class ExpressionHelper
    {
        public static Expression BuildContainsExpression(object typedValue, MemberExpression propertyExpression)
        {
            var method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var valueExpression = Expression.Constant(typedValue, typeof(string));
            return Expression.Call(propertyExpression, method, valueExpression);
        }

        public static Expression BuildEqualsExpression(object typedValue, MemberExpression propertyExpression)
        {
            return Expression.Equal(propertyExpression, Expression.Constant(typedValue));
        }

        public static Expression<Func<TEntity, bool>> BuildExpression<TEntity>(PropertyInfo property, object typedValue)
        {
            var parameterExpression = Expression.Parameter(typeof(TEntity), "x");
            var propertyExpression = Expression.PropertyOrField(parameterExpression, property.Name);

            var body = property.PropertyType == typeof(string)
                ? ExpressionHelper.BuildContainsExpression(typedValue, propertyExpression)
                : ExpressionHelper.BuildEqualsExpression(typedValue, propertyExpression);

            return Expression.Lambda<Func<TEntity, bool>>(body, parameterExpression);
        }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var expr2Body = new RebindParameterVisitor(expr2.Parameters[0], expr1.Parameters[0]).Visit(expr2.Body);
            return Expression.Lambda<Func<T, bool>>(Expression.OrElse(expr1.Body, expr2Body), expr1.Parameters);
        }

        private class RebindParameterVisitor : ExpressionVisitor
        {
            private readonly ParameterExpression _oldParameter;
            private readonly ParameterExpression _newParameter;

            public RebindParameterVisitor(ParameterExpression oldParameter, ParameterExpression newParameter)
            {
                _oldParameter = oldParameter;
                _newParameter = newParameter;
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                if (node == _oldParameter)
                {
                    return _newParameter;
                }

                return base.VisitParameter(node);
            }
        }

    }
}
