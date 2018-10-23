using System;

namespace ExcelTools.Meta.Worksheet
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Include : Attribute
    {
        public int Offset { get; set; }

        public Include(int offset = 0)
        {
            Offset = offset;
        }
    }
}