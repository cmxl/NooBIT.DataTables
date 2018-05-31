﻿using System.Collections.Generic;
using NooBIT.DataTables.Models;

namespace NooBIT.DataTables.Rendering
{
    public class TableRenderer : ITableRenderer
    {
        public DataTable<TEntity>.Table Render<TEntity>(IDataTable<TEntity> dataTable, AjaxDataViewModel data) where TEntity : class
        {
            var rows = new List<DataTable<TEntity>.Row>();

            foreach (Dictionary<string, object> d in data.Data)
            {
                var row = new DataTable<TEntity>.Row(dataTable);
                for (var i = 0; i < row.Columns.Count; i++)
                {
                    if (d.ContainsKey(row[i].Column.Name))
                    {
                        row[i].Value = d[row[i].Column.Name];
                    }
                }

                rows.Add(row);
            }

            var table = new DataTable<TEntity>.Table(dataTable)
            {
                Rows = rows.ToArray(),
                TotalRecords = data.RecordsTotal,
                FilteredRecords = data.RecordsFiltered
            };
            return table;
        }
    }
}