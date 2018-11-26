using System.Linq;

namespace NooBIT.DataTables.Queries
{
    public interface IDataSource<out T> where T : class
    {
        IQueryable<T> Get();
    }
}