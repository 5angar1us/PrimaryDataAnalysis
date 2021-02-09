using System.Collections.Generic;

namespace PrimaryDataAnalysis.Repots
{
    class IntervalItemName : ItemName
    {
        public IntervalItemName()
        {
            ChartName = new List<string>()
            {
                "Кумулята",
                "Кумулятивная кривая"
            };
        }
    }
}
