using System;
using System.Collections.Generic;
using System.Data;
using DataLoader.TypeChecker;

namespace DataLoader.TypeChanger
{
    public class ColumnTypeChanger
    {
        private DataTable _table;

        private DataTypeChecker _typeChecker;

        public ColumnTypeChanger(DataTable table)
        {
            _table = table;
            _typeChecker = new DataTypeChecker();
        }

        public DataTable ChangeColumnType()
        {
            List<Type> columnTypes = DefineColumnTypes();
            var resultTable = new DataTable();

            for (int i = 0; i < _table.Columns.Count; i++)
            {
                resultTable.Columns.Add();
                resultTable.Columns[i].DataType = columnTypes[i];
            }

            for (int i = 0; i < _table.Rows.Count; i++)
            {
                resultTable.Rows.Add(_table.Rows[i].ItemArray);
            }

            return resultTable;
        }

        private List<Type> DefineColumnTypes()
        {
            var columnTypes = new List<Type>();

            for (int i = 0; i < _table.Columns.Count; i++)
            {
                var column = _table.Columns[i];
                var cellData = _table.Rows[0].ItemArray[i].ToString();

                columnTypes.Add(_typeChecker.DefineType(cellData));
            }
            return columnTypes;
        }
    }
}
