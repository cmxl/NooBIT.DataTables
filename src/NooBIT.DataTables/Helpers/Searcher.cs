using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinqKit;

namespace NooBIT.DataTables.Helpers
{
    public static class Searcher
    {
        public static IQueryable<T> SearchBy<T>(IQueryable<T> source, List<SearchInstruction<T>> instructions)
        {
            if (instructions == null || instructions.Count == 0)
                return source;

            Expression<Func<T, bool>> where = PredicateBuilder.New<T>(true);
            instructions.ForEach(x =>
            {
                if (x.Expression != null)
                {
                    where = where.And(x.Expression);
                    return;
                }

                if (x.Value == null)
                    return;

                var property = typeof(T).GetProperty(x.Name);
                if (property == null)
                    return;

                if (!ConvertTypeHelper.TryConvert(x.Value, x.Type, out var value))
                    return;

                var expression = ExpressionHelper.BuildExpression<T>(property, value);
                where = where.And(expression);

            });

            return source.Where(where);
        }
    }

    public class SearchInstruction<T>
    {
        internal SearchInstruction() { }

        private Type _type;
        private string _name;
        internal Func<string> NameFunc { get; set; }
        public string Name => _name ??= NameFunc?.Invoke();
        public Type Type => _type ??= typeof(T).GetProperty(Name).PropertyType;
        public object Value { get; internal set; }
        internal Expression<Func<T, bool>> Expression { get; private set; }

        /// <summary>
        /// Default search expression is replaced by this custom expression.
        /// </summary>
        /// <param name="expression">Custom expression</param>
        public void UseCustomExpression(Expression<Func<T, bool>> expression)
        {
            Expression = expression;
        }
    }
}
