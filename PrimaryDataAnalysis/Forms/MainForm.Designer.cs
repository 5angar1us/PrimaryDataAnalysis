namespace PrimaryDataAnalysis.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new FontAwesome.Sharp.IconButton();
            this.btnCloseSubMenu = new FontAwesome.Sharp.IconButton();
            this.ibtnMinimyze = new FontAwesome.Sharp.IconButton();
            this.ibtnMaximyze = new FontAwesome.Sharp.IconButton();
            this.ibtnClose = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnSetting = new FontAwesome.Sharp.IconButton();
            this.panelRepotsSubMenu = new System.Windows.Forms.Panel();
            this.ibtnXLSX = new FontAwesome.Sharp.IconButton();
            this.ibtnPDF = new FontAwesome.Sharp.IconButton();
            this.ibtnReports = new FontAwesome.Sharp.IconButton();
            this.panelAnalysisSubMenu = new System.Windows.Forms.Panel();
            this.ibtnCharts = new FontAwesome.Sharp.IconButton();
            this.ibtnAnalysisResults = new FontAwesome.Sharp.IconButton();
            this.ibtnData = new FontAwesome.Sharp.IconButton();
            this.ibtnAnalysis = new FontAwesome.Sharp.IconButton();
            this.panelFileSubMenu = new System.Windows.Forms.Panel();
            this.ibtnOpen = new FontAwesome.Sharp.IconButton();
            this.ibtnFile = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDestop = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelRepotsSubMenu.SuspendLayout();
            this.panelAnalysisSubMenu.SuspendLayout();
            this.panelFileSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.labelPath);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.panel1);
            this.panelTitle.Controls.Add(this.ibtnMinimyze);
            this.panelTitle.Controls.Add(this.ibtnMaximyze);
            this.panelTitle.Controls.Add(this.ibtnClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(240, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(654, 65);
            this.panelTitle.TabIndex = 1;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.ForeColor = System.Drawing.Color.White;
            this.labelPath.Location = new System.Drawing.Point(0, 49);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(31, 13);
            this.labelPath.TabIndex = 5;
            this.labelPath.Text = "Путь";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(248, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(99, 20);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Заголовок";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnCloseChildForm);
            this.panel1.Controls.Add(this.btnCloseSubMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 42);
            this.panel1.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCloseChildForm.IconColor = System.Drawing.Color.White;
            this.btnCloseChildForm.IconSize = 32;
            this.btnCloseChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseChildForm.Location = new System.Drawing.Point(113, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Rotation = 0D;
            this.btnCloseChildForm.Size = new System.Drawing.Size(110, 42);
            this.btnCloseChildForm.TabIndex = 5;
            this.btnCloseChildForm.Text = "Закрыть форму";
            this.btnCloseChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btCloseChildForm_Click);
            // 
            // btnCloseSubMenu
            // 
            this.btnCloseSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseSubMenu.FlatAppearance.BorderSize = 0;
            this.btnCloseSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSubMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCloseSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnCloseSubMenu.ForeColor = System.Drawing.Color.White;
            this.btnCloseSubMenu.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCloseSubMenu.IconColor = System.Drawing.Color.White;
            this.btnCloseSubMenu.IconSize = 32;
            this.btnCloseSubMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseSubMenu.Location = new System.Drawing.Point(0, 0);
            this.btnCloseSubMenu.Name = "btnCloseSubMenu";
            this.btnCloseSubMenu.Rotation = 0D;
            this.btnCloseSubMenu.Size = new System.Drawing.Size(113, 42);
            this.btnCloseSubMenu.TabIndex = 0;
            this.btnCloseSubMenu.Text = "Закрыть подменю";
            this.btnCloseSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseSubMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCloseSubMenu.UseVisualStyleBackColor = true;
            this.btnCloseSubMenu.Click += new System.EventHandler(this.btnCloseSubMenu_Click);
            // 
            // ibtnMinimyze
            // 
            this.ibtnMinimyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnMinimyze.FlatAppearance.BorderSize = 0;
            this.ibtnMinimyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMinimyze.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnMinimyze.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ibtnMinimyze.IconColor = System.Drawing.Color.White;
            this.ibtnMinimyze.IconSize = 32;
            this.ibtnMinimyze.Location = new System.Drawing.Point(531, 3);
            this.ibtnMinimyze.Name = "ibtnMinimyze";
            this.ibtnMinimyze.Rotation = 0D;
            this.ibtnMinimyze.Size = new System.Drawing.Size(36, 37);
            this.ibtnMinimyze.TabIndex = 3;
            this.ibtnMinimyze.UseVisualStyleBackColor = true;
            this.ibtnMinimyze.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // ibtnMaximyze
            // 
            this.ibtnMaximyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnMaximyze.FlatAppearance.BorderSize = 0;
            this.ibtnMaximyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMaximyze.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnMaximyze.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ibtnMaximyze.IconColor = System.Drawing.Color.White;
            this.ibtnMaximyze.IconSize = 32;
            this.ibtnMaximyze.Location = new System.Drawing.Point(573, 3);
            this.ibtnMaximyze.Name = "ibtnMaximyze";
            this.ibtnMaximyze.Rotation = 0D;
            this.ibtnMaximyze.Size = new System.Drawing.Size(36, 37);
            this.ibtnMaximyze.TabIndex = 2;
            this.ibtnMaximyze.UseVisualStyleBackColor = true;
            this.ibtnMaximyze.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // ibtnClose
            // 
            this.ibtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnClose.FlatAppearance.BorderSize = 0;
            this.ibtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.ibtnClose.IconColor = System.Drawing.Color.White;
            this.ibtnClose.IconSize = 32;
            this.ibtnClose.Location = new System.Drawing.Point(615, 3);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Rotation = 0D;
            this.ibtnClose.Size = new System.Drawing.Size(36, 37);
            this.ibtnClose.TabIndex = 1;
            this.ibtnClose.UseVisualStyleBackColor = true;
            this.ibtnClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.ibtnSetting);
            this.panelMenu.Controls.Add(this.panelRepotsSubMenu);
            this.panelMenu.Controls.Add(this.ibtnReports);
            this.panelMenu.Controls.Add(this.panelAnalysisSubMenu);
            this.panelMenu.Controls.Add(this.ibtnAnalysis);
            this.panelMenu.Controls.Add(this.panelFileSubMenu);
            this.panelMenu.Controls.Add(this.ibtnFile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 653);
            this.panelMenu.TabIndex = 0;
            // 
            // ibtnSetting
            // 
            this.ibtnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnSetting.FlatAppearance.BorderSize = 0;
            this.ibtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnSetting.ForeColor = System.Drawing.Color.White;
            this.ibtnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ibtnSetting.IconColor = System.Drawing.Color.White;
            this.ibtnSetting.IconSize = 32;
            this.ibtnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSetting.Location = new System.Drawing.Point(0, 487);
            this.ibtnSetting.Name = "ibtnSetting";
            this.ibtnSetting.Rotation = 0D;
            this.ibtnSetting.Size = new System.Drawing.Size(240, 46);
            this.ibtnSetting.TabIndex = 9;
            this.ibtnSetting.Text = "Настройки";
            this.ibtnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSetting.UseVisualStyleBackColor = true;
            this.ibtnSetting.Click += new System.EventHandler(this.ibtnSetting_Click);
            // 
            // panelRepotsSubMenu
            // 
            this.panelRepotsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelRepotsSubMenu.Controls.Add(this.ibtnXLSX);
            this.panelRepotsSubMenu.Controls.Add(this.ibtnPDF);
            this.panelRepotsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRepotsSubMenu.Location = new System.Drawing.Point(0, 388);
            this.panelRepotsSubMenu.Name = "panelRepotsSubMenu";
            this.panelRepotsSubMenu.Size = new System.Drawing.Size(240, 99);
            this.panelRepotsSubMenu.TabIndex = 8;
            // 
            // ibtnXLSX
            // 
            this.ibtnXLSX.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnXLSX.FlatAppearance.BorderSize = 0;
            this.ibtnXLSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXLSX.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnXLSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnXLSX.ForeColor = System.Drawing.Color.White;
            this.ibtnXLSX.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnXLSX.IconColor = System.Drawing.Color.White;
            this.ibtnXLSX.IconSize = 32;
            this.ibtnXLSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXLSX.Location = new System.Drawing.Point(0, 46);
            this.ibtnXLSX.Name = "ibtnXLSX";
            this.ibtnXLSX.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ibtnXLSX.Rotation = 0D;
            this.ibtnXLSX.Size = new System.Drawing.Size(240, 46);
            this.ibtnXLSX.TabIndex = 5;
            this.ibtnXLSX.Text = "XLSX";
            this.ibtnXLSX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXLSX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXLSX.UseVisualStyleBackColor = true;
            this.ibtnXLSX.Click += new System.EventHandler(this.ibtnXLSX_Click);
            // 
            // ibtnPDF
            // 
            this.ibtnPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnPDF.FlatAppearance.BorderSize = 0;
            this.ibtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPDF.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnPDF.ForeColor = System.Drawing.Color.White;
            this.ibtnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnPDF.IconColor = System.Drawing.Color.White;
            this.ibtnPDF.IconSize = 32;
            this.ibtnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPDF.Location = new System.Drawing.Point(0, 0);
            this.ibtnPDF.Name = "ibtnPDF";
            this.ibtnPDF.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ibtnPDF.Rotation = 0D;
            this.ibtnPDF.Size = new System.Drawing.Size(240, 46);
            this.ibtnPDF.TabIndex = 4;
            this.ibtnPDF.Text = "PDF";
            this.ibtnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPDF.UseVisualStyleBackColor = true;
            this.ibtnPDF.Click += new System.EventHandler(this.ibtnPDF_Click);
            // 
            // ibtnReports
            // 
            this.ibtnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnReports.FlatAppearance.BorderSize = 0;
            this.ibtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnReports.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnReports.ForeColor = System.Drawing.Color.White;
            this.ibtnReports.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.ibtnReports.IconColor = System.Drawing.Color.White;
            this.ibtnReports.IconSize = 32;
            this.ibtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnReports.Location = new System.Drawing.Point(0, 342);
            this.ibtnReports.Name = "ibtnReports";
            this.ibtnReports.Rotation = 0D;
            this.ibtnReports.Size = new System.Drawing.Size(240, 46);
            this.ibtnReports.TabIndex = 7;
            this.ibtnReports.Text = "Отчёты";
            this.ibtnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnReports.UseVisualStyleBackColor = true;
            this.ibtnReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // panelAnalysisSubMenu
            // 
            this.panelAnalysisSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelAnalysisSubMenu.Controls.Add(this.ibtnCharts);
            this.panelAnalysisSubMenu.Controls.Add(this.ibtnAnalysisResults);
            this.panelAnalysisSubMenu.Controls.Add(this.ibtnData);
            this.panelAnalysisSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnalysisSubMenu.Location = new System.Drawing.Point(0, 203);
            this.panelAnalysisSubMenu.Name = "panelAnalysisSubMenu";
            this.panelAnalysisSubMenu.Size = new System.Drawing.Size(240, 139);
            this.panelAnalysisSubMenu.TabIndex = 6;
            // 
            // ibtnCharts
            // 
            this.ibtnCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnCharts.FlatAppearance.BorderSize = 0;
            this.ibtnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCharts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnCharts.ForeColor = System.Drawing.Color.White;
            this.ibtnCharts.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.ibtnCharts.IconColor = System.Drawing.Color.White;
            this.ibtnCharts.IconSize = 32;
            this.ibtnCharts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCharts.Location = new System.Drawing.Point(0, 92);
            this.ibtnCharts.Name = "ibtnCharts";
            this.ibtnCharts.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ibtnCharts.Rotation = 0D;
            this.ibtnCharts.Size = new System.Drawing.Size(240, 46);
            this.ibtnCharts.TabIndex = 6;
            this.ibtnCharts.Text = "Графики";
            this.ibtnCharts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCharts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnCharts.UseVisualStyleBackColor = true;
            this.ibtnCharts.Click += new System.EventHandler(this.ibtnCharts_Click);
            // 
            // ibtnAnalysisResults
            // 
            this.ibtnAnalysisResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAnalysisResults.FlatAppearance.BorderSize = 0;
            this.ibtnAnalysisResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAnalysisResults.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAnalysisResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnAnalysisResults.ForeColor = System.Drawing.Color.White;
            this.ibtnAnalysisResults.IconChar = FontAwesome.Sharp.IconChar.Poll;
            this.ibtnAnalysisResults.IconColor = System.Drawing.Color.White;
            this.ibtnAnalysisResults.IconSize = 32;
            this.ibtnAnalysisResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAnalysisResults.Location = new System.Drawing.Point(0, 46);
            this.ibtnAnalysisResults.Name = "ibtnAnalysisResults";
            this.ibtnAnalysisResults.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ibtnAnalysisResults.Rotation = 0D;
            this.ibtnAnalysisResults.Size = new System.Drawing.Size(240, 46);
            this.ibtnAnalysisResults.TabIndex = 5;
            this.ibtnAnalysisResults.Text = "Результаты анализа";
            this.ibtnAnalysisResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAnalysisResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAnalysisResults.UseVisualStyleBackColor = true;
            this.ibtnAnalysisResults.Click += new System.EventHandler(this.ibtnAnalysisResults_Click);
            // 
            // ibtnData
            // 
            this.ibtnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnData.FlatAppearance.BorderSize = 0;
            this.ibtnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnData.ForeColor = System.Drawing.Color.White;
            this.ibtnData.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ibtnData.IconColor = System.Drawing.Color.White;
            this.ibtnData.IconSize = 32;
            this.ibtnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnData.Location = new System.Drawing.Point(0, 0);
            this.ibtnData.Name = "ibtnData";
            this.ibtnData.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ibtnData.Rotation = 0D;
            this.ibtnData.Size = new System.Drawing.Size(240, 46);
            this.ibtnData.TabIndex = 4;
            this.ibtnData.Text = "Данные";
            this.ibtnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnData.UseVisualStyleBackColor = true;
            this.ibtnData.Click += new System.EventHandler(this.ibtnData_Click);
            // 
            // ibtnAnalysis
            // 
            this.ibtnAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAnalysis.FlatAppearance.BorderSize = 0;
            this.ibtnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAnalysis.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnAnalysis.ForeColor = System.Drawing.Color.White;
            this.ibtnAnalysis.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnAnalysis.IconColor = System.Drawing.Color.White;
            this.ibtnAnalysis.IconSize = 32;
            this.ibtnAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAnalysis.Location = new System.Drawing.Point(0, 157);
            this.ibtnAnalysis.Name = "ibtnAnalysis";
            this.ibtnAnalysis.Rotation = 0D;
            this.ibtnAnalysis.Size = new System.Drawing.Size(240, 46);
            this.ibtnAnalysis.TabIndex = 5;
            this.ibtnAnalysis.Text = "Анализ";
            this.ibtnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAnalysis.UseVisualStyleBackColor = true;
            this.ibtnAnalysis.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // panelFileSubMenu
            // 
            this.panelFileSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelFileSubMenu.Controls.Add(this.ibtnOpen);
            this.panelFileSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFileSubMenu.Location = new System.Drawing.Point(0, 111);
            this.panelFileSubMenu.Name = "panelFileSubMenu";
            this.panelFileSubMenu.Size = new System.Drawing.Size(240, 46);
            this.panelFileSubMenu.TabIndex = 3;
            // 
            // ibtnOpen
            // 
            this.ibtnOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnOpen.FlatAppearance.BorderSize = 0;
            this.ibtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOpen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnOpen.ForeColor = System.Drawing.Color.White;
            this.ibtnOpen.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.ibtnOpen.IconColor = System.Drawing.Color.White;
            this.ibtnOpen.IconSize = 32;
            this.ibtnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOpen.Location = new System.Drawing.Point(0, 0);
            this.ibtnOpen.Name = "ibtnOpen";
            this.ibtnOpen.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ibtnOpen.Rotation = 0D;
            this.ibtnOpen.Size = new System.Drawing.Size(240, 46);
            this.ibtnOpen.TabIndex = 4;
            this.ibtnOpen.Text = "Открыть";
            this.ibtnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnOpen.UseVisualStyleBackColor = true;
            this.ibtnOpen.Click += new System.EventHandler(this.ibtnOpen_Click);
            // 
            // ibtnFile
            // 
            this.ibtnFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnFile.FlatAppearance.BorderSize = 0;
            this.ibtnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.ibtnFile.ForeColor = System.Drawing.Color.White;
            this.ibtnFile.IconChar = FontAwesome.Sharp.IconChar.File;
            this.ibtnFile.IconColor = System.Drawing.Color.White;
            this.ibtnFile.IconSize = 32;
            this.ibtnFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFile.Location = new System.Drawing.Point(0, 65);
            this.ibtnFile.Name = "ibtnFile";
            this.ibtnFile.Rotation = 0D;
            this.ibtnFile.Size = new System.Drawing.Size(240, 46);
            this.ibtnFile.TabIndex = 2;
            this.ibtnFile.Text = "Файл";
            this.ibtnFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFile.UseVisualStyleBackColor = true;
            this.ibtnFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(92)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 65);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первичный анализ данных";
            // 
            // panelDestop
            // 
            this.panelDestop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panelDestop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDestop.Location = new System.Drawing.Point(240, 65);
            this.panelDestop.Name = "panelDestop";
            this.panelDestop.Size = new System.Drawing.Size(654, 588);
            this.panelDestop.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 653);
            this.ControlBox = false;
            this.Controls.Add(this.panelDestop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(910, 669);
            this.Name = "MainForm";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelRepotsSubMenu.ResumeLayout(false);
            this.panelAnalysisSubMenu.ResumeLayout(false);
            this.panelFileSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDestop;

        private System.Windows.Forms.Panel panelFileSubMenu;
        private System.Windows.Forms.Panel panelAnalysisSubMenu;
        private System.Windows.Forms.Panel panelRepotsSubMenu;

        private FontAwesome.Sharp.IconButton ibtnFile;
        private FontAwesome.Sharp.IconButton ibtnOpen;

        private FontAwesome.Sharp.IconButton ibtnAnalysis;
        private FontAwesome.Sharp.IconButton ibtnData;
        private FontAwesome.Sharp.IconButton ibtnAnalysisResults;
        private FontAwesome.Sharp.IconButton ibtnCharts;

        private FontAwesome.Sharp.IconButton ibtnReports;
        private FontAwesome.Sharp.IconButton ibtnXLSX;
        private FontAwesome.Sharp.IconButton ibtnPDF;

        private FontAwesome.Sharp.IconButton ibtnSetting;
        
        private FontAwesome.Sharp.IconButton ibtnMinimyze;
        private FontAwesome.Sharp.IconButton ibtnMaximyze;
        private FontAwesome.Sharp.IconButton ibtnClose;

        private FontAwesome.Sharp.IconButton btnCloseSubMenu;
        private FontAwesome.Sharp.IconButton btnCloseChildForm;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPath;
    }
}

