
using DataAnalyzers.Data;
using PrimaryDataAnalysis.ChartFillers;
using System;
using System.Windows.Forms;

namespace PrimaryDataAnalysis.Forms
{
    public partial class Charts : Form
    {
        private IChartFiller chartFiller;
        private IntervalFrequencyRange[] intervalFrequencyRange;


        public Charts(IChartFiller chartFiller, IntervalFrequencyRange[] intervalFrequencyRange)
        {
            InitializeComponent();

            this.chartFiller = chartFiller;
            this.intervalFrequencyRange = intervalFrequencyRange;
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            bool isNull = chartFiller == null 
                | intervalFrequencyRange == null;

            if (!isNull)
            {
                ShowCharts();
            }

        }

        public void ShowCharts()
        {
            chartFiller.CreateBasicChart(intervalFrequencyRange, chartControl1);
            chartFiller.CreateCumulativeCurve(intervalFrequencyRange, chartControl2);
        }
    }
}
