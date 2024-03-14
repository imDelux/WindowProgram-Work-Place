namespace GUI
{
    partial class ucHome
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
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2 = new Krypton.Toolkit.KryptonComboBox();
            this.pnlTop = new Krypton.Toolkit.KryptonPanel();
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 121;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Location = new System.Drawing.Point(559, 21);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonComboBox1.Size = new System.Drawing.Size(168, 33);
            this.kryptonComboBox1.Sorted = true;
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 20F;
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 1;
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownWidth = 121;
            this.kryptonComboBox2.IntegralHeight = false;
            this.kryptonComboBox2.Location = new System.Drawing.Point(756, 21);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonComboBox2.Size = new System.Drawing.Size(168, 33);
            this.kryptonComboBox2.Sorted = true;
            this.kryptonComboBox2.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox2.StateCommon.ComboBox.Border.Rounding = 20F;
            this.kryptonComboBox2.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox2.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.kryptonComboBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.pnlTop.Size = new System.Drawing.Size(1002, 80);
            this.pnlTop.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.pnlTop.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.pnlTop.TabIndex = 4;
            // 
            // flpContainer
            // 
            this.flpContainer.Location = new System.Drawing.Point(50, 94);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(902, 655);
            this.flpContainer.TabIndex = 5;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::GUI.Properties.Resources._6351933_filter_filters_funnel_seo_sort_icon;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(948, 21);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 2;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtSearch.Location = new System.Drawing.Point(35, 21);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtSearch.Size = new System.Drawing.Size(488, 33);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 20F;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 0;
            this.txtSearch.ToolTipValues.Image = global::GUI.Properties.Resources._211818_search_icon;
            // 
            // ucHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.kryptonPictureBox1);
            this.Controls.Add(this.kryptonComboBox2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.flpContainer);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1002, 749);
            this.Load += new System.EventHandler(this.ucHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPanel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
    }
}
