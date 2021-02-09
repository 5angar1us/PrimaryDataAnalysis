using System;
using System.Windows.Forms;

namespace PrimaryDataAnalysis.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.TemplateXLSXPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            textBox1.Text = openFileDialog1.FileName;
            Properties.Settings.Default.TemplateXLSXPath = openFileDialog1.FileName;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
