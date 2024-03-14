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
            this.pnlLeftTop = new Krypton.Toolkit.KryptonPanel();
            this.lblUnemployed = new System.Windows.Forms.Label();
            this.pnlContainer = new Krypton.Toolkit.KryptonPanel();
            this.picLogOut = new Krypton.Toolkit.KryptonPictureBox();
            this.picExit = new Krypton.Toolkit.KryptonPictureBox();
            this.picAvatar = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).BeginInit();
            this.pnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.picLogOut);
            this.pnlLeft.Controls.Add(this.picExit);
            this.pnlLeft.Controls.Add(this.btnHiring);
            this.pnlLeft.Controls.Add(this.btnProfile);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(264, 749);
            this.pnlLeft.StateNormal.Color1 = System.Drawing.Color.White;
            this.pnlLeft.TabIndex = 0;
            // 
            // btnHiring
            // 
            this.btnHiring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHiring.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHiring.Location = new System.Drawing.Point(0, 296);
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
            this.btnHiring.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Bold);
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
            this.btnProfile.Location = new System.Drawing.Point(0, 352);
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
            this.btnProfile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnProfile.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnProfile.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProfile.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Values.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 240);
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
            this.btnHome.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.btnHome.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnHome.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnHome.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHome.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnHome.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHome.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHome.TabIndex = 3;
            this.btnHome.Values.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.lblUnemployed);
            this.pnlLeftTop.Controls.Add(this.picAvatar);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(264, 240);
            this.pnlLeftTop.StateNormal.Color1 = System.Drawing.Color.White;
            this.pnlLeftTop.TabIndex = 1;
            // 
            // lblUnemployed
            // 
            this.lblUnemployed.AutoSize = true;
            this.lblUnemployed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnemployed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnemployed.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnemployed.Location = new System.Drawing.Point(84, 139);
            this.lblUnemployed.Name = "lblUnemployed";
            this.lblUnemployed.Size = new System.Drawing.Size(95, 19);
            this.lblUnemployed.TabIndex = 2;
            this.lblUnemployed.Text = "Unemployed";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContainer.Location = new System.Drawing.Point(270, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(990, 749);
            this.pnlContainer.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.pnlContainer.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.pnlContainer.TabIndex = 1;
            // 
            // picLogOut
            // 
            this.picLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogOut.Image = global::GUI.Properties.Resources._618316_arrow_exit_logout_sign_out_icon;
            this.picLogOut.Location = new System.Drawing.Point(170, 699);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(38, 38);
            this.picLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogOut.TabIndex = 1;
            this.picLogOut.TabStop = false;
            this.picLogOut.Click += new System.EventHandler(this.picLogOut_Click);
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::GUI.Properties.Resources._4781838_cancel_close_delete_exit_logout_icon;
            this.picExit.Location = new System.Drawing.Point(214, 699);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(38, 38);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 1;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::GUI.Properties.Resources.Pro;
            this.picAvatar.Location = new System.Drawing.Point(86, 31);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(92, 92);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // fHirer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1260, 749);
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
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeftTop)).EndInit();
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnlLeft;
        private Krypton.Toolkit.KryptonPanel pnlLeftTop;
        private Krypton.Toolkit.KryptonPictureBox picAvatar;
        private System.Windows.Forms.Label lblUnemployed;
        private Krypton.Toolkit.KryptonButton btnHiring;
        private Krypton.Toolkit.KryptonButton btnHome;
        private Krypton.Toolkit.KryptonButton btnProfile;
        private Krypton.Toolkit.KryptonPictureBox picExit;
        private Krypton.Toolkit.KryptonPictureBox picLogOut;
        private Krypton.Toolkit.KryptonPanel pnlContainer;
    }
}