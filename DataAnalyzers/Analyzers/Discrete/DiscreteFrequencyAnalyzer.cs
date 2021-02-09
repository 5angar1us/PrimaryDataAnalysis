using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAnalyzers.Analyzers.Discrete
{
    class DiscreteFrequencyAnalyzer : IFrequencyAnalyzer
    {
        private List<double> _data;

        public DiscreteFrequencyAnalyzer(List<double> data)
        {
            _data = data;
        }

        public IntervalFrequencyRange[] CalculateFrequencyRange()
        {
            int max = Convert.ToInt32(_data.Max<double>());
            int min = Convert.ToInt32 (_data.Min<double>());

            //вариации
            int[] variations = Enumerable.Range(min, max + 1).ToArray();
            //частоты для вариаций
            int[] frequencies = GetFrequencies(variations);

            var discreteFrequencyRange = new IntervalFrequencyRange[variations.Length];
            for (int i = 0; i < discreteFrequencyRange.Length; i++)
            {
                discreteFrequencyRange[i] = new IntervalFrequencyRange(new Intervals(0, 0), variations[i], frequencies[i]);
            }

            return discreteFrequencyRange;
        }

        private int[] GetFrequencies(int[] variations)
        {
            //Поиск частот

            //Данные должны быть отсортированны для работы алгоритма
            _data.Sort();

            //За один проход по данным подсчитывается частоты для каждой вариации
            int[] frequencies = new int[variations.Length];
            int variationIndex = 0;
            int variation = variations[variationIndex];

            for (int i = 0; i < _data.Count; i++)
            {
                var cell = _data[i];

                while (variation != cell)
                {
                    variationIndex++;
                    variation = variations[variationIndex];
                }

                if (variation == cell)
                {
                    frequencies[variationIndex] += 1;
                }
            }
            return frequencies;
        }
    }
}
