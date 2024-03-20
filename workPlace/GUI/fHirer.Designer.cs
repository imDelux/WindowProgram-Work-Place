namespace GUI
{
    partial class fHirer
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
            this.pnlLeft = new Krypton.Toolkit.KryptonPanel();
            this.btnHiring = new Krypton.Toolkit.KryptonButton();
            this.btnProfile = new Krypton.Toolkit.KryptonButton();
            this.btnHome = new Krypton.Toolkit.KryptonButton();
            this.pnlContainer = new Krypton.Toolkit.KryptonPanel();
            this.lblExtraText = new System.Windows.Forms.Label();
            this.pnlLogoContainer = new System.Windows.Forms.Panel();
            this.picLogo = new Krypton.Toolkit.KryptonPictureBox();
            this.picLogOut = new Krypton.Toolkit.KryptonPictureBox();
            this.picExit = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            this.pnlLogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.picLogOut);
            this.pnlLeft.Controls.Add(this.picExit);
            this.pnlLeft.Controls.Add(this.btnProfile);
            this.pnlLeft.Controls.Add(this.btnHiring);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.pnlLogoContainer);
            this.pnlLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(264, 766);
            this.pnlLeft.StateNormal.Color1 = System.Drawing.Color.White;
            this.pnlLeft.TabIndex = 0;
            // 
            // btnHiring
            // 
            this.btnHiring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHiring.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHiring.Location = new System.Drawing.Point(0, 272);
            this.btnHiring.Name = "btnHiring";
            this.btnHiring.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHiring.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHiring.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHiring.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHiring.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHiring.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHiring.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHiring.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHiring.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnHiring.Size = new System.Drawing.Size(264, 56);
            this.btnHiring.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnHiring.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnHiring.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnHiring.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHiring.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHiring.StateCommon.Border.Rounding = 1F;
            this.btnHiring.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnHiring.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHiring.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnHiring.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnHiring.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHiring.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHiring.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHiring.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHiring.TabIndex = 3;
            this.btnHiring.Values.Text = "Hiring";
            this.btnHiring.Click += new System.EventHandler(this.btnHiring_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Location = new System.Drawing.Point(0, 328);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProfile.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProfile.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProfile.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProfile.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnProfile.Size = new System.Drawing.Size(264, 56);
            this.btnProfile.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnProfile.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnProfile.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnProfile.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProfile.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnProfile.StateCommon.Border.Rounding = 2F;
            this.btnProfile.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnProfile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnProfile.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnProfile.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProfile.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Values.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 216);
            this.btnHome.Name = "btnHome";
            this.btnHome.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHome.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHome.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHome.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHome.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHome.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHome.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHome.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHome.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnHome.Size = new System.Drawing.Size(264, 56);
            this.btnHome.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnHome.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnHome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnHome.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHome.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHome.StateCommon.Border.Rounding = 0F;
            this.btnHome.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnHome.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnHome.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnHome.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHome.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHome.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHome.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHome.TabIndex = 2;
            this.btnHome.Values.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContainer.Location = new System.Drawing.Point(265, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(995, 766);
            this.pnlContainer.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.pnlContainer.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.pnlContainer.TabIndex = 1;
            // 
            // lblExtraText
            // 
            this.lblExtraText.AutoSize = true;
            this.lblExtraText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblExtraText.Location = new System.Drawing.Point(75, 139);
            this.lblExtraText.Name = "lblExtraText";
            this.lblExtraText.Size = new System.Drawing.Size(115, 21);
            this.lblExtraText.TabIndex = 1;
            this.lblExtraText.Text = "Unemployed";
            // 
            // pnlLogoContainer
            // 
            this.pnlLogoContainer.BackColor = System.Drawing.Color.White;
            this.pnlLogoContainer.Controls.Add(this.picLogo);
            this.pnlLogoContainer.Controls.Add(this.lblExtraText);
            this.pnlLogoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoContainer.Name = "pnlLogoContainer";
            this.pnlLogoContainer.Size = new System.Drawing.Size(264, 216);
            this.pnlLogoContainer.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.work_place_logo;
            this.picLogo.InitialImage = global::GUI.Properties.Resources.work_place_logo;
            this.picLogo.Location = new System.Drawing.Point(86, 42);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(92, 92);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picLogOut
            // 
            this.picLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogOut.Image = global::GUI.Properties.Resources.logout;
            this.picLogOut.Location = new System.Drawing.Point(170, 712);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(40, 40);
            this.picLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogOut.TabIndex = 13;
            this.picLogOut.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::GUI.Properties.Resources.reject;
            this.picExit.Location = new System.Drawing.Point(212, 714);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(38, 38);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 12;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click_1);
            // 
            // fHirer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1260, 766);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHirer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 20F;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "fHirer";
            this.Load += new System.EventHandler(this.fHirer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.pnlLogoContainer.ResumeLayout(false);
            this.pnlLogoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnlLeft;
        private Krypton.Toolkit.KryptonButton btnHiring;
        private Krypton.Toolkit.KryptonButton btnHome;
        private Krypton.Toolkit.KryptonButton btnProfile;
        private Krypton.Toolkit.KryptonPanel pnlContainer;
        private System.Windows.Forms.Panel pnlLogoContainer;
        private Krypton.Toolkit.KryptonPictureBox picLogo;
        private System.Windows.Forms.Label lblExtraText;
        private Krypton.Toolkit.KryptonPictureBox picLogOut;
        private Krypton.Toolkit.KryptonPictureBox picExit;
    }
}