using DataAnalyzers.Data;

namespace DataAnalyzers.Analyzers.Interfaces
{
    public interface IFrequencyAnalyzer
    {
        IntervalFrequencyRange[] CalculateFrequencyRange();
    }
}