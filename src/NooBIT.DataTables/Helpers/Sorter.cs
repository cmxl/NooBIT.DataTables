using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace NooBIT.DataTables.Helpers
{
    public class Sorter<T> : ISorter<T>
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

            var type = typeof(T);
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

        private void Register<TKey>(string name, Expression<Func<T, TKey>> selector)
        {
            _firstPasses.Add(name, s => s.OrderBy(selector));
            _firstDescendingPasses.Add(name, s => s.OrderByDescending(selector));
            _nextPasses.Add(name, s => s.ThenBy(selector));
            _nextDescendingPasses.Add(name, s => s.ThenByDescending(selector));
        }

        private void Register<TKey>(Expression<Func<T, TKey>> selector)
        {
            var name = GetMemberName(selector);
            Register(name, selector);
        }

        private string GetMemberName<TKey>(Expression<Func<T, TKey>> selector)
        {
            if (!(selector.Body is MemberExpression memberExpression))
                throw new ArgumentException($"Expression '{selector}' is not a {typeof(MemberExpression)}", nameof(selector));

            return memberExpression.Member.Name;
        }

        public IOrderedQueryable<T> SortBy(IQueryable<T> source, IEnumerable<SortInstruction> instructions)
        {
            IOrderedQueryable<T> result = null;

            foreach (var instruction in instructions)
                result = result == null ? SortFirst(instruction, source) : SortNext(instruction, result);

            if (result == null)
                return (IOrderedQueryable<T>)source;

            return result;
        }

        private IOrderedQueryable<T> SortFirst(SortInstruction instruction, IQueryable<T> source)
        {
            if (instruction.Direction == SortDirection.Ascending)
                return _firstPasses[instruction.Name].Invoke(source);
            return _firstDescendingPasses[instruction.Name].Invoke(source);
        }

        private IOrderedQueryable<T> SortNext(SortInstruction instruction, IOrderedQueryable<T> source)
        {
            if (instruction.Direction == SortDirection.Ascending)
                return _nextPasses[instruction.Name].Invoke(source);
            return _nextDescendingPasses[instruction.Name].Invoke(source);
        }

        private class FirstPasses : Dictionary<string, Func<IQueryable<T>, IOrderedQueryable<T>>>
        {
        }

        private class NextPasses : Dictionary<string, Func<IOrderedQueryable<T>, IOrderedQueryable<T>>>
        {
        }
    }

    public interface ISorter<T>
    {
        IOrderedQueryable<T> SortBy(IQueryable<T> source, IEnumerable<SortInstruction> instructions);
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