using DataAnalyzers.Data;

namespace DataAnalyzers.Analyzers.Interfaces
{
    public interface IDistributionCenterAnalyzer
    {
        DistributionCenterData CalculateDistributionCenterData();
    }
}