using System.Data;
using System.Windows.Forms;

namespace PrimaryDataAnalysis.Forms
{
    public partial class Data : Form
    {
        public Data(DataTable dataTable)
        {
            InitializeComponent();

            if(dataTable != null)
            {
                dataGridView1.DataSource = dataTable;
                dataGridView1.Update();
            }
            
        }
    }
}
