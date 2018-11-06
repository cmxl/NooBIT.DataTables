using System.Linq;

namespace NooBIT.DataTables.Helpers
{
    public static class QueryHelper
    {
        public static IQueryable<TEntity> BuildSearchQuery<TEntity>(IQueryable<TEntity> query, string columnName, string searchValue)
        {
            var property = typeof(TEntity).GetProperty(columnName);

            if (!ConvertTypeHelper.TryConvert(searchValue, property.PropertyType, out var typedValue))
                return query;

            var lambda = ExpressionHelper.BuildExpression<TEntity>(property, typedValue);
            return query.Where(lambda);
        }
    }
}
