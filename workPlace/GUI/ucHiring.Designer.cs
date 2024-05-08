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
            this.fpnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPadding = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNoJobNotification = new System.Windows.Forms.Label();
            this.fpnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            // fpnlContainer
            // 
            this.fpnlContainer.AutoScroll = true;
            this.fpnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.fpnlContainer.Controls.Add(this.pnlPadding);
            this.fpnlContainer.Controls.Add(this.lblNoJobNotification);
            this.fpnlContainer.Location = new System.Drawing.Point(3, 169);
            this.fpnlContainer.Name = "fpnlContainer";
            this.fpnlContainer.Size = new System.Drawing.Size(1038, 577);
            this.fpnlContainer.TabIndex = 13;
            // 
            // pnlPadding
            // 
            this.pnlPadding.Location = new System.Drawing.Point(3, 3);
            this.pnlPadding.Name = "pnlPadding";
            this.pnlPadding.Size = new System.Drawing.Size(1008, 25);
            this.pnlPadding.TabIndex = 0;
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
            // lblNoJobNotification
            // 
            this.lblNoJobNotification.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoJobNotification.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNoJobNotification.Location = new System.Drawing.Point(3, 31);
            this.lblNoJobNotification.Name = "lblNoJobNotification";
            this.lblNoJobNotification.Size = new System.Drawing.Size(1008, 546);
            this.lblNoJobNotification.TabIndex = 1;
            this.lblNoJobNotification.Text = "No job notification at the moment.\r\n";
            this.lblNoJobNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucHiring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fpnlContainer);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThumbnail);
            this.Name = "ucHiring";
            this.Size = new System.Drawing.Size(1017, 749);
            this.fpnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel fpnlContainer;
        private System.Windows.Forms.Panel pnlPadding;
        private System.Windows.Forms.Label lblNoJobNotification;
    }
}
