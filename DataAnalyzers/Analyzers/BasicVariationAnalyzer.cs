using DataAnalyzers.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAnalyzers.Analyzers
{
    public class BasicVariationAnalyzer
    {
        private List<Double> _data;

        public BasicVariationAnalyzer(List<Double> data)
        {
            _data = data;
        }

        public BasicVariationSize CalculateBasicVariationData()
        {
            //объём выборки
            int sampleSize = _data.Count;
            Double max = _data.Max<Double>();
            Double min = _data.Min<Double>();


            return new BasicVariationSize(sampleSize, max, min);
        }
    }
}
