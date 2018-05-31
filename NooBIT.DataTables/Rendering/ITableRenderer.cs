using NooBIT.DataTables.Models;

namespace NooBIT.DataTables.Rendering
{
    public interface ITableRenderer
    {
        DataTable<TEntity>.Table Render<TEntity>(IDataTable<TEntity> dataTable, AjaxDataViewModel data) where TEntity : class;
    }
}