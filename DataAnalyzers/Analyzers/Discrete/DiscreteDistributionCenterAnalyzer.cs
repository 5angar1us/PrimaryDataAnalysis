using System;
using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Data;

namespace DataAnalyzers.Analyzers.Discrete
{
    class DiscreteDistributionCenterAnalyzer : IDistributionCenterAnalyzer
    {
        private FrequencyRange[] _discreteFrequencyRanges;
        //средняя величина
        private BasicVariationSize _variationSizeIndicators;

        public DiscreteDistributionCenterAnalyzer(
            FrequencyRange[] discreteFrequencyRanges, 
            BasicVariationSize variationSizeIndicators)
        {
            _discreteFrequencyRanges = discreteFrequencyRanges;
            _variationSizeIndicators = variationSizeIndicators;
        }

        public DistributionCenterData CalculateDistributionCenterData()
        {
            // Мода
            int fashion = CalculateFashion();

            // Медиана
            int median = CalculateMedian();

            // Средняя величина
            double sampleMean = CalculateSampleMean();

            return new DistributionCenterData(fashion, median, sampleMean);
        }

        private int CalculateVariationRange()
        {
            return Convert.ToInt32(_variationSizeIndicators.Max) - Convert.ToInt32(_variationSizeIndicators.Min);
        }

        private double CalculateSampleMean()
        {
            int sampleSize = _variationSizeIndicators.SampleSize;

            //Находим сумму ряда   
            int compositionSum = 0;
            for (int i = 0; i < _discreteFrequencyRanges.Length; i++)
            {
                var cell = _discreteFrequencyRanges[i];

                int variation = Convert.ToInt32(cell.Variation);
                //formula: Xi * Mi

                compositionSum += variation * cell.Frequency;
            }
            // Cредняя величина = cумма ряда  / средняя величина
            double sampleMean = (double) compositionSum / sampleSize;

            return sampleMean;
        }

        private int CalculateMedian()
        {
            int sampleSize = _variationSizeIndicators.SampleSize;

            //Поиск медианы через относительную частоту
            double relativeFrequency = 0;
            int median = -1;

            for (int i = 0; i < _discreteFrequencyRanges.Length; i++)
            {
                var frequency = _discreteFrequencyRanges[i].Frequency;
                
                relativeFrequency = (double) frequency / sampleSize + relativeFrequency;

                if (relativeFrequency > 0.5)
                {
                    median = Convert.ToInt32(_discreteFrequencyRanges[i].Variation);
                    break;
                }
            }

            return median;
        }

        private int CalculateFashion()
        {
            //Поиск вариации с максимальным значением частоты
            int maxVariationIndex = -1;
            int maxFrequency = -1;

            for (int i = 0; i < _discreteFrequencyRanges.Length; i++)
            {
                var cell = _discreteFrequencyRanges[i];

                if (maxFrequency < cell.Frequency)
                {
                    maxFrequency = cell.Frequency;
                    maxVariationIndex = i;
                }
            }

            return Convert.ToInt32(_discreteFrequencyRanges[maxVariationIndex].Variation);
        }
    }
}
