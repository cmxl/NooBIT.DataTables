using NooBIT.DataTables.Models;

namespace NooBIT.DataTables.Rendering
{
    public interface ITableRenderer
    {
        DataTable<T>.Table Render<T>(IDataTable<T> dataTable, DataTableResponse data) where T : class;
    }
}