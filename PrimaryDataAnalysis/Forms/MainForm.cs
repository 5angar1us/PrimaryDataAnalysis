using DataAnalyzers;
using DataAnalyzers.Data;
using DataAnalyzers.Factories;
using FontAwesome.Sharp;
using PrimaryDataAnalysis.ChartFillers;
using PrimaryDataAnalysis.CustomControls;
using PrimaryDataAnalysis.Helpers;
using PrimaryDataAnalysis.Repots.Pdf;
using PrimaryDataAnalysis.Repots.XLSX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PrimaryDataAnalysis.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btnCloseSubMenu.Visible = false;
            btnCloseChildForm.Visible = false;

            //Не даёт в максимальном размереза занять весь экран
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            labelTitle.Text = "";
            labelPath.Text = "";

            HideSubMenu();
        }

        private Form activeForm;
        private IconButton currentBtn;

        #region Helper methods
        private void HideSubMenu()
        {
            panelFileSubMenu.Visible = false;
            panelAnalysisSubMenu.Visible = false;
            panelRepotsSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;

                btnCloseSubMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void ActivateMainButton(object senderBtn, Color color)
        {
            if (senderBtn == null)
                return;

            DisableMainButton();

            if (currentBtn == (IconButton)senderBtn)
                return;

            //Button
            currentBtn = (IconButton)senderBtn;

            currentBtn.BackColor = Color.FromArgb(255, 255, 255);
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void DisableMainButton()
        {
            if (currentBtn == null)
            {
                return;
            }

            currentBtn.BackColor = Color.Empty;
            currentBtn.ForeColor = Color.Gainsboro;
            currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            currentBtn.IconColor = Color.Gainsboro;
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            btnCloseSubMenu.Visible = false;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn == null)
                return;

            DisableButton();

            if (currentBtn == (IconButton)senderBtn)
                return;

            //Button
            currentBtn = (IconButton)senderBtn;

            currentBtn.BackColor = Color.FromArgb(255, 255, 255);
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Empty;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenChildForm(Form childForm, object btnSender, Color color)
        {
            if (activeForm != null)
            {
                if (activeForm.GetType() == childForm.GetType())
                    return;

                activeForm.Close();
                activeForm.Dispose();
            }

            ActivateButton(btnSender, color);

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDestop.Controls.Add(childForm);
            this.panelDestop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            btnCloseChildForm.Visible = true;
        }

        #endregion

        #region Analysis properties
        private DataTable dataTable;
        private PrimaryAnalysisResults primaryAnalysisResults;
        IChartFiller chartFiller;
        private IntervalFrequencyRange[] frequencyRange;
        List<Image> images;
        #endregion

        #region Menu
        private void buttonFile_Click(object sender, EventArgs e)
        {
            ActivateMainButton(sender, RGBColors.color1);
            ShowSubMenu(panelFileSubMenu);
        }

        private void ibtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var loader = new DataLoader.Loader(openFileDialog.FileName);
            try
            {
                dataTable = loader.GetData();

                Type dataType = dataTable.Columns[0].DataType;
                ICalculationFactory calculationFactory = GetCalculationFactory(dataType);
                chartFiller = GetChartFiller(dataType);

                var data = DataTableConverter.ConvertToList(dataTable);

                var analyzersController = new AnalyzersController(data, calculationFactory);
                primaryAnalysisResults = analyzersController.AnalizeData();
                frequencyRange = primaryAnalysisResults.FrequencyRange;
                images = CreateImages(frequencyRange);

                labelTitle.Text = calculationFactory.GetRangeName();
                labelPath.Text = openFileDialog.FileName;
                HideSubMenu();
                buttonAnalyze_Click(ibtnAnalysis, null);
                ibtnData_Click(ibtnData, null);
                btnCloseSubMenu.Visible = true;
            }
            catch (IOException exception)
            {
                MessageBox.Show(
                   exception.Message,
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            ActivateMainButton(sender, RGBColors.color2);
            ShowSubMenu(panelAnalysisSubMenu);
        }

        private void ibtnData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Data(dataTable), sender, RGBColors.color1);
        }

        private void ibtnAnalysisResults_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnalisisResult(primaryAnalysisResults), sender, RGBColors.color2);
        }

        private void ibtnCharts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Charts(chartFiller, frequencyRange), sender, RGBColors.color3);
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            ActivateMainButton(sender, RGBColors.color3);
            ShowSubMenu(panelRepotsSubMenu);
        }

        private void ibtnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Settings(), sender, RGBColors.color1);
        }

        private void btCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
                
            activeForm = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnCloseSubMenu_Click(object sender, EventArgs e)
        {
            DisableMainButton();
            HideSubMenu();
        }
        #endregion

        #region Analysis helper methods
        private IChartFiller GetChartFiller(Type type)
        {
            if (type == typeof(Int32))
                return new DiscreteChartFiller();
            else if (type == typeof(Double))
                return new IntervalChartFiller();
            return null;
        }

        private static ICalculationFactory GetCalculationFactory(Type type)
        {
            if (type == typeof(Int32))
                return new DiscreteCalculationFactory();
            else if (type == typeof(Double))
                return new IntervalCalculationFactory();
            return null;
        }

        private List<Image> CreateImages(IntervalFrequencyRange[] frequencyRange)
        {
            var images = new List<Image>();
            var chartControl = new ChartControl();

            chartFiller.CreateBasicChart(frequencyRange, chartControl);
            images.Add(ChartImageConverter.GetChartImage(chartControl.TChart));

            chartControl.TChart.Series[0].Points.Clear();

            chartFiller.CreateCumulativeCurve(frequencyRange, chartControl);
            images.Add(ChartImageConverter.GetChartImage(chartControl.TChart));

            return images;
        }
        #endregion

        #region Reports
        private void ibtnPDF_Click(object sender, EventArgs e)
        {
            if (primaryAnalysisResults == null)
            {
                MessageBox.Show(
                   "Анализ данных не выполнен.",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog.Filter = "pdf files (*.pdf)| *.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            PDFReport pDFReport = new PDFReport();
            pDFReport.CreateReport(saveFileDialog.FileName, primaryAnalysisResults, images);
            MessageBox.Show(
                "Отсчёт создан",
                "Создание отсчёта",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );
        }

        private void ibtnXLSX_Click(object sender, EventArgs e)
        {
            if (primaryAnalysisResults == null
                | images == null)
            {
                MessageBox.Show(
                    "Анализ данных не выполнен.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (Properties.Settings.Default.TemplateXLSXPath == null
                && Properties.Settings.Default.TemplateXLSXPath.Length == 0)
            {
                MessageBox.Show(
                    "Файл XLSX шаблона не найден. Добавте путь к нему в настройках",
                    "Создание отсчёта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }


            if (!File.Exists(Properties.Settings.Default.TemplateXLSXPath))
            {
                MessageBox.Show("Файл XLSX шаблона не найден по указанному пути. Изменить путь к нему в настройках");
                return;
            }

            saveFileDialog.Filter = "XLSX files (*.xlsx) | *.xlsx";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            XLSXReport xlsxReport = new XLSXReport(Properties.Settings.Default.TemplateXLSXPath);
            xlsxReport.CreateXLSX(saveFileDialog.FileName, primaryAnalysisResults, images);
            MessageBox.Show(
                "Отсчёт создан",
                "Создание отсчёта",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );
        }

        #endregion

        #region drag and drop
        

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCapture();
            NativeMethods.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Min Max Close Buttons

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
