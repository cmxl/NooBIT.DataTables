using System.Collections.Generic;
using System.Linq;

namespace NooBIT.DataTables.Helpers
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> SearchBy<T>(this IQueryable<T> source, List<SearchInstruction<T>> instructions)
        {
            return Searcher.SearchBy(source, instructions);
        }
    }
}
