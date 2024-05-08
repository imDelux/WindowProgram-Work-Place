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
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblJobDescript = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.lblJobWage = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnRate = new Krypton.Toolkit.KryptonButton();
            this.cbCancel = new System.Windows.Forms.CheckBox();
            this.lblHirerNameHeader = new System.Windows.Forms.Label();
            this.lblRemainUserName = new System.Windows.Forms.Label();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.lblJobStatusHead = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobNameHead
            // 
            this.lblJobNameHead.AutoSize = true;
            this.lblJobNameHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobNameHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobNameHead.Location = new System.Drawing.Point(19, 43);
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
            this.lblJobDescriptHead.Location = new System.Drawing.Point(19, 79);
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
            this.lblJobDateHead.Location = new System.Drawing.Point(19, 157);
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
            this.lblJobWageHead.Location = new System.Drawing.Point(19, 195);
            this.lblJobWageHead.Name = "lblJobWageHead";
            this.lblJobWageHead.Size = new System.Drawing.Size(67, 23);
            this.lblJobWageHead.TabIndex = 4;
            this.lblJobWageHead.Text = "Wage";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobName.Location = new System.Drawing.Point(171, 43);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(235, 23);
            this.lblJobName.TabIndex = 7;
            this.lblJobName.Text = "Job name goes here ...";
            // 
            // lblJobDescript
            // 
            this.lblJobDescript.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDescript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobDescript.Location = new System.Drawing.Point(171, 79);
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
            this.lblJobDate.Location = new System.Drawing.Point(171, 157);
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
            this.lblJobWage.Location = new System.Drawing.Point(171, 195);
            this.lblJobWage.Name = "lblJobWage";
            this.lblJobWage.Size = new System.Drawing.Size(235, 23);
            this.lblJobWage.TabIndex = 10;
            this.lblJobWage.Text = "Job wage goes here ,,,";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnDelete);
            this.pnlContainer.Controls.Add(this.btnRate);
            this.pnlContainer.Controls.Add(this.cbCancel);
            this.pnlContainer.Controls.Add(this.lblHirerNameHeader);
            this.pnlContainer.Controls.Add(this.lblRemainUserName);
            this.pnlContainer.Controls.Add(this.lblJobNameHead);
            this.pnlContainer.Controls.Add(this.lblJobDescriptHead);
            this.pnlContainer.Controls.Add(this.cbDone);
            this.pnlContainer.Controls.Add(this.lblJobDateHead);
            this.pnlContainer.Controls.Add(this.lblJobWageHead);
            this.pnlContainer.Controls.Add(this.lblJobWage);
            this.pnlContainer.Controls.Add(this.lblJobStatusHead);
            this.pnlContainer.Controls.Add(this.lblJobDate);
            this.pnlContainer.Controls.Add(this.lblJobName);
            this.pnlContainer.Controls.Add(this.lblJobDescript);
            this.pnlContainer.Location = new System.Drawing.Point(12, 26);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(506, 265);
            this.pnlContainer.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.btnDelete.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray;
            this.btnDelete.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.OverrideDefault.Border.Width = 2;
            this.btnDelete.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnDelete.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.btnDelete.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Width = 2;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(404, 231);
            this.btnRate.Name = "btnRate";
            this.btnRate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRate.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.btnRate.OverrideDefault.Border.Color2 = System.Drawing.Color.Gray;
            this.btnRate.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRate.OverrideDefault.Border.Width = 2;
            this.btnRate.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRate.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRate.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRate.Size = new System.Drawing.Size(90, 25);
            this.btnRate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRate.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnRate.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.btnRate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRate.StateCommon.Border.Width = 2;
            this.btnRate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.TabIndex = 21;
            this.btnRate.Values.Text = "Rate";
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // cbCancel
            // 
            this.cbCancel.AutoSize = true;
            this.cbCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.cbCancel.Location = new System.Drawing.Point(282, 230);
            this.cbCancel.Name = "cbCancel";
            this.cbCancel.Size = new System.Drawing.Size(105, 27);
            this.cbCancel.TabIndex = 20;
            this.cbCancel.Text = "Cancel";
            this.cbCancel.UseVisualStyleBackColor = true;
            this.cbCancel.Click += new System.EventHandler(this.cbCancel_Click);
            // 
            // lblHirerNameHeader
            // 
            this.lblHirerNameHeader.AutoSize = true;
            this.lblHirerNameHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHirerNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblHirerNameHeader.Location = new System.Drawing.Point(19, 9);
            this.lblHirerNameHeader.Name = "lblHirerNameHeader";
            this.lblHirerNameHeader.Size = new System.Drawing.Size(58, 23);
            this.lblHirerNameHeader.TabIndex = 18;
            this.lblHirerNameHeader.Text = "From";
            // 
            // lblRemainUserName
            // 
            this.lblRemainUserName.AutoSize = true;
            this.lblRemainUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemainUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblRemainUserName.Location = new System.Drawing.Point(171, 9);
            this.lblRemainUserName.Name = "lblRemainUserName";
            this.lblRemainUserName.Size = new System.Drawing.Size(305, 23);
            this.lblRemainUserName.TabIndex = 19;
            this.lblRemainUserName.Text = "Destination name goes here ...";
            this.lblRemainUserName.Click += new System.EventHandler(this.lblRemainUserName_Click);
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.cbDone.Location = new System.Drawing.Point(175, 230);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(85, 27);
            this.cbDone.TabIndex = 15;
            this.cbDone.Text = "Done";
            this.cbDone.UseVisualStyleBackColor = true;
            this.cbDone.Click += new System.EventHandler(this.cbStatus_Click);
            // 
            // lblJobStatusHead
            // 
            this.lblJobStatusHead.AutoSize = true;
            this.lblJobStatusHead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobStatusHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblJobStatusHead.Location = new System.Drawing.Point(19, 231);
            this.lblJobStatusHead.Name = "lblJobStatusHead";
            this.lblJobStatusHead.Size = new System.Drawing.Size(66, 23);
            this.lblJobStatusHead.TabIndex = 5;
            this.lblJobStatusHead.Text = "Status";
            // 
            // fJobDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(530, 314);
            this.Controls.Add(this.pnlContainer);
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
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblJobNameHead;
        private System.Windows.Forms.Label lblJobDescriptHead;
        private System.Windows.Forms.Label lblJobDateHead;
        private System.Windows.Forms.Label lblJobWageHead;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblJobDescript;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Label lblJobWage;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblHirerNameHeader;
        private System.Windows.Forms.Label lblRemainUserName;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Label lblJobStatusHead;
        private System.Windows.Forms.CheckBox cbCancel;
        private Krypton.Toolkit.KryptonButton btnRate;
        private Krypton.Toolkit.KryptonButton btnDelete;
    }
}