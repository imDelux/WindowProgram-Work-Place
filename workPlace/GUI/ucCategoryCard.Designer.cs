namespace GUI
{
    partial class ucCategoryCard
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
            this.btnContainer = new Krypton.Toolkit.KryptonButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnGoto = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContainer.Enabled = false;
            this.btnContainer.Location = new System.Drawing.Point(0, 0);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(282, 142);
            this.btnContainer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
            this.btnContainer.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
            this.btnContainer.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnContainer.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnContainer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContainer.StateCommon.Border.Rounding = 20F;
            this.btnContainer.TabIndex = 0;
            this.btnContainer.Values.Text = "";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
            this.lblCategory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCategory.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategory.Location = new System.Drawing.Point(14, 21);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(249, 72);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category #i";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoto
            // 
            this.btnGoto.Location = new System.Drawing.Point(0, 96);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnGoto.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnGoto.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.btnGoto.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.btnGoto.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGoto.OverrideDefault.Border.Rounding = 20F;
            this.btnGoto.OverrideDefault.Border.Width = 2;
            this.btnGoto.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnGoto.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnGoto.Size = new System.Drawing.Size(282, 46);
            this.btnGoto.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnGoto.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnGoto.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnGoto.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnGoto.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGoto.StateCommon.Border.Rounding = 20F;
            this.btnGoto.StateCommon.Border.Width = 2;
            this.btnGoto.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnGoto.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoto.StateTracking.Border.Color1 = System.Drawing.Color.Silver;
            this.btnGoto.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGoto.StateTracking.Border.Width = 1;
            this.btnGoto.TabIndex = 2;
            this.btnGoto.Values.Text = "GO";
            // 
            // ucCategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnGoto);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnContainer);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ucCategoryCard";
            this.Size = new System.Drawing.Size(282, 142);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnContainer;
        public Krypton.Toolkit.KryptonButton btnGoto;
        private System.Windows.Forms.Label lblCategory;
    }
}
