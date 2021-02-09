namespace DataAnalyzers.Data
{
    public class DistributionCenterData
    {
        public DistributionCenterData(double fashion, double median, double sampleMean)
        {
            Fashion = fashion;
            Median = median;
            SampleMean = sampleMean;
        }

        public double Fashion { private set; get; }
        public double Median { private set; get; }
        public double SampleMean { private set; get; }
        

       
    }
}