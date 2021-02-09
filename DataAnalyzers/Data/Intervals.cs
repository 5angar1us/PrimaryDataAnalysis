namespace DataAnalyzers.Data
{
    public class Intervals
    {
        public double Left { private set; get; }
        public double Right { private set; get; }

        public Intervals(double left, double right)
        {
            this.Left = left;
            this.Right = right;
        }
    }
}
