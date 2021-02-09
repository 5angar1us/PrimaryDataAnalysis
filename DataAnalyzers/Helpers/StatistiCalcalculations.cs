using DataAnalyzers.Data;
using System;

namespace DataAnalyzers.Helpers
{
    //Responsible for repetitive statistical calculations
    class StatistiCalcalculations
    {
        //TheSumOfTheSeriesOfTheProductIsFrequentAndTheDifferencesAreOptionsAndTheSampleAverageInDegree
        private FrequencyRange[] _discreteFrequencyRange;
        private double _sampleMean;

        public StatistiCalcalculations(FrequencyRange[] discreteFrequencyRange, double sampleMean)
        {
            _discreteFrequencyRange = discreteFrequencyRange;
            _sampleMean = sampleMean;
        }

        //Finds the amount for calculations by the formula
        public double TheSumOfTheSeriesOfTheProductIsFrequentAndTheDifferencesAreOptionsAndTheSampleAverageInDegree(int pow)
        {
            double sum = 0;
            for (int i = 0; i < _discreteFrequencyRange.Length; i++)
            {
                var cell = _discreteFrequencyRange[i];

                //formula: (Xi - Xср)^Pow * Mi
                double a = cell.Variation - _sampleMean;
                sum += Math.Pow( a, pow) * cell.Frequency;
            }
            return sum;
        }
    }
}
