using DataAnalyzers;
using DataAnalyzers.Data;
using DataAnalyzers.Data.Enums;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace PrimaryDataAnalysis.Repots.Pdf
{
    class PDFReport
    {
        private PdfFont CreateFont()
        {
            string tnr = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.TTF");
            return PdfFontFactory.CreateFont(tnr, "CP1251", true);
        }

        private iText.Layout.Element.Image GetImage(System.Drawing.Image image)
        {
            byte[] byteImage;
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Png);
                byteImage = stream.GetBuffer();
            }

            return new iText.Layout.Element.Image(ImageDataFactory.Create(byteImage));

        }
        private Paragraph CreateprimaryAnalysisResultsParagraph(PrimaryAnalysisResults primaryAnalysisResults, PdfFont font)
        {
            BasicVariationSize basicVariationData = primaryAnalysisResults.BasicVariationData;
            DistributionCenterData distributionCenterData = primaryAnalysisResults.DistributionCenterData;
            VariationsIndicators variationsIndicators = primaryAnalysisResults.VariationsIndicators;
            RelativeIndicators relativeIndicators = primaryAnalysisResults.RelativeIndicators;
            AsymmetryData asymmetryData = primaryAnalysisResults.AsymmetryData;
            ExcessData excessData = primaryAnalysisResults.ExcessData;

            StringBuilder sb = new StringBuilder();

            // Максимум 
            sb.AppendLine($"Maксимум: {basicVariationData.Max}");

            // Минимум
            sb.AppendLine($"Минимум: {basicVariationData.Min}");

            // Объём выборки 
            sb.AppendLine($"Объём Выборки: {basicVariationData.SampleSize}");

            //===============  Показатели центра распределения и структурных характеристик вариационного ряда  =================

            // Мода
            sb.AppendLine($"Мода: { distributionCenterData.Fashion}");

            //Медиана
            sb.AppendLine($"Медиана: { distributionCenterData.Median}");

            // Средняя величина 
            sb.AppendLine($"Средняя величина: { distributionCenterData.SampleMean}");

            //================================ Показатели размера и интенсивности вариации  =================================

            // Размах вариации 
            sb.AppendLine($"Размах вариации: { variationsIndicators.VariationRange}");

            // Среднеквадратическое отклонение
            sb.AppendLine($"Среднеквадратическое отклонение: { variationsIndicators.StandardDeviation}");

            // Cреднее линейное отклонение
            sb.AppendLine($"Cреднее линейное отклонение: {variationsIndicators.AverageLinearDeviation}");

            // Дисперсия
            sb.AppendLine($"Дисперсия: { variationsIndicators.Dispersion}");

            // Коэффициент вариации
            sb.AppendLine($"Коэффициент вариации: { relativeIndicators.VariationCoeff}");

            //Линейный коэффициент вариации
            sb.AppendLine($"Линеный коэффициент вариации: { relativeIndicators.VariationLinearСoeff}");

            //Коэффициент Осцилляции
            sb.AppendLine($"Коэффициент Осцилляции: { relativeIndicators.OscillationCoeff}");

            //================================  Показатели асимметрии и её значимости  ======================================
            sb.AppendLine($"Ассиметрия: { asymmetryData.Asymmetry}");

            sb.AppendLine($"Средняя квадратическая ошибка коэффициента асимметрии: { asymmetryData.StandardError}");

            string asymmetrySignificance = (asymmetryData.Significance == ESignificance.Significant) ? "существенная" : "несущественная";
            sb.AppendLine($"Существенность асимметрии: {asymmetrySignificance}");


            //================================ Расчёт показателя эксцесса ряда распределения =============================
            sb.AppendLine($"Эксцесс: { excessData.Excess}");

            sb.AppendLine($"Средняя квадратическая ошибка коэффициента эксцесса: { excessData.StandardError}");
            string excessSignificance = (excessData.Significance == ESignificance.Significant) ? "существенный" : "несущественный";
            sb.AppendLine($"Существенность эксцесса: { excessSignificance }");

            Paragraph data = new Paragraph(sb.ToString())
               .SetFont(font)
               .SetTextAlignment(TextAlignment.LEFT);
            return data;
        }

        public void CreateReport(string path, PrimaryAnalysisResults primaryAnalysisResults, List<System.Drawing.Image> images)
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

            var pdfReport = new PDFReport();

            PdfFont font = pdfReport.CreateFont();
            Paragraph primaryAnalysisIndicator = pdfReport.CreateprimaryAnalysisResultsParagraph(primaryAnalysisResults, font);


            using (PdfDocument pdfDoc = new PdfDocument(new PdfWriter(path)))
            {
                Document doc = new Document(pdfDoc);


                Paragraph Header = new Paragraph()
                    .Add("Результаты первичного анализа")
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetFont(font);
                doc.Add(Header);

                doc.Add(primaryAnalysisIndicator);
                doc.Add(new AreaBreak());

                for (int i = 0; i < (images.Count & itemName.ChartName.Count); i++)
                {
                    Paragraph chartHeader = new Paragraph()
                   .Add(itemName.ChartName[i])
                   .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                   .SetFont(font);

                    var pdfImg = pdfReport.GetImage(images[i]);
                    doc.Add(chartHeader);
                    doc.Add(pdfImg);
                }
            }
        }
    }
}
