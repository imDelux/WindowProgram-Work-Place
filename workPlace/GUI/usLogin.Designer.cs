namespace GUI
{
    partial class usLogin
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
            this.cbRememberPass = new Krypton.Toolkit.KryptonCheckBox();
            this.lblContext = new System.Windows.Forms.Label();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.btnForgotpass = new Krypton.Toolkit.KryptonButton();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRememberPass
            // 
            this.cbRememberPass.Images.CheckedNormal = global::GUI.Properties.Resources.checkbox__1_;
            this.cbRememberPass.Images.CheckedPressed = global::GUI.Properties.Resources.checkbox__1_;
            this.cbRememberPass.Images.CheckedTracking = global::GUI.Properties.Resources.checkbox__1_;
            this.cbRememberPass.Images.UncheckedNormal = global::GUI.Properties.Resources.checkbox;
            this.cbRememberPass.Images.UncheckedPressed = global::GUI.Properties.Resources.checkbox;
            this.cbRememberPass.Images.UncheckedTracking = global::GUI.Properties.Resources.checkbox__1_;
            this.cbRememberPass.Location = new System.Drawing.Point(113, 281);
            this.cbRememberPass.Name = "cbRememberPass";
            this.cbRememberPass.Size = new System.Drawing.Size(183, 22);
            this.cbRememberPass.StateCommon.AdjacentGap = 0;
            this.cbRememberPass.StateCommon.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbRememberPass.StateCommon.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbRememberPass.StateCommon.ShortText.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.cbRememberPass.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRememberPass.TabIndex = 30;
            this.cbRememberPass.Values.Text = "Remember for 30 days";
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.BackColor = System.Drawing.Color.White;
            this.lblContext.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContext.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblContext.Location = new System.Drawing.Point(162, 93);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(241, 18);
            this.lblContext.TabIndex = 29;
            this.lblContext.Text = "Welcome back! Please enter your detail";
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.BackColor = System.Drawing.Color.White;
            this.lblThumbnail.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThumbnail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblThumbnail.Location = new System.Drawing.Point(231, 49);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(105, 34);
            this.lblThumbnail.TabIndex = 28;
            this.lblThumbnail.Text = "Sign In";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 45);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.txtEmail.StateCommon.Border.Color2 = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 20F;
            this.txtEmail.StateCommon.Border.Width = 2;
            this.txtEmail.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 4, 10, 4);
            this.txtEmail.StateNormal.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.txtEmail.TabIndex = 24;
            this.txtEmail.Text = "Enter your email";
            // 
            // btnForgotpass
            // 
            this.btnForgotpass.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.btnForgotpass.Location = new System.Drawing.Point(328, 278);
            this.btnForgotpass.Name = "btnForgotpass";
            this.btnForgotpass.Size = new System.Drawing.Size(172, 25);
            this.btnForgotpass.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btnForgotpass.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotpass.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnForgotpass.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnForgotpass.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(192)))));
            this.btnForgotpass.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotpass.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnForgotpass.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnForgotpass.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(192)))));
            this.btnForgotpass.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotpass.TabIndex = 27;
            this.btnForgotpass.Values.Text = "Forgot password ?";
            this.btnForgotpass.Click += new System.EventHandler(this.btnForgotpass_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(301, 44);
            this.txtPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 20F;
            this.txtPassword.StateCommon.Border.Width = 2;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 5, 10, 5);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.Text = "password";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnNext
            // 
            this.btnNext.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.btnNext.Location = new System.Drawing.Point(227, 327);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 100);
            this.btnNext.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.btnNext.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnNext.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnNext.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnNext.StateNormal.Back.Image = global::GUI.Properties.Resources.right_arrow;
            this.btnNext.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnNext.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNext.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateNormal.Border.Rounding = 30F;
            this.btnNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNext.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(192)))));
            this.btnNext.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnNext.StatePressed.Back.Image = global::GUI.Properties.Resources.right_arrow;
            this.btnNext.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNext.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StatePressed.Border.Rounding = 30F;
            this.btnNext.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNext.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNext.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(192)))));
            this.btnNext.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateTracking.Back.Image = global::GUI.Properties.Resources.right_arrow;
            this.btnNext.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNext.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateTracking.Border.Rounding = 30F;
            this.btnNext.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNext.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.TabIndex = 26;
            this.btnNext.Values.Text = "";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(292, 433);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.minus;
            this.pictureBox1.Location = new System.Drawing.Point(99, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // usLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbRememberPass);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.lblThumbnail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnForgotpass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnNext);
            this.Name = "usLogin";
            this.Size = new System.Drawing.Size(523, 495);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonCheckBox cbRememberPass;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.Label lblThumbnail;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonButton btnForgotpass;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonButton btnNext;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
