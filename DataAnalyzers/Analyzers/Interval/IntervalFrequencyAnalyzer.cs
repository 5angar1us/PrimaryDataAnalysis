using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAnalyzers.Analyzers.Interval
{
    class IntervalFrequencyAnalyzer : IFrequencyAnalyzer
    {
        private List<double> _data;

        public IntervalFrequencyAnalyzer(List<double> data)
        {
            _data = data;
        }

        public IntervalFrequencyRange[] CalculateFrequencyRange()
        {
            double max = _data.Max<double>();
            double min = _data.Min<double>();

            // Интервалы
            Intervals[] intervals = CalculateIntervals(min, max);

            //Середины интервалов
            double[] intervalsMid = CalcalateIntervalsMid(intervals);

            //Находим частоты
            var frequencies = CalculateFrequencies(intervals);

            var IntervalfrequencyRange = new IntervalFrequencyRange[intervalsMid.Length];
            for (int i = 0; i < IntervalfrequencyRange.Length; i++)
            {
                IntervalfrequencyRange[i] = new IntervalFrequencyRange(intervals[i], intervalsMid[i], frequencies[i]);
            }

            return IntervalfrequencyRange;
        }

        private static double[] CalcalateIntervalsMid(Intervals[] intervals)
        {

            // Находим середины интервалов
            var intervalsMid = new double[intervals.Length];
            for (int i = 0; i < intervalsMid.Length; i++)
            {
                var interval = intervals[i];
                intervalsMid[i] = (interval.Left + interval.Right) / 2;
            }

            return intervalsMid;
        }

        private Intervals[] CalculateIntervals(double min, double max)
        {
            // округление вниз = (int)(число) отбрасывает дробную часть
            int intervalNumber = (int)(1 + (3.32 * Math.Log10(_data.Count)));

            double intervalLength = (max - min) / intervalNumber;

            // Находим интервалы
            var intervals = new Intervals[intervalNumber];


            intervals[0] = new Intervals(min, min + intervalLength);
 
            for (int i = 1; i < intervals.Length; i++)
            {
                var preInterval = intervals[i - 1];


                intervals[i] = new Intervals(preInterval.Right, preInterval.Right + intervalLength);
            }

            return intervals;
        }

        private int[] CalculateFrequencies(Intervals[] intervals)
        {
            //Поиск частот

            //Данные должны быть отсортированны для работы алгоритма
            _data.Sort();

            //Смещение интервалы, чтобы вариация, которая равна интервалу, попадала в следующий интервал
            const double offset = 0.00000000000001;

            //За один проход по данным подсчитывается частоты для каждой вариации
            int[] frequencies = new int[intervals.Length];

            int intervalIndex = 0;
            double rightInterval = intervals[intervalIndex].Right - offset;
            for (int i = 0; i < _data.Count; i++)
            {
                var cell = _data[i];
                //var a = cell + offset;

                if (cell < rightInterval)
                {
                    frequencies[intervalIndex] += 1;
                }
                else
                {
                    if (intervalIndex + 1 < intervals.Length)
                    {
                        intervalIndex++;
                        rightInterval = intervals[intervalIndex].Right - offset;
                    }
                    frequencies[intervalIndex] += 1;
                }
            }
            return frequencies;
        }


    }
}
