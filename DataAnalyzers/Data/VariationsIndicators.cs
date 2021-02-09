namespace DataAnalyzers.Data
{
    public class VariationsIndicators
    {
        public VariationsIndicators(double variationRange, double dispersion, double standardDeviation, double averageLinearDeviation)
        {
            VariationRange = variationRange;
            Dispersion = dispersion;
            StandardDeviation = standardDeviation;
            AverageLinearDeviation = averageLinearDeviation;
        }

        public double VariationRange { private set; get; }
        public double Dispersion { private set; get; }
        public double StandardDeviation { private set; get; }
        public double AverageLinearDeviation { private set; get; }
       

       
    }
}
