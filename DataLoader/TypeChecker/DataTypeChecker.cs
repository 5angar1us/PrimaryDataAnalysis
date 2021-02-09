using System;

namespace DataLoader.TypeChecker
{
    public class DataTypeChecker
    {
        public DataTypeChecker()
        {

        }

        public Type DefineType(String cellData)
        {
            Type type = null;

            if (int.TryParse(cellData, out int i32))
                type = typeof(int);

            else if (double.TryParse(cellData, out double d))
                type = typeof(double);

            return type;
        }
    }
}
