namespace GUI
{
    partial class ucBasicInfo
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
            this.lblWokerName = new Krypton.Toolkit.KryptonLabel();
            this.lblRate = new Krypton.Toolkit.KryptonLabel();
            this.btnInfo = new Krypton.Toolkit.KryptonButton();
            this.lblBasicInfo = new System.Windows.Forms.Label();
            this.picAvt = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWokerName
            // 
            this.lblWokerName.AutoSize = false;
            this.lblWokerName.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblWokerName.Location = new System.Drawing.Point(294, 108);
            this.lblWokerName.Name = "lblWokerName";
            this.lblWokerName.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.lblWokerName.Size = new System.Drawing.Size(406, 25);
            this.lblWokerName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblWokerName.TabIndex = 2;
            this.lblWokerName.Values.Text = "Worker Name";
            // 
            // lblRate
            // 
            this.lblRate.Location = new System.Drawing.Point(294, 156);
            this.lblRate.Name = "lblRate";
            this.lblRate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.lblRate.Size = new System.Drawing.Size(153, 25);
            this.lblRate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRate.TabIndex = 4;
            this.lblRate.Values.Text = "Rate: xx.x/10.0 (xx)";
            // 
            // btnInfo
            // 
            this.btnInfo.Enabled = false;
            this.btnInfo.Location = new System.Drawing.Point(50, 286);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnInfo.Size = new System.Drawing.Size(680, 292);
            this.btnInfo.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnInfo.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnInfo.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnInfo.StateCommon.Border.Rounding = 10F;
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Values.Text = "";
            // 
            // lblBasicInfo
            // 
            this.lblBasicInfo.AutoSize = true;
            this.lblBasicInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblBasicInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBasicInfo.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.lblBasicInfo.Location = new System.Drawing.Point(104, 254);
            this.lblBasicInfo.Name = "lblBasicInfo";
            this.lblBasicInfo.Size = new System.Drawing.Size(462, 55);
            this.lblBasicInfo.TabIndex = 7;
            this.lblBasicInfo.Text = "Basic Information";
            // 
            // picAvt
            // 
            this.picAvt.Image = global::GUI.Properties.Resources._4043260_avatar_male_man_portrait_icon__2_;
            this.picAvt.Location = new System.Drawing.Point(70, 70);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(170, 170);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvt.TabIndex = 1;
            this.picAvt.TabStop = false;
            // 
            // ucBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.lblBasicInfo);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblWokerName);
            this.Controls.Add(this.picAvt);
            this.Name = "ucBasicInfo";
            this.Size = new System.Drawing.Size(780, 597);
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox picAvt;
        private Krypton.Toolkit.KryptonLabel lblWokerName;
        private Krypton.Toolkit.KryptonLabel lblRate;
        private Krypton.Toolkit.KryptonButton btnInfo;
        private System.Windows.Forms.Label lblBasicInfo;
    }
}
