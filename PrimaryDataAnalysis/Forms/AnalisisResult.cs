using DataAnalyzers.Data;
using DataAnalyzers.Data.Enums;
using System;
using System.Windows.Forms;

namespace PrimaryDataAnalysis.Forms
{
    public partial class AnalisisResult : Form
    {
        private PrimaryAnalysisResults primaryAnalysisResults;

        public AnalisisResult(PrimaryAnalysisResults primaryAnalysisResults)
        {
            InitializeComponent();
            this.primaryAnalysisResults = primaryAnalysisResults;
        }

        private void AnalisisResult_Load(object sender, EventArgs e)
        {
            if(primaryAnalysisResults != null)
            {
                ShowResults();
            }
        }

        private void ShowResults()
        {
            var basicVariationData = primaryAnalysisResults.BasicVariationData;
            var distributionCenterData = primaryAnalysisResults.DistributionCenterData;
            var variationsIndicators = primaryAnalysisResults.VariationsIndicators;
            var relativeIndicators = primaryAnalysisResults.RelativeIndicators;
            var asymmetryData = primaryAnalysisResults.AsymmetryData;
            var excessData = primaryAnalysisResults.ExcessData; 

            //========================= Показатели размера вариации =============================
            // Максимум 
            tbMax.Text = basicVariationData.Max.ToString();

            // Минимум
            tbMin.Text = basicVariationData.Min.ToString();

            // Объём выборки 
            tbSampleSize.Text = basicVariationData.SampleSize.ToString();

            //===============  Показатели центра распределения и структурных характеристик вариационного ряда  =================
            // Мода
            tbFashion.Text = distributionCenterData.Fashion.ToString();

            //Медиана
            tbMedian.Text = distributionCenterData.Median.ToString();

            // Средняя величина 
            tbSampleMean.Text = distributionCenterData.SampleMean.ToString();

            //================================  Показатели размера и интенсивности вариации  =================================
            // Размах вариации 
            tbVariationRange.Text = variationsIndicators.VariationRange.ToString();

            // Среднеквадратическое отклонение
            tbStandardDeviation.Text = variationsIndicators.StandardDeviation.ToString();

            // Cреднее линейное отклонение
            tbAverageLinearDeviation.Text = variationsIndicators.AverageLinearDeviation.ToString();

            // Дисперсия
            tbDispersion.Text = variationsIndicators.Dispersion.ToString();


            tbVariationCoeff.Text = relativeIndicators.VariationCoeff.ToString();


            tbVariationlinearСoeff.Text = relativeIndicators.VariationLinearСoeff.ToString();


            tbOscillationCoeff.Text = relativeIndicators.OscillationCoeff.ToString();

            //================================  Показатели асимметрии и её значимости  ======================================

            tbAsymmetry.Text = asymmetryData.Asymmetry.ToString();

            tbAsymmetryStandardError.Text = asymmetryData.StandardError.ToString();

            tbAsymmetryImportance.Text = (asymmetryData.Significance == ESignificance.Significant) ? "существенный" : "несущественный";

            //================================ Показатели эксцесса ряда распределения =============================

            tbExcess.Text = excessData.Excess.ToString();

            tbExcessStandardError.Text = excessData.StandardError.ToString();

            tbExcessImportance.Text = (excessData.Significance == ESignificance.Significant) ? "существенный" : "несущественный";

        }

      
    }
}
