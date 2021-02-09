using ClosedXML.Excel;
using ClosedXML.Report;
using DataAnalyzers.Data;
using DataAnalyzers.Data.Enums;
using System.Collections.Generic;
using System.Drawing;

namespace PrimaryDataAnalysis.Repots.XLSX
{
    class XLSXReport
    {
        private string templatePath;
        public XLSXReport(string templatePath)
        {
            this.templatePath = templatePath;
        }

       public void CreateXLSX(string path, PrimaryAnalysisResults primaryAnalysisResults, List<System.Drawing.Image> images)
        {
            ItemName itemName;
            if (primaryAnalysisResults.CalculationMode == ECalculationMode.Discrete)
            {
                itemName = new DiscreteItemName();
            }
            else
            {
                itemName = new IntervalItemName();
            }



            using (var template = new XLTemplate(templatePath))
            {
                SetDataResults(primaryAnalysisResults, template);
                template.Generate();
                template.SaveAs(path);

            }
            using (var wb = new XLWorkbook(path))
            {
                var ws = wb.Worksheets.Add("Графики");

                //var imagePath = @"c:\path\to\your\image.jpg";
                const int offset = 20;
                for (int i = 0; i < (images.Count & itemName.ChartName.Count); i++)
                {
                    ws.Cell(1 + offset * i, 1).Value = itemName.ChartName[i];
                    Bitmap image1 = (Bitmap)images[i];
                    ws.AddPicture(image1).MoveTo(ws.Cell(1 + offset * i + 1, 1));
                }
                wb.SaveAs(path);
            }
        }

        private static void SetDataResults(PrimaryAnalysisResults primaryAnalysisResults, XLTemplate template)
        {
            template.AddVariable("Min", primaryAnalysisResults.BasicVariationData.Min);
            template.AddVariable("Max", primaryAnalysisResults.BasicVariationData.Max);
            template.AddVariable("SampleSize", primaryAnalysisResults.BasicVariationData.SampleSize);

            template.AddVariable("Fashion", primaryAnalysisResults.DistributionCenterData.Fashion);
            template.AddVariable("Median", primaryAnalysisResults.DistributionCenterData.Median);
            template.AddVariable("SampleMean", primaryAnalysisResults.DistributionCenterData.SampleMean);

            template.AddVariable("Dispersion", primaryAnalysisResults.VariationsIndicators.Dispersion);
            template.AddVariable("StandardDeviation", primaryAnalysisResults.VariationsIndicators.StandardDeviation);
            template.AddVariable("AverageLinearDeviation", primaryAnalysisResults.VariationsIndicators.AverageLinearDeviation);
            template.AddVariable("VariationRange", primaryAnalysisResults.VariationsIndicators.VariationRange);

            template.AddVariable("VariationCoeff", primaryAnalysisResults.RelativeIndicators.VariationCoeff);
            template.AddVariable("VariationLinearСoeff", primaryAnalysisResults.RelativeIndicators.VariationLinearСoeff);
            template.AddVariable("OscillationCoeff", primaryAnalysisResults.RelativeIndicators.OscillationCoeff);

            template.AddVariable("Asymmetry", primaryAnalysisResults.AsymmetryData.Asymmetry);
            template.AddVariable("AsymmetryStandardError", primaryAnalysisResults.AsymmetryData.StandardError);
            string asymmetrySignificance = (primaryAnalysisResults.AsymmetryData.Significance == ESignificance.Significant)
                ? "существенная" : "несущественная";
            template.AddVariable("AsymmetrySignificance", asymmetrySignificance);


            template.AddVariable("Excess", primaryAnalysisResults.ExcessData.Excess);
            template.AddVariable("StandardError", primaryAnalysisResults.ExcessData.StandardError);
            string excessSignificance = (primaryAnalysisResults.ExcessData.Significance == ESignificance.Significant)
                ? "существенный" : "несущественный";
            template.AddVariable("ExcessSignificance", excessSignificance);
        }
    }
}
