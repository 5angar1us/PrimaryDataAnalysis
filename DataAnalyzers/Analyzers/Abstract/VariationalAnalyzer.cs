using DataAnalyzers.Helpers;
using DataAnalyzers.Data;
using System;

namespace DataAnalyzers.Analyzers.Abstract
{
    public abstract class VariationalAnalyzer
    {
        protected FrequencyRange[] _discreteFrequencyRange;

        //объем выборки
        protected BasicVariationSize basicVariationSize;
        //выборочное среднее
        protected double _sampleMean;

        public abstract VariationsIndicators CalculateVariationsIndicators();

        protected double GetAverageLinearDeviation()
        {
            //сумма ряда - |xi*xср| *mi
            //среднее линейное отклонение = сумма ряда / объем выборки
            var rangeSum = TheSumOfTheProductSeriesIsFrequentAndTheModulusOfTheDifferenceOptionsAndSampleAverage();
            return (double) rangeSum / basicVariationSize.SampleSize;
        }

        protected double GetstandardDeviation(double variance)
        {
            // Стандартное отклонение = Корень(Дисперсия)
            return Math.Sqrt(variance);
        }

        protected double GetDispersion()
        {
            // сумма ряда (xi-xср)^2*mi
            // дисперсия = сумма ряда / объем выборки

            var statistiCalcalculations = new StatistiCalcalculations(_discreteFrequencyRange, _sampleMean);
            var sumСompositionfrequencyInterval = statistiCalcalculations
                .TheSumOfTheSeriesOfTheProductIsFrequentAndTheDifferencesAreOptionsAndTheSampleAverageInDegree(2);

            return (double)sumСompositionfrequencyInterval / basicVariationSize.SampleSize;
        }

        protected double TheSumOfTheProductSeriesIsFrequentAndTheModulusOfTheDifferenceOptionsAndSampleAverage()
        {
            //ищет сумму ряда по формуле |Хi - Хср| * Mi
            double sum = 0;
            for (int i = 0; i < _discreteFrequencyRange.Length; i++)
            {
                var cell = _discreteFrequencyRange[i];
                //formula: |Хi - Хср| * Mi
                double a = GenericMath.Subtraction<double>(Convert.ToDouble(cell.Variation), _sampleMean);

                sum += Math.Abs(a) * cell.Frequency;
            }
            return sum;
        }
    }
}
