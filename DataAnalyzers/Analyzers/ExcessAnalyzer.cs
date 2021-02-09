using DataAnalyzers.Helpers;
using DataAnalyzers.Data;
using System;

namespace DataAnalyzers.Analyzers
{
    public class ExcessAnalyzer
    {
        private FrequencyRange[] _discreteFrequencyRange;
        private double _sampleMean;
        private double _standardDeviation;
        private int _sampleSize;

        public ExcessAnalyzer(
            FrequencyRange[] discreteFrequencyRange,
            double sampleMean,
            double standardDeviation,
            int sampleSize)
        {
            _discreteFrequencyRange = discreteFrequencyRange;
            _sampleMean = sampleMean;
            _standardDeviation = standardDeviation;
            _sampleSize = sampleSize;
        }

        public ExcessData CalculateExcessData()
        {
            double excess = GetExcess();
            double standardError = GetExcessStandardError();

            return new ExcessData(excess, standardError);
        }

        private double GetExcessStandardError()
        {
            /* N - sampleMean
             * 
             *        _____________________________________
             *       /
             *      /    24 * N * (N - 2) * (N - 3)
             * -   /  -----------------------------------
             *   \/       (N - 1)^2 * (N + 3) * (N + 5)
             * 
             * 
             */

            //Вычисления корней нужны для того чтобы не выйти за границы допустимых значений типа
            var N = _sampleSize;

            var a = Math.Sqrt(24 * N);
            var b = Math.Sqrt((N - 2) * (N - 3));

            var c = Math.Sqrt(Math.Pow(N - 1, 2));
            var d = Math.Sqrt((N + 3) * (N + 5));

            return (a * b) / (c * d);
        }

        private double GetExcess()
        {
            // сумма ряда (xi-xср)^2*mi
            // эксцесс = сумма ряда / (среднеквадратическое_отклонение^4 * объём выборки)

            var statistiCalcalculations = new StatistiCalcalculations(_discreteFrequencyRange, _sampleMean);
            var sumСompositionfrequencyInterval = statistiCalcalculations.
                TheSumOfTheSeriesOfTheProductIsFrequentAndTheDifferencesAreOptionsAndTheSampleAverageInDegree(4);

            return sumСompositionfrequencyInterval / (_sampleSize * Math.Pow(_standardDeviation, 4)) - 3;
        }
    }
}
