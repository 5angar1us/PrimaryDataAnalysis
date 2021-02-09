using DataAnalyzers.Helpers;
using DataAnalyzers.Data;
using System;

namespace DataAnalyzers.Analyzers
{
    public class AsymmetryAnalyzer 
    {
        private FrequencyRange[] _discreteFrequencyRange;
        private double _sampleMean;
        private int _sampleSize;
        private double _standardDeviation;

        public AsymmetryAnalyzer(
            FrequencyRange[] discreteFrequencyRange, 
            double sampleMean, 
            int sampleSize, 
            double standardDeviation)
        {
            _discreteFrequencyRange = discreteFrequencyRange;
            _sampleMean = sampleMean;
            _sampleSize = sampleSize;
            _standardDeviation = standardDeviation;
        }

        public AsymmetryData CalculateAsymmetryData()
        {
            double asymmetry = GetAsymmetry();
            double standardError = GetAsymmetryStandartError();
            return new AsymmetryData(asymmetry, standardError);
        }

        private double GetAsymmetryStandartError()
        {
            /* N - sampleMean
             * 
             *        ________________________
             *       /
             *      /       6 * ( N - 1 )         
             *  -  /  -------------------------- 
             *   \/     (N + 1 ) * ( N + 3)
             *   
             */

             //Вычисления корней нужны для того чтобы не выйти за границы допустимых значений типа
            var N = _sampleSize;

            double a = Math.Sqrt(6 * (N - 1));
            double b = Math.Sqrt(N + 1) * Math.Sqrt(N + 3);

            double c = a / b;

            return c;
        }

        private double GetAsymmetry()
        {
            //нормированный моментный коэффициент асимметрии

            // сумма ряда (xi-xср)^2*mi
            // асиметрия = сумма ряда / (среднеквадратическое_отклонение^3 * объём выборки)

            var statistiCalcalculations = new StatistiCalcalculations(_discreteFrequencyRange, _sampleMean);
            var sumСompositionfrequencyInterval = statistiCalcalculations.
                TheSumOfTheSeriesOfTheProductIsFrequentAndTheDifferencesAreOptionsAndTheSampleAverageInDegree(3);

            return sumСompositionfrequencyInterval / (_sampleSize * Math.Pow(_standardDeviation, 3));
        }
    }
}
