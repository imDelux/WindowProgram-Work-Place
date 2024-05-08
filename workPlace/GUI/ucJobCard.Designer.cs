namespace GUI
{
    partial class ucJobCard
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
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.lblJobDescription = new System.Windows.Forms.Label();
            this.lblSkillField = new System.Windows.Forms.Label();
            this.lblAppliedNumber = new System.Windows.Forms.Label();
            this.lblJobWage = new System.Windows.Forms.Label();
            this.btnContainer = new Krypton.Toolkit.KryptonButton();
            this.picDemo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJobName
            // 
            this.lblJobName.AutoEllipsis = true;
            this.lblJobName.BackColor = System.Drawing.Color.White;
            this.lblJobName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJobName.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.ForeColor = System.Drawing.Color.Black;
            this.lblJobName.Location = new System.Drawing.Point(187, 14);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(569, 49);
            this.lblJobName.TabIndex = 22;
            this.lblJobName.Text = "Job Name";
            this.lblJobName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoEllipsis = true;
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.BackColor = System.Drawing.Color.White;
            this.lblJobDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDate.ForeColor = System.Drawing.Color.Black;
            this.lblJobDate.Location = new System.Drawing.Point(189, 64);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(89, 21);
            this.lblJobDate.TabIndex = 23;
            this.lblJobDate.Text = "Job date";
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.AutoEllipsis = true;
            this.lblJobDescription.BackColor = System.Drawing.Color.White;
            this.lblJobDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDescription.ForeColor = System.Drawing.Color.Black;
            this.lblJobDescription.Location = new System.Drawing.Point(189, 92);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(566, 24);
            this.lblJobDescription.TabIndex = 24;
            this.lblJobDescription.Text = "Write your description in here";
            // 
            // lblSkillField
            // 
            this.lblSkillField.AutoEllipsis = true;
            this.lblSkillField.AutoSize = true;
            this.lblSkillField.BackColor = System.Drawing.Color.White;
            this.lblSkillField.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillField.ForeColor = System.Drawing.Color.Black;
            this.lblSkillField.Location = new System.Drawing.Point(189, 122);
            this.lblSkillField.Name = "lblSkillField";
            this.lblSkillField.Size = new System.Drawing.Size(269, 21);
            this.lblSkillField.TabIndex = 26;
            this.lblSkillField.Text = "Required Skill: [what skill field?]";
            // 
            // lblAppliedNumber
            // 
            this.lblAppliedNumber.AutoEllipsis = true;
            this.lblAppliedNumber.BackColor = System.Drawing.Color.White;
            this.lblAppliedNumber.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliedNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAppliedNumber.Location = new System.Drawing.Point(774, 102);
            this.lblAppliedNumber.Name = "lblAppliedNumber";
            this.lblAppliedNumber.Size = new System.Drawing.Size(121, 41);
            this.lblAppliedNumber.TabIndex = 28;
            this.lblAppliedNumber.Text = "Applied: xx";
            this.lblAppliedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJobWage
            // 
            this.lblJobWage.AutoEllipsis = true;
            this.lblJobWage.AutoSize = true;
            this.lblJobWage.BackColor = System.Drawing.Color.White;
            this.lblJobWage.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobWage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblJobWage.Location = new System.Drawing.Point(802, 15);
            this.lblJobWage.Name = "lblJobWage";
            this.lblJobWage.Size = new System.Drawing.Size(89, 39);
            this.lblJobWage.TabIndex = 29;
            this.lblJobWage.Text = "100$";
            // 
            // btnContainer
            // 
            this.btnContainer.Enabled = false;
            this.btnContainer.Location = new System.Drawing.Point(0, 0);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(912, 163);
            this.btnContainer.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnContainer.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnContainer.StateCommon.Back.ColorAngle = 180F;
            this.btnContainer.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnContainer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContainer.StateCommon.Border.Rounding = 20F;
            this.btnContainer.StateCommon.Border.Width = 2;
            this.btnContainer.TabIndex = 30;
            this.btnContainer.Values.Text = "";
            // 
            // picDemo
            // 
            this.picDemo.BackColor = System.Drawing.Color.White;
            this.picDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDemo.Image = global::GUI.Properties.Resources.briefcase__1_;
            this.picDemo.Location = new System.Drawing.Point(43, 25);
            this.picDemo.Name = "picDemo";
            this.picDemo.Size = new System.Drawing.Size(110, 110);
            this.picDemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDemo.TabIndex = 25;
            this.picDemo.TabStop = false;
            // 
            // ucJobCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblJobWage);
            this.Controls.Add(this.lblAppliedNumber);
            this.Controls.Add(this.lblSkillField);
            this.Controls.Add(this.picDemo);
            this.Controls.Add(this.lblJobDescription);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.btnContainer);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "ucJobCard";
            this.Size = new System.Drawing.Size(912, 163);
            ((System.ComponentModel.ISupportInitialize)(this.picDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Label lblJobDescription;
        private System.Windows.Forms.PictureBox picDemo;
        private System.Windows.Forms.Label lblSkillField;
        private System.Windows.Forms.Label lblAppliedNumber;
        private System.Windows.Forms.Label lblJobWage;
        private Krypton.Toolkit.KryptonButton btnContainer;
    }
}
