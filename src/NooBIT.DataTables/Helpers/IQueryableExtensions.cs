using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
