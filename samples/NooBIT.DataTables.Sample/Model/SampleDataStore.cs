using System.Collections.Generic;
using System.Linq;

namespace NooBIT.DataTables.Sample.Model
{
    public class SampleDataStore
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

        static SampleDataStore()
        {
            SampleData = Names.Select((name, index) => new SampleData {Id = index, Name = name}).ToList();
        }
    }
}