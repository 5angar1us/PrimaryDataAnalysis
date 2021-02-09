using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Data;

namespace DataAnalyzers.Analyzers.Interval
{
    class IntervalVariationRangeAnalyzer : IVariationRangeAnalyzer
    {
        private BasicVariationSize _variationSizeIndicators;

        public IntervalVariationRangeAnalyzer(BasicVariationSize variationSizeIndicators)
        {
            _variationSizeIndicators = variationSizeIndicators;
        }

        public double CalculateVariationRange()
        {
            return _variationSizeIndicators.Max - _variationSizeIndicators.Min;
            
        }
    }
}
