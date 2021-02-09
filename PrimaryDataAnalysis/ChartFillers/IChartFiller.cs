using DataAnalyzers.Data;
using PrimaryDataAnalysis.CustomControls;

namespace PrimaryDataAnalysis.ChartFillers
{
    public interface IChartFiller
    {
        void CreateBasicChart(IntervalFrequencyRange[] frequencyRange, ChartControl chartControl);
        void CreateCumulativeCurve(IntervalFrequencyRange[] frequencyRange, ChartControl chartControl);
    }
}
