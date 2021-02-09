using DataAnalyzers.Data.Enums;
using System;

namespace DataAnalyzers.Data
{
    public class ExcessData
    {
        public double Excess { private set; get; }
        public double StandardError { private set; get; }
        public ESignificance Significance { private set; get; }

        public ExcessData(double excess, double standardError)
        {
            Excess = excess;
            StandardError = standardError;
            Significance = (Math.Abs(Excess) / standardError > 3) ? ESignificance.Significant : ESignificance.Insignificant;
        }
    }
}
