using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DataLoader.Parser
{
    public class CSVParser : IParser
    {
        private ParseConfig _parseConfig;

        public CSVParser()
        {
            _parseConfig = new ParseConfig();
        }

        public CSVParser( ParseConfig parseConfig)
        {
            _parseConfig = parseConfig;
        }

        public DataTable Parse(string path)
        {
            var rows = LoadData(path);
            var data = SplitIntoCells(rows);
            return data;
        }

        private List<string> LoadData(string path)
        {
            var rows = new List<string>();
            using (var reader = new StreamReader(path))
            {
                reader.Read();
                while (reader.Peek()>=0)
                {
                    var x = reader.ReadLine();
                    rows.Add(x);
                }
            }
            return rows;
        }

        private DataTable SplitIntoCells(List<string> rows)
        {
            var data = new DataTable();

            var cells = rows[0].Split(new String[] { _parseConfig.ColumnDelemiter }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < cells.Length; i++)
            {
                data.Columns.Add();
            }
            data.Rows.Add(cells);

            for (int i = 1; i < rows.Count; i++)
            {
                cells = rows[i].Split(new String[] { _parseConfig.ColumnDelemiter }, StringSplitOptions.RemoveEmptyEntries);
                data.Rows.Add(cells);
            }

            return data;
        }
    }
}
