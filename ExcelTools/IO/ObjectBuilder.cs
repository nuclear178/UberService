using OfficeOpenXml;

namespace ExcelTools.IO
{
    public class ObjectBuilder<T> where T : new()
    {
        private readonly ObjectSchema _schema;

        public ObjectBuilder(ObjectSchema schema)
        {
            _schema = schema;
        }

        public T Build(ExcelRange cells, int rowIndex)
        {
            var obj = new T();
            foreach (ColumnOptions column in _schema)
            {
                int columnIndex = column.Index;
            }

            return obj;
        }
    }
}