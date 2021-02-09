namespace DataAnalyzers.Data
{
    public class BasicVariationSize
    {
        public int SampleSize { private set; get; }
        public double Max { private set; get; }
        public double Min { private set; get; }


        public BasicVariationSize(int sampleSize, double max, double min)
        {
            SampleSize = sampleSize;
            Max = max;
            Min = min;
        }
    }
}
