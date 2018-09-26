using System.Linq;

namespace NooBIT.DataTables.Queries
{
    public interface IQueryableRequestService<out TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get();
    }
}