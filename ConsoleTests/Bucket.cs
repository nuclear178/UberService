using ExcelTools.Meta.Worksheet;

namespace ConsoleTests
{
    public class Bucket
    {
        [Column(1)] public int Prop1 { get; set; }
        [Include(1)] public Name Prop2 { get; set; }
    }
}