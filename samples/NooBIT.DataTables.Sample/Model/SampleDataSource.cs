using System.Collections.Generic;
using System.Linq;
using NooBIT.DataTables.Queries;

namespace NooBIT.DataTables.Sample.Model
{
    public class SampleDataSource : IDataSource<SampleData>
    {
        private static readonly string[] Names =
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

        public static readonly List<SampleData> SampleData;

        static SampleDataSource()
        {
            SampleData = Names.Select((name, index) => new SampleData {Id = index, Name = name}).ToList();
        }

        public IQueryable<SampleData> Get()
        {
            return SampleData.AsQueryable();
        }
    }
}