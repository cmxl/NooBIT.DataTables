# NooBIT.DataTables

NooBIT.DataTables provides functionality to process ajax requests from https://datatables.net javascript framework v1.10.x

---


[![Build status](https://ci.appveyor.com/api/projects/status/na5puqlx286872l3/branch/master?svg=true)](https://ci.appveyor.com/project/cmxl/noobit-datatables/branch/master)


---

## Usage

Implement your custom table like this:

```csharp
    public class EmployeeTable : DataTable<Employee>
    {
        public EmployeeTable(IQueryableService<Employee> queryableService) : base(queryableService)
        {
        }

        protected override Task<IQueryable<Employee>> WhereAsync(IQueryable<Employee> query, AjaxProcessingViewModel vm, AjaxColumn column, CancellationToken token)
        {
            // add your filtering here
            switch(column.Name?.ToLower())
            {
                case "name":
                    if(IsSearchable(vm.Search, column, out string name))
                    {
                        return Task.FromResult(query.Where(x => x.Name.Contains(name)));
                    }
                    break;

                case "id":
                    if(IsSearchable(vm.Search, column, out int id))
                    {
                        return Task.FromResult(query.Where(x => x.Id == id);
                    }
                    break;
            }

            return Task.FromResult(query);
        }
    }
```

You need some columnDefs for datatables options.
You can override the default:

```csharp
    public class EmployeeTable : DataTable<Employee>
    {
        // [...]
        
        protected override Column GetColumnTemplate(PropertyInfo x, int index)
        {
            return new Column(this)
            {
                Header = new Header {DisplayName = x.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? x.Name},
                Name = x.Name,
                Orderable = true,
                Orders = new[]
                {
                    new Column.Order
                    {
                        ColumnName = x.Name
                    }
                },
                Render = (o, item) => o,
                Searchable = true,
                Target = index
            };
        }
    }
```

Or if you want complete control over column generation:

```csharp
    public class EmployeeTable : DataTable<Employee>
    {
        // [...]
        
        public override List<Column> GetColumns()
        {
            return typeof(TEntity)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Select(GetColumnTemplate)
                .ToList();
        }
    }
```
