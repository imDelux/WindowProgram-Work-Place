namespace GUI
{
    partial class usSignUp
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
            this.lblContext = new System.Windows.Forms.Label();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.txtPhonenum = new Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.txtRewritepass = new Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.BackColor = System.Drawing.Color.White;
            this.lblContext.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContext.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblContext.Location = new System.Drawing.Point(211, 55);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(148, 18);
            this.lblContext.TabIndex = 41;
            this.lblContext.Text = "Please enter your detail";
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.BackColor = System.Drawing.Color.White;
            this.lblThumbnail.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThumbnail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblThumbnail.Location = new System.Drawing.Point(238, 11);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(116, 34);
            this.lblThumbnail.TabIndex = 40;
            this.lblThumbnail.Text = "Sign Up";
            // 
            // btnNext
            // 
            this.btnNext.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.btnNext.Location = new System.Drawing.Point(244, 399);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 80);
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
            this.btnNext.TabIndex = 41;
            this.btnNext.Values.Text = "";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPhonenum
            // 
            this.txtPhonenum.Location = new System.Drawing.Point(139, 183);
            this.txtPhonenum.Name = "txtPhonenum";
            this.txtPhonenum.Size = new System.Drawing.Size(301, 45);
            this.txtPhonenum.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPhonenum.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.txtPhonenum.StateCommon.Border.Color2 = System.Drawing.SystemColors.HighlightText;
            this.txtPhonenum.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhonenum.StateCommon.Border.Rounding = 20F;
            this.txtPhonenum.StateCommon.Border.Width = 2;
            this.txtPhonenum.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPhonenum.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonenum.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 4, 10, 4);
            this.txtPhonenum.StateNormal.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.txtPhonenum.TabIndex = 38;
            this.txtPhonenum.Text = "Phonenumber";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 114);
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
            this.txtEmail.TabIndex = 37;
            this.txtEmail.Text = "Email";
            // 
            // txtRewritepass
            // 
            this.txtRewritepass.Location = new System.Drawing.Point(139, 325);
            this.txtRewritepass.Name = "txtRewritepass";
            this.txtRewritepass.Size = new System.Drawing.Size(301, 45);
            this.txtRewritepass.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtRewritepass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.txtRewritepass.StateCommon.Border.Color2 = System.Drawing.SystemColors.HighlightText;
            this.txtRewritepass.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRewritepass.StateCommon.Border.Rounding = 20F;
            this.txtRewritepass.StateCommon.Border.Width = 2;
            this.txtRewritepass.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtRewritepass.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRewritepass.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 4, 10, 4);
            this.txtRewritepass.StateNormal.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.txtRewritepass.TabIndex = 40;
            this.txtRewritepass.Text = "Rewrite password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 254);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(301, 45);
            this.txtPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.txtPassword.StateCommon.Border.Color2 = System.Drawing.SystemColors.HighlightText;
            this.txtPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 20F;
            this.txtPassword.StateCommon.Border.Width = 2;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 4, 10, 4);
            this.txtPassword.StateNormal.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.txtPassword.TabIndex = 39;
            this.txtPassword.Text = "Password";
            // 
            // usSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.lblThumbnail);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPhonenum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRewritepass);
            this.Controls.Add(this.txtPassword);
            this.Name = "usSignUp";
            this.Size = new System.Drawing.Size(496, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.Label lblThumbnail;
        private Krypton.Toolkit.KryptonButton btnNext;
        private Krypton.Toolkit.KryptonTextBox txtPhonenum;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonTextBox txtRewritepass;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
    }
}
