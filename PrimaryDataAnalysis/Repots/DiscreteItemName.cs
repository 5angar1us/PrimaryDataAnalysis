using System.Collections.Generic;

namespace PrimaryDataAnalysis.Repots
{
    class DiscreteItemName : ItemName
    {
        public DiscreteItemName()
        {
            ChartName = new List<string>()
            {
                "Полигон",
                "Кумулятивная кривая"
            };
        }
    }
}
