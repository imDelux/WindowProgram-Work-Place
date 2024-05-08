namespace GUI
{
    partial class ucNewNotificationMessage
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
            this.lblJobDescription = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJobDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblJobDescription.Location = new System.Drawing.Point(316, 5);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(330, 35);
            this.lblJobDescription.TabIndex = 2;
            this.lblJobDescription.Text = "Chieu 13g tai nga ba Di An anh can chu sua tivi";
            this.lblJobDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJobDescription.Click += new System.EventHandler(this.ucNewNotificationMessage_Click);
            // 
            // lblJobName
            // 
            this.lblJobName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(13, 3);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(267, 35);
            this.lblJobName.TabIndex = 3;
            this.lblJobName.Text = "SUA TIVI BI HONG NGUON";
            this.lblJobName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJobName.Click += new System.EventHandler(this.ucNewNotificationMessage_Click);
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.ForeColor = System.Drawing.Color.Gray;
            this.lblWage.Location = new System.Drawing.Point(723, 6);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(60, 28);
            this.lblWage.TabIndex = 4;
            this.lblWage.Text = "100$";
            this.lblWage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWage.Click += new System.EventHandler(this.ucNewNotificationMessage_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(851, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 28);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "10/03";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.ucNewNotificationMessage_Click);
            // 
            // ucNewNotificationMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblJobDescription);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Name = "ucNewNotificationMessage";
            this.Size = new System.Drawing.Size(923, 42);
            this.Click += new System.EventHandler(this.ucNewNotificationMessage_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJobDescription;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblDate;
    }
}
