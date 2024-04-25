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
            this.lblWorkerAmount = new System.Windows.Forms.Label();
            this.lblSkillAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.Enabled = false;
            this.btnContainer.Location = new System.Drawing.Point(0, 0);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(282, 142);
            this.btnContainer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
            this.btnContainer.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
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
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblCategory.Location = new System.Drawing.Point(13, 17);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(249, 82);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category #i";
            // 
            // lblWorkerAmount
            // 
            this.lblWorkerAmount.AutoSize = true;
            this.lblWorkerAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
            this.lblWorkerAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblWorkerAmount.Location = new System.Drawing.Point(18, 108);
            this.lblWorkerAmount.Name = "lblWorkerAmount";
            this.lblWorkerAmount.Size = new System.Drawing.Size(107, 21);
            this.lblWorkerAmount.TabIndex = 2;
            this.lblWorkerAmount.Text = "#10 workers";
            this.lblWorkerAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSkillAmount
            // 
            this.lblSkillAmount.AutoSize = true;
            this.lblSkillAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
            this.lblSkillAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblSkillAmount.Location = new System.Drawing.Point(193, 108);
            this.lblSkillAmount.Name = "lblSkillAmount";
            this.lblSkillAmount.Size = new System.Drawing.Size(68, 21);
            this.lblSkillAmount.TabIndex = 3;
            this.lblSkillAmount.Text = "#4 skills";
            this.lblSkillAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucCategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblSkillAmount);
            this.Controls.Add(this.lblWorkerAmount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnContainer);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ucCategoryCard";
            this.Size = new System.Drawing.Size(282, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnContainer;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblWorkerAmount;
        private System.Windows.Forms.Label lblSkillAmount;
    }
}
