namespace GUI
{
    partial class ucHomeCategoryChoose
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
            this.label1 = new System.Windows.Forms.Label();
            this.fpnlCategoryContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse talent by category";
            // 
            // fpnlCategoryContainer
            // 
            this.fpnlCategoryContainer.AutoScroll = true;
            this.fpnlCategoryContainer.Location = new System.Drawing.Point(35, 100);
            this.fpnlCategoryContainer.Name = "fpnlCategoryContainer";
            this.fpnlCategoryContainer.Size = new System.Drawing.Size(941, 649);
            this.fpnlCategoryContainer.TabIndex = 1;
            // 
            // ucHomeCategoryChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.fpnlCategoryContainer);
            this.Controls.Add(this.label1);
            this.Name = "ucHomeCategoryChoose";
            this.Size = new System.Drawing.Size(1002, 749);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fpnlCategoryContainer;
    }
}
