using System;

namespace DataAnalyzers.Helpers
{
    static class DoubleExtensions
    {
        public static bool EqualTo(this double value1, double value2, double epsilon)
        {
            return Math.Abs(value1 - value2) < epsilon;
        }
    }
}
