using DataAnalyzers.Data;
using PrimaryDataAnalysis.CustomControls;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrimaryDataAnalysis.ChartFillers
{
    public class DiscreteChartFiller : IChartFiller
    {
        public void CreateBasicChart(IntervalFrequencyRange[] frequencyRange, ChartControl chartControl)
        {
            Chart chart = chartControl.TChart;
            Label label = chartControl.ChartLabel;

            chart.Name = "Полигон";
            label.Text = chart.Name;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chart.ChartAreas[0].AxisX.Title = "Вариации";
            chart.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chart.ChartAreas[0].AxisX.TitleForeColor = Color.Black;

            chart.ChartAreas[0].AxisY.Title = "Частоты";
            chart.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chart.ChartAreas[0].AxisY.TitleForeColor = Color.Black;

            Series s = chart.Series[0];
            s.ChartType = SeriesChartType.Line;
            s.Name = "";

            for (int i = 0; i < frequencyRange.Length; i++)
            {
                var cell = frequencyRange[i];
                var dataPoint = new DataPoint(Convert.ToDouble(cell.Variation), cell.Frequency);
                s.Points.Add(dataPoint);
            }
            chart.Update();
        }

        public void CreateCumulativeCurve(IntervalFrequencyRange[] frequencyRange, ChartControl chartControl)
        {
            Chart chart = chartControl.TChart;
            Label label = chartControl.ChartLabel;

            chart.Name = "Кумулятивная кривая";
            label.Text = chart.Name;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chart.ChartAreas[0].AxisX.Title = "Вариации";
            chart.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chart.ChartAreas[0].AxisX.TitleForeColor = Color.Black;

            chart.ChartAreas[0].AxisY.Title = "Накопленная частота";
            chart.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chart.ChartAreas[0].AxisY.TitleForeColor = Color.Black;

            Series s = chart.Series[0];
            s.ChartType = SeriesChartType.Line;
            s.Name = "";

            int accumulatedFrequency = 0;
            for (int i = 0; i < frequencyRange.Length; i++)
            {
                var cell = frequencyRange[i];
                accumulatedFrequency += cell.Frequency;

                var dataPoint = new DataPoint(Convert.ToDouble(cell.Variation), accumulatedFrequency);
                s.Points.Add(dataPoint);
            }
        }
    }
}
