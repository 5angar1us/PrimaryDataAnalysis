using DataLoader.TypeChecker;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataLoader.Validator
{
    public class DataValidator
    {
        private DataTable _data;

        public DataValidator(DataTable data)
        {
            _data = data;
        }

        public DataValidator DeleteEmptyCells()
        {
            DeleteData(SearchEmptyCells());

            return this;
        }

        public DataValidator DeleteTypeMismatches()
        {
            DeleteData(SearchTypeMismatches());

            return this;
        }

        public DataValidator DeleteEmissions(int column)
        {
            DeleteData(SearchEmissionsInColumn(column));

            return this;
        }

        private void DeleteData(List<int> deleteIndexes)
        {
            for (int i = 0; i < deleteIndexes.Count; i++)
            {
                int currentIndex = deleteIndexes[i] - i;
                _data.Rows.RemoveAt(currentIndex);
            }
        }

        enum CalculationMod
        {
            Vertex,
            Brothers
        }

        private double CalculateMidle(CalculationMod calMod, int fashionIndex)
        {
            const int firstColumn = 0;

            double fashion;
            if (calMod == CalculationMod.Brothers)
            {

                double a = Convert.ToDouble(_data.Rows[fashionIndex - 1][firstColumn]);
                double b = Convert.ToDouble(_data.Rows[fashionIndex - 1 + 1][firstColumn]);
                fashion = (a + b) / 2;
            }
            else
            {
                fashion = Convert.ToDouble(_data.Rows[fashionIndex - 1][firstColumn]);
            }

            return fashion;
        }

        private int CalculateMidleIndex(CalculationMod calMod, int count)
        {
            int index;
            if (calMod == CalculationMod.Brothers)
            {
                index = count / 2;
            }
            else
            {
                index = count / 2 + 1;
            }
            return index;
        }

        private int Change(CalculationMod calMod, int index)
        {
            if (calMod == CalculationMod.Vertex)
                return index - 1;
            else
                return index;
        }

        private CalculationMod GetCalMode(int count)
        {
            CalculationMod result;
            if (count % 2 == 0)
            {
                result = CalculationMod.Brothers;
            }
            else
            {
                result = CalculationMod.Vertex;
            }
            return result;
        }


        private List<int> SearchEmissionsInColumn(int column)
        {
            var medianCalMod = GetCalMode(_data.Rows.Count);
            int medianIndex = CalculateMidleIndex(medianCalMod, _data.Rows.Count);
            double median = CalculateMidle(medianCalMod, medianIndex);
            int newMedianIndex = Change(medianCalMod, medianIndex);

            var quarterCalMod = GetCalMode(newMedianIndex);
            int lowerQuarterIndex = CalculateMidleIndex(quarterCalMod, newMedianIndex);
            double lowerQuarter = CalculateMidle(quarterCalMod, lowerQuarterIndex);

            int upperQuarterIndex = medianIndex + CalculateMidleIndex(quarterCalMod, newMedianIndex);
            double upperQuarter = CalculateMidle(quarterCalMod, upperQuarterIndex);

            double interQuarterRange = upperQuarter - lowerQuarter;

            const double innerBorderCoeff = 3;

            double lowerInnerBorder = lowerQuarter - interQuarterRange * innerBorderCoeff;
            double upperInnerBorder = upperQuarter + interQuarterRange * innerBorderCoeff;


            var removeIndex = new List<int>();
            for (int rowIndex = 0; rowIndex < _data.Rows.Count; rowIndex++)
            {
                var row = _data.Rows[rowIndex];
                var cell = Convert.ToDouble(row[column]);
                if (cell < lowerInnerBorder | cell > upperInnerBorder)
                {
                    removeIndex.Add(rowIndex);
                }
            }
            return removeIndex;
        }

        private List<int> SearchEmptyCells()
        {
            var removeIndex = new List<int>();
            for (int rowIndex = 0; rowIndex < _data.Rows.Count; rowIndex++)
            {
                var emptyCells = new List<Boolean>();
                var row = _data.Rows[rowIndex];

                for (int cellIndex = 0; cellIndex < row.ItemArray.Length; cellIndex++)
                {
                    var cell = row[cellIndex].ToString().Trim();
                    var isEmpty = cell.Length == 0;
                    emptyCells.Add(isEmpty);
                }

                if (emptyCells.Contains(true))
                {
                    removeIndex.Add(rowIndex);
                }
            }
            return removeIndex;
        }

        private List<int> SearchTypeMismatches()
        {
            var typeChecker = new DataTypeChecker();
            var removeIndex = new List<int>();
            for (int rowIndex = 0; rowIndex < _data.Rows.Count; rowIndex++)
            {
                var cellTypes = new List<Type>();
                var row = _data.Rows[rowIndex];

                for (int cellIndex = 0; cellIndex < row.ItemArray.Length; cellIndex++)
                {
                    var cell = row[cellIndex].ToString();
                    cellTypes.Add(typeChecker.DefineType(cell));
                }

                if (cellTypes.Contains(null))
                {
                    removeIndex.Add(rowIndex);
                }
            }
            return removeIndex;
        }
    }
}
