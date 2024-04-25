namespace GUI
{
    partial class ucNotification
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
            this.btnNewJobNotificationContainer = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewJobNotificationHeader = new System.Windows.Forms.Label();
            this.fpnlNewJobNotificationContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnNewJobNotificationContainer
            // 
            this.btnNewJobNotificationContainer.Enabled = false;
            this.btnNewJobNotificationContainer.Location = new System.Drawing.Point(35, 34);
            this.btnNewJobNotificationContainer.Name = "btnNewJobNotificationContainer";
            this.btnNewJobNotificationContainer.Size = new System.Drawing.Size(923, 703);
            this.btnNewJobNotificationContainer.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.btnNewJobNotificationContainer.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.btnNewJobNotificationContainer.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.btnNewJobNotificationContainer.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.btnNewJobNotificationContainer.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewJobNotificationContainer.StateDisabled.Border.Rounding = 30F;
            this.btnNewJobNotificationContainer.StateDisabled.Border.Width = 1;
            this.btnNewJobNotificationContainer.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.btnNewJobNotificationContainer.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.btnNewJobNotificationContainer.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.btnNewJobNotificationContainer.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.btnNewJobNotificationContainer.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNewJobNotificationContainer.StateNormal.Border.Rounding = 30F;
            this.btnNewJobNotificationContainer.StateNormal.Border.Width = 1;
            this.btnNewJobNotificationContainer.TabIndex = 2;
            this.btnNewJobNotificationContainer.Values.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(203)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(35, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 14);
            this.panel1.TabIndex = 8;
            // 
            // lblNewJobNotificationHeader
            // 
            this.lblNewJobNotificationHeader.AutoSize = true;
            this.lblNewJobNotificationHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.lblNewJobNotificationHeader.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJobNotificationHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.lblNewJobNotificationHeader.Location = new System.Drawing.Point(73, 40);
            this.lblNewJobNotificationHeader.Name = "lblNewJobNotificationHeader";
            this.lblNewJobNotificationHeader.Size = new System.Drawing.Size(136, 34);
            this.lblNewJobNotificationHeader.TabIndex = 11;
            this.lblNewJobNotificationHeader.Text = "New Job";
            // 
            // fpnlNewJobNotificationContainer
            // 
            this.fpnlNewJobNotificationContainer.AutoScroll = true;
            this.fpnlNewJobNotificationContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.fpnlNewJobNotificationContainer.Location = new System.Drawing.Point(35, 97);
            this.fpnlNewJobNotificationContainer.Name = "fpnlNewJobNotificationContainer";
            this.fpnlNewJobNotificationContainer.Size = new System.Drawing.Size(923, 602);
            this.fpnlNewJobNotificationContainer.TabIndex = 14;
            // 
            // ucNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.fpnlNewJobNotificationContainer);
            this.Controls.Add(this.lblNewJobNotificationHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNewJobNotificationContainer);
            this.Name = "ucNotification";
            this.Size = new System.Drawing.Size(995, 766);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnNewJobNotificationContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewJobNotificationHeader;
        private System.Windows.Forms.FlowLayoutPanel fpnlNewJobNotificationContainer;
    }
}
