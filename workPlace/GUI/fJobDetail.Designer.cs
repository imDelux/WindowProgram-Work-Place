namespace GUI
{
    partial class fJobDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJobNameHead = new System.Windows.Forms.Label();
            this.lblJobDescriptHead = new System.Windows.Forms.Label();
            this.lblJobDateHead = new System.Windows.Forms.Label();
            this.lblJobWageHead = new System.Windows.Forms.Label();
            this.lblJobStatusHead = new System.Windows.Forms.Label();
            this.lblJobPaidStatusHead = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblJobDescript = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.lblJobWage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.lblHirerName = new System.Windows.Forms.Label();
            this.lblHirerNameHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJobNameHead
            // 
            this.lblJobNameHead.AutoSize = true;
            this.lblJobNameHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobNameHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobNameHead.Location = new System.Drawing.Point(34, 70);
            this.lblJobNameHead.Name = "lblJobNameHead";
            this.lblJobNameHead.Size = new System.Drawing.Size(109, 23);
            this.lblJobNameHead.TabIndex = 1;
            this.lblJobNameHead.Text = "Job name";
            // 
            // lblJobDescriptHead
            // 
            this.lblJobDescriptHead.AutoSize = true;
            this.lblJobDescriptHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDescriptHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobDescriptHead.Location = new System.Drawing.Point(34, 106);
            this.lblJobDescriptHead.Name = "lblJobDescriptHead";
            this.lblJobDescriptHead.Size = new System.Drawing.Size(118, 46);
            this.lblJobDescriptHead.TabIndex = 2;
            this.lblJobDescriptHead.Text = "Job\r\ndescription";
            // 
            // lblJobDateHead
            // 
            this.lblJobDateHead.AutoSize = true;
            this.lblJobDateHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDateHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobDateHead.Location = new System.Drawing.Point(34, 184);
            this.lblJobDateHead.Name = "lblJobDateHead";
            this.lblJobDateHead.Size = new System.Drawing.Size(56, 23);
            this.lblJobDateHead.TabIndex = 3;
            this.lblJobDateHead.Text = "Date";
            // 
            // lblJobWageHead
            // 
            this.lblJobWageHead.AutoSize = true;
            this.lblJobWageHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobWageHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobWageHead.Location = new System.Drawing.Point(34, 222);
            this.lblJobWageHead.Name = "lblJobWageHead";
            this.lblJobWageHead.Size = new System.Drawing.Size(67, 23);
            this.lblJobWageHead.TabIndex = 4;
            this.lblJobWageHead.Text = "Wage";
            // 
            // lblJobStatusHead
            // 
            this.lblJobStatusHead.AutoSize = true;
            this.lblJobStatusHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobStatusHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobStatusHead.Location = new System.Drawing.Point(34, 258);
            this.lblJobStatusHead.Name = "lblJobStatusHead";
            this.lblJobStatusHead.Size = new System.Drawing.Size(66, 23);
            this.lblJobStatusHead.TabIndex = 5;
            this.lblJobStatusHead.Text = "Status";
            // 
            // lblJobPaidStatusHead
            // 
            this.lblJobPaidStatusHead.AutoSize = true;
            this.lblJobPaidStatusHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobPaidStatusHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobPaidStatusHead.Location = new System.Drawing.Point(34, 294);
            this.lblJobPaidStatusHead.Name = "lblJobPaidStatusHead";
            this.lblJobPaidStatusHead.Size = new System.Drawing.Size(52, 23);
            this.lblJobPaidStatusHead.TabIndex = 6;
            this.lblJobPaidStatusHead.Text = "Paid";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobName.Location = new System.Drawing.Point(186, 70);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(235, 23);
            this.lblJobName.TabIndex = 7;
            this.lblJobName.Text = "Job name goes here ...";
            // 
            // lblJobDescript
            // 
            this.lblJobDescript.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDescript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobDescript.Location = new System.Drawing.Point(186, 106);
            this.lblJobDescript.Name = "lblJobDescript";
            this.lblJobDescript.Size = new System.Drawing.Size(323, 76);
            this.lblJobDescript.TabIndex = 8;
            this.lblJobDescript.Text = "Job description goes here ...\r\n";
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobDate.Location = new System.Drawing.Point(186, 184);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(225, 23);
            this.lblJobDate.TabIndex = 9;
            this.lblJobDate.Text = "Job date goes here ...";
            // 
            // lblJobWage
            // 
            this.lblJobWage.AutoSize = true;
            this.lblJobWage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobWage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobWage.Location = new System.Drawing.Point(186, 222);
            this.lblJobWage.Name = "lblJobWage";
            this.lblJobWage.Size = new System.Drawing.Size(235, 23);
            this.lblJobWage.TabIndex = 10;
            this.lblJobWage.Text = "Job wage goes here ,,,";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(165, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 14;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.cbStatus.Location = new System.Drawing.Point(190, 257);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(85, 27);
            this.cbStatus.TabIndex = 15;
            this.cbStatus.Text = "Done";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.cbPaid.Location = new System.Drawing.Point(190, 290);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(85, 27);
            this.cbPaid.TabIndex = 16;
            this.cbPaid.Text = "Done";
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // lblHirerName
            // 
            this.lblHirerName.AutoSize = true;
            this.lblHirerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHirerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblHirerName.Location = new System.Drawing.Point(186, 36);
            this.lblHirerName.Name = "lblHirerName";
            this.lblHirerName.Size = new System.Drawing.Size(240, 23);
            this.lblHirerName.TabIndex = 19;
            this.lblHirerName.Text = "Hirer name goes here ...";
            // 
            // lblHirerNameHeader
            // 
            this.lblHirerNameHeader.AutoSize = true;
            this.lblHirerNameHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHirerNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblHirerNameHeader.Location = new System.Drawing.Point(34, 36);
            this.lblHirerNameHeader.Name = "lblHirerNameHeader";
            this.lblHirerNameHeader.Size = new System.Drawing.Size(58, 23);
            this.lblHirerNameHeader.TabIndex = 18;
            this.lblHirerNameHeader.Text = "From";
            // 
            // fJobDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(530, 351);
            this.Controls.Add(this.lblHirerName);
            this.Controls.Add(this.lblHirerNameHeader);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblJobWage);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.lblJobDescript);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblJobPaidStatusHead);
            this.Controls.Add(this.lblJobStatusHead);
            this.Controls.Add(this.lblJobWageHead);
            this.Controls.Add(this.lblJobDateHead);
            this.Controls.Add(this.lblJobDescriptHead);
            this.Controls.Add(this.lblJobNameHead);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fJobDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.StateActive.Back.Draw = Krypton.Toolkit.InheritBool.True;
            this.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.StateActive.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 20F;
            this.StateActive.Border.Width = 0;
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Width = 1;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJobNameHead;
        private System.Windows.Forms.Label lblJobDescriptHead;
        private System.Windows.Forms.Label lblJobDateHead;
        private System.Windows.Forms.Label lblJobWageHead;
        private System.Windows.Forms.Label lblJobStatusHead;
        private System.Windows.Forms.Label lblJobPaidStatusHead;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblJobDescript;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Label lblJobWage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.Label lblHirerName;
        private System.Windows.Forms.Label lblHirerNameHeader;
    }
}