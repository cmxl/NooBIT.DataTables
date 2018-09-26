using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace NooBIT.DataTables.Helpers
{
    public class Sorter<TSource> : ISorter<TSource>
    {
        private readonly FirstPasses _firstDescendingPasses;
        private readonly FirstPasses _firstPasses;
        private readonly NextPasses _nextDescendingPasses;
        private readonly NextPasses _nextPasses;

        internal Sorter()
        {
            _firstPasses = new FirstPasses();
            _firstDescendingPasses = new FirstPasses();
            _nextPasses = new NextPasses();
            _nextDescendingPasses = new NextPasses();

            var type = typeof(TSource);
            type
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToList()
                .ForEach(x =>
                {
                    var parameter = Expression.Parameter(type, "x");
                    var body = Expression.Property(parameter, x);
                    var delegateType = typeof(Func<,>).MakeGenericType(type, x.PropertyType);
                    dynamic expression = Expression.Lambda(delegateType, body, parameter);
                    Register(expression);
                });
        }

        public void Register<TKey>(string name, Expression<Func<TSource, TKey>> selector)
        {
            _firstPasses.Add(name, s => s.OrderBy(selector));
            _firstDescendingPasses.Add(name, s => s.OrderByDescending(selector));
            _nextPasses.Add(name, s => s.ThenBy(selector));
            _nextDescendingPasses.Add(name, s => s.ThenByDescending(selector));
        }

        public void Register<TKey>(Expression<Func<TSource, TKey>> selector)
        {
            var name = GetMemberName(selector);
            Register(name, selector);
        }

        private string GetMemberName<TKey>(Expression<Func<TSource, TKey>> selector)
        {
            if (!(selector.Body is MemberExpression memberExpression))
                throw new ArgumentException($"Expression '{selector}' is not a {typeof(MemberExpression)}", nameof(selector));

            return memberExpression.Member.Name;
        }

        public IOrderedQueryable<TSource> SortBy(IQueryable<TSource> source, IEnumerable<SortInstruction> instructions)
        {
            IOrderedQueryable<TSource> result = null;

            foreach (var instruction in instructions)
                result = result == null ? SortFirst(instruction, source) : SortNext(instruction, result);

            if (result == null)
                return (IOrderedQueryable<TSource>) source;

            return result;
        }

        private IOrderedQueryable<TSource> SortFirst(SortInstruction instruction, IQueryable<TSource> source)
        {
            if (instruction.Direction == SortDirection.Ascending)
                return _firstPasses[instruction.Name].Invoke(source);
            return _firstDescendingPasses[instruction.Name].Invoke(source);
        }

        private IOrderedQueryable<TSource> SortNext(SortInstruction instruction, IOrderedQueryable<TSource> source)
        {
            if (instruction.Direction == SortDirection.Ascending)
                return _nextPasses[instruction.Name].Invoke(source);
            return _nextDescendingPasses[instruction.Name].Invoke(source);
        }

        private class FirstPasses : Dictionary<string, Func<IQueryable<TSource>, IOrderedQueryable<TSource>>>
        {
        }

        private class NextPasses : Dictionary<string, Func<IOrderedQueryable<TSource>, IOrderedQueryable<TSource>>>
        {
        }
    }

    public interface ISorter<TSource>
    {
        IOrderedQueryable<TSource> SortBy(IQueryable<TSource> source, IEnumerable<SortInstruction> instructions);
    }

    public class SortInstruction
    {
        public string Name { get; set; }
        public SortDirection Direction { get; set; }
    }

    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public static class SortDirections
    {
        public static readonly string Ascending = "asc";
        public static readonly string Descending = "desc";
    }
}