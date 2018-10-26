using System;
using System.Security.Principal;
using NooBIT.DataTables.Models;

namespace NooBIT.DataTables
{
    public class DataTableErrorEventArgs : EventArgs
    {
        public DataTableErrorEventArgs(DataTableRequest request, Exception exception) : this(request, null, exception)
        {
        }

        public DataTableErrorEventArgs(DataTableRequest request, IPrincipal principal, Exception exception)
        {
            DataTableRequest = request;
            Principal = principal;
            Exception = exception;
        }

        public DataTableRequest DataTableRequest { get; }
        public Exception Exception { get; }
        public IPrincipal Principal { get; }
    }
}