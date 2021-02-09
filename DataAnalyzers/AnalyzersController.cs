using DataAnalyzers.Analyzers;
using DataAnalyzers.Data;
using DataAnalyzers.Factories;
using System.Collections.Generic;

namespace DataAnalyzers
{
    public class AnalyzersController
    {
        private List<double> data;
        private ICalculationFactory calculationFactory;

        public AnalyzersController(List<double> data, ICalculationFactory calculationFactory)
        {
            this.data = data;
            this.calculationFactory = calculationFactory;
        }

        public PrimaryAnalysisResults AnalizeData()
        {
            //=========================  Расчёт показателей размера вариации  =============================

            var basicVariationAnalyzer = new BasicVariationAnalyzer(data);
            var basicVariationData = basicVariationAnalyzer.CalculateBasicVariationData();


            //=========================  Получение интервалов и соответствующих им частот  ========================

            var frequencyAnalyzer = calculationFactory.GetFrequencyAnalyzer(data);
            var frequencyRange = frequencyAnalyzer.CalculateFrequencyRange();

            //===============  Расчёт показателей центра распределения и структурных характеристик вариационного ряда  =================
            var distributionCenterAnalyzer = calculationFactory.GetDistributionCenterAnalyzer(frequencyRange, basicVariationData);
            var distributionCenterData = distributionCenterAnalyzer.CalculateDistributionCenterData();

            //================================  Расчёт показателей размера и интенсивности вариации  =================================

            var variationalAnalyzer = calculationFactory.GetVariationalAnalyzer(frequencyRange, basicVariationData, distributionCenterData.SampleMean);
            var variationsIndicators = variationalAnalyzer.CalculateVariationsIndicators();


            var relativeIndicatorsAnalyzers = new RelativeIndicatorsAnalyzer(
                variationsIndicators.StandardDeviation,
                variationsIndicators.AverageLinearDeviation,
                variationsIndicators.VariationRange,
                distributionCenterData.SampleMean);
            var relativeIndicators = relativeIndicatorsAnalyzers.CalculateRelativeIndicators();

            //================================  Расчёт показателя асимметрии и её значимости  ======================================

            var asymmetryAnalyzer = new AsymmetryAnalyzer(
                frequencyRange,
                distributionCenterData.SampleMean,
                basicVariationData.SampleSize,
                variationsIndicators.StandardDeviation);

            var asymmetryData = asymmetryAnalyzer.CalculateAsymmetryData();


            //================================ Расчёт показателя эксцесса ряда распределения =============================

            var excessAnalyzer = new ExcessAnalyzer(
                frequencyRange,
                distributionCenterData.SampleMean,
                variationsIndicators.StandardDeviation,
                basicVariationData.SampleSize);

            var excessData = excessAnalyzer.CalculateExcessData();

            //================================ Сохранение результатов ================================
            var primaryAnalysisResults = new PrimaryAnalysisResults()
            {
                FrequencyRange = frequencyRange,
                BasicVariationData = basicVariationData,
                DistributionCenterData = distributionCenterData,
                VariationsIndicators = variationsIndicators,
                RelativeIndicators = relativeIndicators,
                AsymmetryData = asymmetryData,
                ExcessData = excessData,
                CalculationMode = calculationFactory.GetCalculationMod()
            };
            return primaryAnalysisResults;
        }
    }
}
