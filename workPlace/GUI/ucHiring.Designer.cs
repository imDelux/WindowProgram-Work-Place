namespace GUI
{
    partial class ucHiring
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
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNoJobNotificationCancel = new System.Windows.Forms.Label();
            this.pnlPadding = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fpnlOnGoing = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlComplete = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlCancel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoJobNotificationComplete = new System.Windows.Forms.Label();
            this.lblNoJobNotificationOnGoing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.fpnlOnGoing.SuspendLayout();
            this.fpnlComplete.SuspendLayout();
            this.fpnlCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblThumbnail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.lblThumbnail.Location = new System.Drawing.Point(64, 18);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(244, 79);
            this.lblThumbnail.TabIndex = 7;
            this.lblThumbnail.Text = "Hiring";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(70, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "List hiring of worker";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.house_chimney;
            this.pictureBox4.Location = new System.Drawing.Point(893, 60);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // lblNoJobNotificationCancel
            // 
            this.lblNoJobNotificationCancel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoJobNotificationCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNoJobNotificationCancel.Location = new System.Drawing.Point(3, 0);
            this.lblNoJobNotificationCancel.Name = "lblNoJobNotificationCancel";
            this.lblNoJobNotificationCancel.Size = new System.Drawing.Size(988, 527);
            this.lblNoJobNotificationCancel.TabIndex = 14;
            this.lblNoJobNotificationCancel.Text = "No job notification at the moment.\r\n";
            this.lblNoJobNotificationCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPadding
            // 
            this.pnlPadding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.pnlPadding.Location = new System.Drawing.Point(305, 175);
            this.pnlPadding.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pnlPadding.Name = "pnlPadding";
            this.pnlPadding.Size = new System.Drawing.Size(705, 25);
            this.pnlPadding.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 172);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 567);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.fpnlOnGoing);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "On Going";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.fpnlComplete);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fpnlCancel);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1009, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cancel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fpnlOnGoing
            // 
            this.fpnlOnGoing.AutoScroll = true;
            this.fpnlOnGoing.Controls.Add(this.lblNoJobNotificationOnGoing);
            this.fpnlOnGoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlOnGoing.Location = new System.Drawing.Point(3, 3);
            this.fpnlOnGoing.Name = "fpnlOnGoing";
            this.fpnlOnGoing.Size = new System.Drawing.Size(994, 527);
            this.fpnlOnGoing.TabIndex = 0;
            // 
            // fpnlComplete
            // 
            this.fpnlComplete.AutoScroll = true;
            this.fpnlComplete.Controls.Add(this.lblNoJobNotificationComplete);
            this.fpnlComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlComplete.Location = new System.Drawing.Point(3, 3);
            this.fpnlComplete.Name = "fpnlComplete";
            this.fpnlComplete.Size = new System.Drawing.Size(994, 527);
            this.fpnlComplete.TabIndex = 1;
            // 
            // fpnlCancel
            // 
            this.fpnlCancel.AutoScroll = true;
            this.fpnlCancel.Controls.Add(this.lblNoJobNotificationCancel);
            this.fpnlCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlCancel.Location = new System.Drawing.Point(3, 3);
            this.fpnlCancel.Name = "fpnlCancel";
            this.fpnlCancel.Size = new System.Drawing.Size(1003, 527);
            this.fpnlCancel.TabIndex = 1;
            // 
            // lblNoJobNotificationComplete
            // 
            this.lblNoJobNotificationComplete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoJobNotificationComplete.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNoJobNotificationComplete.Location = new System.Drawing.Point(3, 0);
            this.lblNoJobNotificationComplete.Name = "lblNoJobNotificationComplete";
            this.lblNoJobNotificationComplete.Size = new System.Drawing.Size(988, 527);
            this.lblNoJobNotificationComplete.TabIndex = 15;
            this.lblNoJobNotificationComplete.Text = "No job notification at the moment.\r\n";
            this.lblNoJobNotificationComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoJobNotificationOnGoing
            // 
            this.lblNoJobNotificationOnGoing.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoJobNotificationOnGoing.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNoJobNotificationOnGoing.Location = new System.Drawing.Point(3, 0);
            this.lblNoJobNotificationOnGoing.Name = "lblNoJobNotificationOnGoing";
            this.lblNoJobNotificationOnGoing.Size = new System.Drawing.Size(988, 527);
            this.lblNoJobNotificationOnGoing.TabIndex = 15;
            this.lblNoJobNotificationOnGoing.Text = "No job notification at the moment.\r\n";
            this.lblNoJobNotificationOnGoing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucHiring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlPadding);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThumbnail);
            this.Name = "ucHiring";
            this.Size = new System.Drawing.Size(1017, 749);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.fpnlOnGoing.ResumeLayout(false);
            this.fpnlComplete.ResumeLayout(false);
            this.fpnlCancel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblNoJobNotificationCancel;
        private System.Windows.Forms.Panel pnlPadding;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel fpnlOnGoing;
        private System.Windows.Forms.FlowLayoutPanel fpnlComplete;
        private System.Windows.Forms.FlowLayoutPanel fpnlCancel;
        private System.Windows.Forms.Label lblNoJobNotificationOnGoing;
        private System.Windows.Forms.Label lblNoJobNotificationComplete;
    }
}
