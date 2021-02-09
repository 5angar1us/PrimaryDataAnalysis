using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrimaryDataAnalysis.Helpers
{
    class ChartImageConverter
    {
        public static Image GetChartImage(Chart chart1)
        {
            Image image;
            using (MemoryStream stream = new MemoryStream())
            {
                chart1.SaveImage(stream, ChartImageFormat.Png);
                image = Bitmap.FromStream(stream);
            }
            return image;
        }
    }
}
