using DataAnalyzers.Analyzers.Abstract;
using DataAnalyzers.Data;

namespace DataAnalyzers.Analyzers.Discrete
{
    public class DiscreteVariationalAnalyzer : VariationalAnalyzer
    {
        public DiscreteVariationalAnalyzer(
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

            var discreteVariationRangeAnalyzer = new DiscreteVariationRangeAnalyzer(basicVariationSize);
            int variationRange = (int)discreteVariationRangeAnalyzer.CalculateVariationRange();
           
            return new VariationsIndicators((double)variationRange,dispersion, standardDeviation, averageLinearDeviation);
        }

    }
}
