using DataAnalyzers.Analyzers.Abstract;
using DataAnalyzers.Analyzers.Interfaces;
using DataAnalyzers.Data;
using DataAnalyzers.Data.Enums;
using System.Collections.Generic;

namespace DataAnalyzers.Factories
{
    public interface ICalculationFactory
    {
        IDistributionCenterAnalyzer GetDistributionCenterAnalyzer(IntervalFrequencyRange[] intervalFrequencyRange, BasicVariationSize basicVariationData);
        IFrequencyAnalyzer GetFrequencyAnalyzer(List<double> data);
        VariationalAnalyzer GetVariationalAnalyzer(FrequencyRange[] discreteFrequencyRange,BasicVariationSize basicVariationSize,double sampleMean);
        ECalculationMode GetCalculationMod();
        string GetRangeName();
    }
}