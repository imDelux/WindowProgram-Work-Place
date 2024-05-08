namespace GUI
{
    partial class ucHomeSpecificCategory
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
            this.pnlTop = new Krypton.Toolkit.KryptonPanel();
            this.cbbArrangeType = new Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.fpnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbArrangeType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cbbArrangeType);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.pnlTop.Size = new System.Drawing.Size(1002, 78);
            this.pnlTop.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.pnlTop.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.pnlTop.TabIndex = 4;
            // 
            // cbbArrangeType
            // 
            this.cbbArrangeType.DropButtonStyle = Krypton.Toolkit.ButtonStyle.FormClose;
            this.cbbArrangeType.DropDownWidth = 212;
            this.cbbArrangeType.IntegralHeight = false;
            this.cbbArrangeType.Items.AddRange(new object[] {
            "Rate",
            "Job receive"});
            this.cbbArrangeType.Location = new System.Drawing.Point(758, 27);
            this.cbbArrangeType.Name = "cbbArrangeType";
            this.cbbArrangeType.Size = new System.Drawing.Size(218, 38);
            this.cbbArrangeType.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
            this.cbbArrangeType.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray;
            this.cbbArrangeType.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbArrangeType.StateCommon.ComboBox.Border.Rounding = 10F;
            this.cbbArrangeType.StateCommon.ComboBox.Border.Width = 1;
            this.cbbArrangeType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
            this.cbbArrangeType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbArrangeType.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(0);
            this.cbbArrangeType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.cbbArrangeType.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.cbbArrangeType.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.DimGray;
            this.cbbArrangeType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbArrangeType.StateCommon.Item.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbArrangeType.TabIndex = 2;
            this.cbbArrangeType.Text = "Arrange type ..";
            this.cbbArrangeType.SelectedIndexChanged += new System.EventHandler(this.cbbArrangeType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(514, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 45);
            this.btnSearch.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnSearch.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.btnSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 20F;
            this.btnSearch.StateCommon.Border.Width = 1;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Values.Image = global::GUI.Properties.Resources._211818_search_icon;
            this.btnSearch.Values.Text = "";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Location = new System.Drawing.Point(44, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtSearch.Size = new System.Drawing.Size(464, 45);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 20F;
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search ...";
            this.txtSearch.ToolTipValues.Image = global::GUI.Properties.Resources._211818_search_icon;
            // 
            // fpnlContainer
            // 
            this.fpnlContainer.AutoScroll = true;
            this.fpnlContainer.Location = new System.Drawing.Point(46, 166);
            this.fpnlContainer.Name = "fpnlContainer";
            this.fpnlContainer.Size = new System.Drawing.Size(930, 563);
            this.fpnlContainer.TabIndex = 5;
            this.fpnlContainer.Tag = "Arrange type";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.lblCategory.Location = new System.Drawing.Point(35, 92);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(941, 54);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucHomeSpecificCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.fpnlContainer);
            this.Name = "ucHomeSpecificCategory";
            this.Size = new System.Drawing.Size(1002, 749);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbArrangeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPanel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel fpnlContainer;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonComboBox cbbArrangeType;
    }
}
