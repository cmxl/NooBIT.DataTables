using System;

namespace NooBIT.DataTables.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ColumnOrderAttribute : Attribute
    {
        public ColumnOrderAttribute(int order)
        {
            Order = order;
        }

        public int Order { get; }
    }
}
