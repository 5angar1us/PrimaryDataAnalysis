using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Data;

namespace DataAnalyzers.Analyzers.Interval
{
    class IntervalDistributionCenterAnalyzer : IDistributionCenterAnalyzer
    {
        private IntervalFrequencyRange[] _iFR;
        //средняя величина
        private BasicVariationSize _variationSizeIndicators;

        public IntervalDistributionCenterAnalyzer(
            IntervalFrequencyRange[] intervalFrequencyRanges,
            BasicVariationSize variationSizeIndicators)
        {
            _iFR = intervalFrequencyRanges;
            _variationSizeIndicators = variationSizeIndicators;
        }

        public DistributionCenterData CalculateDistributionCenterData()
        {
            // Мода
            double fashion = CalculateFashion();

            // Медиана
            double median = CalculateMedian();

            // Средняя величина
            double sampleMean = CalculateSampleMean();

            return new DistributionCenterData(fashion, median, sampleMean);
        }

        

        private double CalculateSampleMean()
        {
            int sampleSize = _variationSizeIndicators.SampleSize;
            //Находим сумму ряда   
            double compositionSum = 0;
            for (int i = 0; i < _iFR.Length; i++)
            {
                var cell = _iFR[i];
                //formula: Xi * Mi
                compositionSum += cell.Variation * cell.Frequency;
            }
            // Cредняя величина = cумма ряда  / средняя величина
            double sampleMean = (double)compositionSum / sampleSize;

            return sampleMean;
        }

        private double CalculateMedian()
        {
            // ==== Поиск медианного интервала через относительную частоту ====
            const double accuracy = 0.0001;
            const double midFrequencyPercent = 0.5;

            int sampleSize = _variationSizeIndicators.SampleSize;

            double relativeFrequency = 0;
            //накопленная частота в пред медианном интервале S(med-1)
            double prevRelativeFrequency = 0;
            int medianIntervalIndex = -1;

            for (int i = 0; i < _iFR.Length; i++)
            {
                var frequency = _iFR[i].Frequency;

                relativeFrequency += (double)frequency / sampleSize;

                if (relativeFrequency > midFrequencyPercent - accuracy)
                {
                    medianIntervalIndex = i;
                    break;
                }
                prevRelativeFrequency += frequency;
            }

            // ==== Поиск моды ====

            //X
            var leftMedianBorder = _iFR[medianIntervalIndex].Intervals.Left;

            //h
            var medianIntervalWidth = _iFR[medianIntervalIndex].Intervals.Right 
                - _iFR[medianIntervalIndex].Intervals.Left;

            //Частота медианного интервала (Fmed)
            var medianIntervalFrequency = _iFR[medianIntervalIndex].Frequency;

            //Сумма частот вариационного ряда
            int frequencySum = 0;
            for(int i = 0; i < _iFR.Length; i++)
            {
                frequencySum += _iFR[i].Frequency;
            }

            /*
             *                0.5 * Fsum - S(med-1)
             *  Мода = x + h  ______________________
             *                       fmed
             */
            var a = 0.5 * frequencySum - prevRelativeFrequency;
            var b = a / medianIntervalFrequency;
            var median = leftMedianBorder + medianIntervalWidth * b;

            return median;
        }

        private double CalculateFashion()
        {
            // ==== Поиск модального интервала ====
            int modalIntervalIndex = -1;
            int maxFrequency = -1;

            for (int i = 0; i < _iFR.Length; i++)
            {
                var cell = _iFR[i];

                if (maxFrequency < cell.Frequency)
                {
                    maxFrequency = cell.Frequency;
                    modalIntervalIndex = i;
                }
            }

            // ==== Поиск моды ====

            //X0
            var leftIntervalBorder = _iFR[modalIntervalIndex].Intervals.Left;

            //h
            var modalIntervalWidth = _iFR[modalIntervalIndex].Intervals.Right - _iFR[modalIntervalIndex].Intervals.Left;

            var modalFrequency = _iFR[modalIntervalIndex].Frequency;
            var prevModalFrequency = _iFR[modalIntervalIndex - 1].Frequency;
            var follModalFrequency = _iFR[modalIntervalIndex + 1].Frequency;

            //F(modal) - F(modal-1)
            var a = modalFrequency - prevModalFrequency;

            /*
             * F - частота
             *                                 F(modal) - F(modal-1)
             * Мода = X0 + h * __________________________________________________
             *                  (F(modal) - F(modal-1)) + (F(modal) - F(modal+1))  
             * 
             */
            var b = a + (modalFrequency - follModalFrequency);
            var c = (double)a / b;

            var fashion = leftIntervalBorder + modalIntervalWidth * c;

            return fashion;
        }
    }
}
