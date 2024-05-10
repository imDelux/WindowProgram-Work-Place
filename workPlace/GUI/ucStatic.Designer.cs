namespace GUI
{
    partial class ucStatic
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.cWage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThisYear = new Krypton.Toolkit.KryptonButton();
            this.btnThisMonth = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.cJob = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblTotalProfitHeader = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalJob = new System.Windows.Forms.Label();
            this.lblTotalJobHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.picPreviousMonth = new System.Windows.Forms.PictureBox();
            this.picNextMonth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cWage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviousMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cWage);
            this.kryptonPanel1.Location = new System.Drawing.Point(31, 138);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(570, 463);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cWage
            // 
            chartArea3.Name = "ChartArea1";
            this.cWage.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cWage.Legends.Add(legend3);
            this.cWage.Location = new System.Drawing.Point(13, 14);
            this.cWage.Name = "cWage";
            this.cWage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.cWage.Size = new System.Drawing.Size(543, 436);
            this.cWage.TabIndex = 0;
            this.cWage.Text = "Tracking Wage";
            title3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Thistle;
            title3.Name = "Title1";
            title3.Text = "Tracking Wage";
            this.cWage.Titles.Add(title3);
            // 
            // btnThisYear
            // 
            this.btnThisYear.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnThisYear.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnThisYear.Location = new System.Drawing.Point(832, 54);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisYear.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisYear.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisYear.OverrideDefault.Border.Width = 0;
            this.btnThisYear.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThisYear.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThisYear.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisYear.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisYear.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisYear.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisYear.OverrideFocus.Border.Width = 0;
            this.btnThisYear.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThisYear.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThisYear.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisYear.Size = new System.Drawing.Size(144, 40);
            this.btnThisYear.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisYear.StateCommon.Border.Rounding = 5F;
            this.btnThisYear.StateCommon.Border.Width = 2;
            this.btnThisYear.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnThisYear.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnThisYear.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnThisYear.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnThisYear.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisYear.StateNormal.Border.Width = 1;
            this.btnThisYear.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnThisYear.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnThisYear.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisYear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisYear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisYear.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnThisYear.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnThisYear.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisYear.StatePressed.Border.Width = 0;
            this.btnThisYear.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThisYear.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThisYear.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisYear.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnThisYear.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnThisYear.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnThisYear.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnThisYear.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.btnThisYear.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)(((Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisYear.StateTracking.Border.Width = 1;
            this.btnThisYear.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnThisYear.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnThisYear.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisYear.TabIndex = 9;
            this.btnThisYear.Values.Text = "Year";
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnThisMonth.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnThisMonth.Location = new System.Drawing.Point(677, 54);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisMonth.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisMonth.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisMonth.OverrideDefault.Border.Width = 0;
            this.btnThisMonth.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThisMonth.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThisMonth.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisMonth.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisMonth.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisMonth.OverrideFocus.Border.Width = 0;
            this.btnThisMonth.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThisMonth.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThisMonth.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.Size = new System.Drawing.Size(149, 40);
            this.btnThisMonth.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisMonth.StateCommon.Border.Rounding = 5F;
            this.btnThisMonth.StateCommon.Border.Width = 2;
            this.btnThisMonth.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnThisMonth.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnThisMonth.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnThisMonth.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnThisMonth.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisMonth.StateNormal.Border.Width = 1;
            this.btnThisMonth.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnThisMonth.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnThisMonth.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisMonth.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnThisMonth.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnThisMonth.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnThisMonth.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisMonth.StatePressed.Border.Width = 0;
            this.btnThisMonth.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThisMonth.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThisMonth.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnThisMonth.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnThisMonth.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnThisMonth.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnThisMonth.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.btnThisMonth.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)(((Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThisMonth.StateTracking.Border.Width = 1;
            this.btnThisMonth.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnThisMonth.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnThisMonth.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.TabIndex = 10;
            this.btnThisMonth.Values.Text = "Month";
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.cJob);
            this.kryptonPanel2.Location = new System.Drawing.Point(621, 138);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(355, 463);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.kryptonPanel2.TabIndex = 11;
            // 
            // cJob
            // 
            chartArea4.Name = "ChartArea1";
            this.cJob.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cJob.Legends.Add(legend4);
            this.cJob.Location = new System.Drawing.Point(14, 14);
            this.cJob.Name = "cJob";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cJob.Series.Add(series2);
            this.cJob.Size = new System.Drawing.Size(327, 436);
            this.cJob.TabIndex = 1;
            this.cJob.Text = "chart2";
            title4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.Thistle;
            title4.Name = "Title1";
            title4.Text = "Percent done job";
            this.cJob.Titles.Add(title4);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.panel2);
            this.kryptonPanel3.Controls.Add(this.panel1);
            this.kryptonPanel3.Location = new System.Drawing.Point(31, 623);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(945, 119);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.kryptonPanel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProfit);
            this.panel2.Controls.Add(this.lblTotalProfitHeader);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(17, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 89);
            this.panel2.TabIndex = 1;
            // 
            // lblProfit
            // 
            this.lblProfit.BackColor = System.Drawing.Color.White;
            this.lblProfit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProfit.Location = new System.Drawing.Point(89, 39);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(219, 30);
            this.lblProfit.TabIndex = 44;
            this.lblProfit.Text = "Total profit";
            this.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProfitHeader
            // 
            this.lblTotalProfitHeader.AutoSize = true;
            this.lblTotalProfitHeader.BackColor = System.Drawing.Color.White;
            this.lblTotalProfitHeader.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfitHeader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalProfitHeader.Location = new System.Drawing.Point(85, 10);
            this.lblTotalProfitHeader.Name = "lblTotalProfitHeader";
            this.lblTotalProfitHeader.Size = new System.Drawing.Size(92, 24);
            this.lblTotalProfitHeader.TabIndex = 43;
            this.lblTotalProfitHeader.Text = "Total profit";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::GUI.Properties.Resources.investment;
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalJob);
            this.panel1.Controls.Add(this.lblTotalJobHeader);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(590, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 89);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalJob
            // 
            this.lblTotalJob.BackColor = System.Drawing.Color.White;
            this.lblTotalJob.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalJob.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalJob.Location = new System.Drawing.Point(90, 39);
            this.lblTotalJob.Name = "lblTotalJob";
            this.lblTotalJob.Size = new System.Drawing.Size(219, 30);
            this.lblTotalJob.TabIndex = 43;
            this.lblTotalJob.Text = "Total job ";
            this.lblTotalJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalJobHeader
            // 
            this.lblTotalJobHeader.AutoSize = true;
            this.lblTotalJobHeader.BackColor = System.Drawing.Color.White;
            this.lblTotalJobHeader.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalJobHeader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalJobHeader.Location = new System.Drawing.Point(86, 10);
            this.lblTotalJobHeader.Name = "lblTotalJobHeader";
            this.lblTotalJobHeader.Size = new System.Drawing.Size(79, 24);
            this.lblTotalJobHeader.TabIndex = 42;
            this.lblTotalJobHeader.Text = "Total job ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GUI.Properties.Resources.corporate_alt;
            this.pictureBox2.Location = new System.Drawing.Point(12, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.chart_histogram;
            this.pictureBox1.Location = new System.Drawing.Point(44, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.DimGray;
            this.lblMonth.Location = new System.Drawing.Point(173, 40);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(188, 54);
            this.lblMonth.TabIndex = 13;
            this.lblMonth.Text = "Time: 01";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DimGray;
            this.lblYear.Location = new System.Drawing.Point(352, 40);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(143, 54);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "- 2024";
            // 
            // picPreviousMonth
            // 
            this.picPreviousMonth.BackColor = System.Drawing.Color.Transparent;
            this.picPreviousMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPreviousMonth.Image = global::GUI.Properties.Resources.up1;
            this.picPreviousMonth.Location = new System.Drawing.Point(495, 43);
            this.picPreviousMonth.Name = "picPreviousMonth";
            this.picPreviousMonth.Size = new System.Drawing.Size(50, 50);
            this.picPreviousMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreviousMonth.TabIndex = 16;
            this.picPreviousMonth.TabStop = false;
            this.picPreviousMonth.Click += new System.EventHandler(this.picPreviousMonth_Click);
            // 
            // picNextMonth
            // 
            this.picNextMonth.BackColor = System.Drawing.Color.Transparent;
            this.picNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNextMonth.Image = global::GUI.Properties.Resources.down1;
            this.picNextMonth.Location = new System.Drawing.Point(551, 43);
            this.picNextMonth.Name = "picNextMonth";
            this.picNextMonth.Size = new System.Drawing.Size(50, 50);
            this.picNextMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNextMonth.TabIndex = 15;
            this.picNextMonth.TabStop = false;
            this.picNextMonth.Click += new System.EventHandler(this.picNextMonth_Click);
            // 
            // ucStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.picPreviousMonth);
            this.Controls.Add(this.picNextMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnThisYear);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Name = "ucStatic";
            this.Size = new System.Drawing.Size(995, 766);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cWage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviousMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btnThisYear;
        private Krypton.Toolkit.KryptonButton btnThisMonth;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cWage;
        private System.Windows.Forms.DataVisualization.Charting.Chart cJob;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalJobHeader;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblTotalProfitHeader;
        private System.Windows.Forms.Label lblTotalJob;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.PictureBox picPreviousMonth;
        private System.Windows.Forms.PictureBox picNextMonth;
    }
}
