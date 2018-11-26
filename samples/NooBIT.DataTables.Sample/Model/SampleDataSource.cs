using System.Linq;
using NooBIT.DataTables.Queries;

namespace NooBIT.DataTables.Sample.Model
{
    public class SampleDataSource : IDataSource<SampleData>
    {
        private static readonly string[] _names =
        {
            "Adam",
            "Aaron",
            "John",
            "Jane",
            "Phoebe",
            "Jones",
            "Richard",
            "Brian",
            "Ryan",
            "Axel",
            "Alex",
            "Sandra",
            "Sarah",
            "Phoebe"
        };

        public IQueryable<SampleData> Get()
        {
            return _names
                .Select((name, index) => new SampleData { Id = index, Name = name })
                .AsQueryable();
        }
    }
}