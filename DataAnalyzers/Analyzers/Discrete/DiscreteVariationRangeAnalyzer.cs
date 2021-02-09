using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Data;
using System;

namespace DataAnalyzers.Analyzers.Discrete
{
    class DiscreteVariationRangeAnalyzer : IVariationRangeAnalyzer
    {
        private BasicVariationSize _variationSizeIndicators;

        public DiscreteVariationRangeAnalyzer(BasicVariationSize variationSizeIndicators)
        {
            _variationSizeIndicators = variationSizeIndicators;
        }

        public double CalculateVariationRange()
        {
            return Convert.ToInt32(_variationSizeIndicators.Max) - Convert.ToInt32(_variationSizeIndicators.Min);
        }
    }
}
