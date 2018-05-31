using System;
using System.Security.Principal;
using NooBIT.DataTables.Models;

namespace NooBIT.DataTables
{
    public class DataTableErrorEventArgs : EventArgs
    {
        public DataTableErrorEventArgs(AjaxProcessingViewModel vm, Exception exception) : this(vm, null, exception)
        {
        }

        public DataTableErrorEventArgs(AjaxProcessingViewModel vm, IPrincipal principal, Exception exception)
        {
            AjaxProcessingViewModel = vm;
            Principal = principal;
            Exception = exception;
        }

        public AjaxProcessingViewModel AjaxProcessingViewModel { get; }
        public Exception Exception { get; }
        public IPrincipal Principal { get; }
    }
}