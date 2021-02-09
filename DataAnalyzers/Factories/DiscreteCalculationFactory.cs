using System.Collections.Generic;
using DataAnalyzers.Analyzers.Abstract;
using DataAnalyzers.Analyzers.Discrete;
using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Data;
using DataAnalyzers.Data.Enums;

namespace DataAnalyzers.Factories
{
    public class DiscreteCalculationFactory : ICalculationFactory
    {
        public ECalculationMode GetCalculationMod()
        {
            return ECalculationMode.Discrete;
        }

        public IDistributionCenterAnalyzer GetDistributionCenterAnalyzer(IntervalFrequencyRange[] intervalFrequencyRange, BasicVariationSize basicVariationData)
        {
            return new DiscreteDistributionCenterAnalyzer(intervalFrequencyRange, basicVariationData);
        }

        public IFrequencyAnalyzer GetFrequencyAnalyzer(List<double> data)
        {
            return new DiscreteFrequencyAnalyzer(data);
        }

        public string GetRangeName()
        {
            return "Дискретный вариационный ряд";
        }

        public VariationalAnalyzer GetVariationalAnalyzer(FrequencyRange[] discreteFrequencyRange, BasicVariationSize basicVariationSize, double sampleMean)
        {
            return new DiscreteVariationalAnalyzer(discreteFrequencyRange, basicVariationSize, sampleMean);
        }
    }
}
