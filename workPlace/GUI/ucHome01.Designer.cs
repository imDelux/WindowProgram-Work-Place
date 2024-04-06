namespace GUI
{
    partial class ucHome01
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
            this.fpnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fpnlContainer
            // 
            this.fpnlContainer.AutoScroll = true;
            this.fpnlContainer.Location = new System.Drawing.Point(41, 60);
            this.fpnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.fpnlContainer.Name = "fpnlContainer";
            this.fpnlContainer.Size = new System.Drawing.Size(716, 508);
            this.fpnlContainer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Browse talent by category";
            // 
            // ucHome01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlContainer);
            this.Controls.Add(this.label1);
            this.Name = "ucHome01";
            this.Size = new System.Drawing.Size(802, 599);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlContainer;
        private System.Windows.Forms.Label label1;
    }
}
