using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrimaryDataAnalysis.CustomControls
{
    public partial class ChartControl : UserControl
    {
        public ChartControl()
        {
            InitializeComponent();
        }

        public Label ChartLabel { get => label1; }
        public Chart TChart { get => chart1; }

        
    }
}
