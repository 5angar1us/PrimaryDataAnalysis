using DataLoader.Parser;
using DataLoader.TypeChanger;
using DataLoader.Validator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;

namespace DataLoader
{
    public class Loader
    {
        private string _path;

        private ParseConfig _parseConfig;

        public Loader(string path)
        {
            _path = path;
            _parseConfig = new ParseConfig();
        }

        public Loader(string path, ParseConfig parseConfig)
        {
            _path = path;
            _parseConfig = parseConfig;
        }

        public DataTable GetData()
        {
            //Читаем
            var data = ReadDataCSV(_path);

            /* Убираем не валидные данные:
             * - пустые
             * - с ошибками
             */
           
            var validator = new DataValidator(data);
            validator.DeleteEmptyCells()
                .DeleteTypeMismatches();

            data = Sort(data);

            var validatorEm = new DataValidator(data);
            validatorEm.DeleteEmissions(0);

            //Находим тип
            var typeDefiner = new ColumnTypeChanger(data);
            data = typeDefiner.ChangeColumnType();

            return data;
        }

        private DataTable ReadDataCSV(string inputPath)
        {
            var dt = new DataTable();
            const int firstColumnIndex = 0;

            using (var reader = new StreamReader(inputPath))
            using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = _parseConfig.ColumnDelemiter;

                dt.Columns.Add();
                while (csv.Read())
                {
                    for (int i = 0; i < csv.Context.Record.Length; i++)
                    {
                        DataRow row = dt.NewRow();
                        row[firstColumnIndex] = csv.Context.Record[i];
                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }

        private DataTable Sort(DataTable dataTable)
        {
            const int firstColumn = 0;

            var data = new List<double>();
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                var cell = Convert.ToDouble(dataTable.Rows[i][firstColumn]);
                data.Add(cell);
            }
            data.Sort();

            DataTable sorted = new DataTable();
            sorted.Columns.Add();


            for (int i = 0; i < data.Count; i++)
            {
                DataRow row = sorted.NewRow();
                row[firstColumn] = data[i];
                sorted.Rows.Add(row);
            }
            return sorted;
        }
    }
}
