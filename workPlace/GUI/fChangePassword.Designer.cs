namespace GUI
{
    partial class fChangePassword
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
            this.txtOldPassword = new Krypton.Toolkit.KryptonTextBox();
            this.lblOldPasswordHeader = new System.Windows.Forms.Label();
            this.btnConfirm = new Krypton.Toolkit.KryptonButton();
            this.txtNewPassword = new Krypton.Toolkit.KryptonTextBox();
            this.lblNewPasswordHeader = new System.Windows.Forms.Label();
            this.txtRewriteNewPassword = new Krypton.Toolkit.KryptonTextBox();
            this.lblRewriteNewPasswordHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(40, 60);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '●';
            this.txtOldPassword.Size = new System.Drawing.Size(385, 43);
            this.txtOldPassword.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtOldPassword.StateActive.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtOldPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtOldPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtOldPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOldPassword.StateCommon.Border.Rounding = 10F;
            this.txtOldPassword.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtOldPassword.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtOldPassword.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtOldPassword.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOldPassword.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.txtOldPassword.StateDisabled.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtOldPassword.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtOldPassword.StateNormal.Content.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtOldPassword.TabIndex = 50;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblOldPasswordHeader
            // 
            this.lblOldPasswordHeader.AutoSize = true;
            this.lblOldPasswordHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPasswordHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblOldPasswordHeader.Location = new System.Drawing.Point(66, 29);
            this.lblOldPasswordHeader.Name = "lblOldPasswordHeader";
            this.lblOldPasswordHeader.Size = new System.Drawing.Size(130, 28);
            this.lblOldPasswordHeader.TabIndex = 49;
            this.lblOldPasswordHeader.Text = "Old Password";
            // 
            // btnConfirm
            // 
            this.btnConfirm.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.btnConfirm.Location = new System.Drawing.Point(183, 312);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumPurple;
            this.btnConfirm.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.Size = new System.Drawing.Size(107, 39);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnConfirm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateNormal.Border.Rounding = 10F;
            this.btnConfirm.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnConfirm.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StatePressed.Border.Rounding = 15F;
            this.btnConfirm.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnConfirm.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateTracking.Border.Rounding = 15F;
            this.btnConfirm.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.TabIndex = 56;
            this.btnConfirm.Values.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(40, 147);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(385, 43);
            this.txtNewPassword.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtNewPassword.StateActive.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtNewPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNewPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNewPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.StateCommon.Border.Rounding = 10F;
            this.txtNewPassword.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtNewPassword.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNewPassword.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtNewPassword.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.txtNewPassword.StateDisabled.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtNewPassword.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtNewPassword.StateNormal.Content.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtNewPassword.TabIndex = 52;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPasswordHeader
            // 
            this.lblNewPasswordHeader.AutoSize = true;
            this.lblNewPasswordHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblNewPasswordHeader.Location = new System.Drawing.Point(66, 116);
            this.lblNewPasswordHeader.Name = "lblNewPasswordHeader";
            this.lblNewPasswordHeader.Size = new System.Drawing.Size(137, 28);
            this.lblNewPasswordHeader.TabIndex = 51;
            this.lblNewPasswordHeader.Text = "New Password";
            // 
            // txtRewriteNewPassword
            // 
            this.txtRewriteNewPassword.Location = new System.Drawing.Point(40, 242);
            this.txtRewriteNewPassword.Name = "txtRewriteNewPassword";
            this.txtRewriteNewPassword.PasswordChar = '●';
            this.txtRewriteNewPassword.Size = new System.Drawing.Size(385, 43);
            this.txtRewriteNewPassword.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtRewriteNewPassword.StateActive.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRewriteNewPassword.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtRewriteNewPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtRewriteNewPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtRewriteNewPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRewriteNewPassword.StateCommon.Border.Rounding = 10F;
            this.txtRewriteNewPassword.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtRewriteNewPassword.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtRewriteNewPassword.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtRewriteNewPassword.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRewriteNewPassword.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.txtRewriteNewPassword.StateDisabled.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRewriteNewPassword.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtRewriteNewPassword.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtRewriteNewPassword.StateNormal.Content.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRewriteNewPassword.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtRewriteNewPassword.TabIndex = 54;
            this.txtRewriteNewPassword.UseSystemPasswordChar = true;
            // 
            // lblRewriteNewPasswordHeader
            // 
            this.lblRewriteNewPasswordHeader.AutoSize = true;
            this.lblRewriteNewPasswordHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewriteNewPasswordHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblRewriteNewPasswordHeader.Location = new System.Drawing.Point(66, 211);
            this.lblRewriteNewPasswordHeader.Name = "lblRewriteNewPasswordHeader";
            this.lblRewriteNewPasswordHeader.Size = new System.Drawing.Size(202, 28);
            this.lblRewriteNewPasswordHeader.TabIndex = 53;
            this.lblRewriteNewPasswordHeader.Text = "Rewrite new Password";
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(470, 383);
            this.Controls.Add(this.txtRewriteNewPassword);
            this.Controls.Add(this.lblRewriteNewPasswordHeader);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPasswordHeader);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblOldPasswordHeader);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 10F;
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPasswordHeader;
        private Krypton.Toolkit.KryptonButton btnConfirm;
        private Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPasswordHeader;
        private Krypton.Toolkit.KryptonTextBox txtRewriteNewPassword;
        private System.Windows.Forms.Label lblRewriteNewPasswordHeader;
    }
}