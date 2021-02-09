using System;
using System.Collections.Generic;
using System.Data;

namespace PrimaryDataAnalysis.Helpers
{
    static class DataTableConverter
    {
        public static List<double> ConvertToList(DataTable dataTable)
        {
            const int firstColumn = 0;
            var result = new List<double>(dataTable.Rows.Count);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var cell = Convert.ToDouble(dataTable.Rows[i].ItemArray[firstColumn]);
                result.Add(cell);
            }
            return result;
        }

    }
}
