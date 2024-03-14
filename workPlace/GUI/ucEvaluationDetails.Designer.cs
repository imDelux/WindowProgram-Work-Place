namespace GUI
{
    partial class ucEvaluationDetails
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
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.lblEvaluation.Location = new System.Drawing.Point(115, 24);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(258, 36);
            this.lblEvaluation.TabIndex = 0;
            this.lblEvaluation.Text = "EVALUATION";
            // 
            // flpContainer
            // 
            this.flpContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpContainer.Location = new System.Drawing.Point(0, 78);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(496, 582);
            this.flpContainer.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(496, 80);
            this.pnlTop.TabIndex = 2;
            // 
            // ucEvaluationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flpContainer);
            this.Controls.Add(this.lblEvaluation);
            this.Controls.Add(this.pnlTop);
            this.Name = "ucEvaluationDetails";
            this.Size = new System.Drawing.Size(496, 660);
            this.Load += new System.EventHandler(this.ucEvaluationDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.Panel pnlTop;
    }
}
