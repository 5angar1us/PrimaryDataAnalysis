using System.Collections.Generic;
using DataAnalyzers.Analyzers.Abstract;
using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Analyzers.Interval;
using DataAnalyzers.Data;
using DataAnalyzers.Data.Enums;

namespace DataAnalyzers.Factories
{
    public class IntervalCalculationFactory : ICalculationFactory
    {
        public ECalculationMode GetCalculationMod()
        {
            return ECalculationMode.Interval;
        }

        public IDistributionCenterAnalyzer GetDistributionCenterAnalyzer(IntervalFrequencyRange[] intervalFrequencyRange, BasicVariationSize basicVariationData)
        {
            return new IntervalDistributionCenterAnalyzer(intervalFrequencyRange, basicVariationData);
        }

        public IFrequencyAnalyzer GetFrequencyAnalyzer(List<double> data)
        {
           return new IntervalFrequencyAnalyzer(data);
        }

        public string GetRangeName()
        {
            return "Интервальный вариационный ряд";
        }

        public VariationalAnalyzer GetVariationalAnalyzer(FrequencyRange[] discreteFrequencyRange, BasicVariationSize basicVariationSize, double sampleMean)
        {
            return new IntervalVariationalAnalyzer(discreteFrequencyRange, basicVariationSize, sampleMean);
        }
    }
}
