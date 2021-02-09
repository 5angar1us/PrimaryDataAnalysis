using DataAnalyzers.Data.Enums;
using System;

namespace DataAnalyzers.Data
{
    public class AsymmetryData
    {

        public double Asymmetry { private set; get; }
        public double StandardError { private set; get; }
        public ESignificance Significance { private set; get; }

        public AsymmetryData(double asymmetry, double standardError)
        {
            Asymmetry = asymmetry;
            StandardError = standardError;
            Significance = (Math.Abs(asymmetry) / standardError > 3) ? ESignificance.Significant : ESignificance.Insignificant;
        }
    }
}
