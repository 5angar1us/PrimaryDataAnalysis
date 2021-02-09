using DataAnalyzers.Analyzers.Abstract;
using DataAnalyzers.Data;

namespace DataAnalyzers.Analyzers.Interval
{
    class IntervalVariationalAnalyzer : VariationalAnalyzer
    {
        public IntervalVariationalAnalyzer(
            FrequencyRange[] discreteFrequencyRange,
            BasicVariationSize basicVariationSize,
            double sampleMean)
        {
            _discreteFrequencyRange = discreteFrequencyRange;
            this.basicVariationSize = basicVariationSize;
            _sampleMean = sampleMean;
        }

        public override VariationsIndicators CalculateVariationsIndicators()
        {
            //Дисперсия
            double dispersion = GetDispersion();
            //Среднеквадратическое отклонение
            double standardDeviation = GetstandardDeviation(dispersion);
            //среднее линейное отклонение
            double averageLinearDeviation = GetAverageLinearDeviation();

            var intervaVariationRangeAnalyzer = new IntervalVariationRangeAnalyzer(basicVariationSize);
            double variationRange = intervaVariationRangeAnalyzer.CalculateVariationRange();

            return new VariationsIndicators(variationRange,dispersion, standardDeviation, averageLinearDeviation);
        }
    }
}
