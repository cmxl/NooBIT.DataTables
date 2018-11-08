using System.Linq;

namespace NooBIT.DataTables.Queries
{
    public interface IQueryableRequestService<out T> where T : class
    {
        IQueryable<T> Get();
    }
}