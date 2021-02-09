using DataAnalyzers.Data.Enums;

namespace DataAnalyzers.Data
{
    public class PrimaryAnalysisResults
    {
        public IntervalFrequencyRange[] FrequencyRange { set; get; }
        public BasicVariationSize BasicVariationData { set; get; }
        public DistributionCenterData DistributionCenterData { set; get; }
        public VariationsIndicators VariationsIndicators { set; get; }
        public RelativeIndicators RelativeIndicators { set; get; }
        public AsymmetryData AsymmetryData { set; get; }
        public ExcessData ExcessData { set; get; }
        public ECalculationMode CalculationMode { set; get; }
        public PrimaryAnalysisResults() { }
    }
}
