using System.Threading;
using System.Threading.Tasks;
using NooBIT.DataTables.Models;

namespace NooBIT.DataTables.Rendering
{
    public interface ITableRenderer
    {
        DataTable<T>.Table Render<T>(IDataTable<T> dataTable, DataTableResponse data) where T : class;
        Task<DataTable<T>.Table> Render<T>(IDataTable<T> dataTable, DataTableRequest request, CancellationToken token = default) where T : class;
    }
}