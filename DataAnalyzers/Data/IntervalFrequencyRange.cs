namespace DataAnalyzers.Data
{
    public class IntervalFrequencyRange : FrequencyRange
    {
        public IntervalFrequencyRange(Intervals intervals, double variation, int frequency) : base(variation, frequency)
        {
            Intervals = intervals;
        }

        public Intervals Intervals { private set; get; }
    }
}
