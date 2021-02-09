using DataAnalyzers.Data;

namespace DataAnalyzers.Analyzers
{
    public class RelativeIndicatorsAnalyzer
    {
        private double _standardDeviation;
        private double _averageLinearDeviation;
        private double _variationRange;
        private double _SampleMean;

        public RelativeIndicatorsAnalyzer(
            double standardDeviation, 
            double averageLinearDeviation, 
            double variationRange, 
            double SampleMean)
        {
            _standardDeviation = standardDeviation;
            _averageLinearDeviation = averageLinearDeviation;
            _variationRange = variationRange;
            _SampleMean = SampleMean;
        }

        public RelativeIndicators CalculateRelativeIndicators()
        {
            //Коэффициент вариации
            double variationCoeff = _standardDeviation / _SampleMean * 100;

            //Линейный коэффициент вариации
            double variationlinearСoeff = _averageLinearDeviation / _SampleMean * 100;

            //Коэффициент осцилляции
            double oscillationCoeff = _variationRange / _SampleMean * 100;

            return new RelativeIndicators(variationCoeff, variationlinearСoeff, oscillationCoeff);
        }
    }
}
