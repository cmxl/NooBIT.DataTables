using NooBIT.DataTables.Models;

namespace NooBIT.DataTables.Rendering
{
    public interface ITableRenderer
    {
        DataTable<TEntity>.Table Render<TEntity>(IDataTable<TEntity> dataTable, DataTableResponse data) where TEntity : class;
    }
}