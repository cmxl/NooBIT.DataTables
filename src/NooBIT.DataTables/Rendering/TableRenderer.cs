using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NooBIT.DataTables.Models;

namespace NooBIT.DataTables.Rendering
{
    public class TableRenderer : ITableRenderer
    {
        public DataTable<T>.Table Render<T>(IDataTable<T> dataTable, DataTableResponse data) where T : class
        {
            var rows = new List<DataTable<T>.Row>();

            foreach (Dictionary<string, object> d in data.Data)
            {
                var row = new DataTable<T>.Row(dataTable);
                for (var i = 0; i < row.Columns.Length; i++)
                {
                    if (d.ContainsKey(row[i].Column.Name))
                    {
                        row[i].Value = d[row[i].Column.Name];
                    }
                }

                rows.Add(row);
            }

            var table = new DataTable<T>.Table(dataTable)
            {
                Rows = rows.ToArray(),
                TotalRecords = data.RecordsTotal,
                FilteredRecords = data.RecordsFiltered
            };
            return table;
        }

        public async Task<DataTable<T>.Table> Render<T>(IDataTable<T> dataTable, DataTableRequest request, CancellationToken token) where T : class
        {
            var data = await dataTable.GetAsync(request, token).ConfigureAwait(false);
            return Render(dataTable, data);
        }
    }
}