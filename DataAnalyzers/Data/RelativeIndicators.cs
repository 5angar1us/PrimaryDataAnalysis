namespace DataAnalyzers.Data
{
    public class RelativeIndicators
    {
        public RelativeIndicators(double variationCoeff, double variationlinearСoeff, double oscillationCoeff)
        {
            VariationCoeff = variationCoeff;
            VariationLinearСoeff = variationlinearСoeff;
            OscillationCoeff = oscillationCoeff;
        }

        public double VariationCoeff { private set; get; }
        public double VariationLinearСoeff { private set; get; }
        public double OscillationCoeff { private set; get; }


    }
}
