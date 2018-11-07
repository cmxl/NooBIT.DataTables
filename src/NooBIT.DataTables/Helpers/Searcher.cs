using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NooBIT.DataTables.Helpers
{
    public static class Searcher
    {
        public static IQueryable<TSource> SearchBy<TSource>(IQueryable<TSource> source, List<SearchInstruction<TSource>> instructions)
        {
            Expression<Func<TSource, bool>> where = x => (instructions == null || instructions.Count == 0);

            instructions.ForEach(x =>
            {
                if (x.Expression != null)
                {
                    where = where.Or(x.Expression);
                    return;
                }

                if (x.Value == null)
                    return;

                var value = Convert.ChangeType(x.Value, x.Type);
                var parameter = Expression.Parameter(typeof(TSource), "x");
                var property = typeof(TSource).GetProperty(x.Name);
                if (property == null)
                    return;

                var left = Expression.Property(parameter, property);
                var body = Expression.Equal(left, Expression.Constant(value));
                var expression = Expression.Lambda<Func<TSource, bool>>(body, parameter);
                where = where.Or(expression);

            });

            return source.Where(where);
        }
    }

    public class SearchInstruction<TSource>
    {
        internal SearchInstruction() { }

        private Type _type;
        private string _name;
        internal Func<string> NameFunc { get; set; }
        public string Name => _name ?? (_name = NameFunc?.Invoke());
        public Type Type => _type ?? (_type = typeof(TSource).GetProperty(Name).PropertyType);
        public object Value { get; internal set; }
        internal Expression<Func<TSource, bool>> Expression { get; private set; }

        /// <summary>
        /// Default search expression is replaced by this custom expression.
        /// </summary>
        /// <param name="expression">Custom expression</param>
        public void UseCustomExpression(Expression<Func<TSource, bool>> expression)
        {
            Expression = expression;
        }
    }
}
