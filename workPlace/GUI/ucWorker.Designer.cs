namespace GUI
{
    partial class ucWorker
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblAvgWage = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoEllipsis = true;
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(148, 119);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(275, 22);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location: Ho Chi Minh City";
            // 
            // lblAge
            // 
            this.lblAge.AutoEllipsis = true;
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.White;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(148, 96);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(67, 23);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age: 20";
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBack.Size = new System.Drawing.Size(448, 183);
            this.btnBack.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnBack.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.Rounding = 20F;
            this.btnBack.StateCommon.Border.Width = 2;
            this.btnBack.TabIndex = 5;
            this.btnBack.Values.Text = "";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(245)))), ((int)(((byte)(143)))));
            this.lblRating.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.White;
            this.lblRating.Location = new System.Drawing.Point(148, 64);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(91, 23);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "8.0/10.0";
            // 
            // lblAvgWage
            // 
            this.lblAvgWage.AutoSize = true;
            this.lblAvgWage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(116)))), ((int)(((byte)(170)))));
            this.lblAvgWage.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgWage.ForeColor = System.Drawing.Color.White;
            this.lblAvgWage.Location = new System.Drawing.Point(245, 64);
            this.lblAvgWage.Name = "lblAvgWage";
            this.lblAvgWage.Size = new System.Drawing.Size(58, 23);
            this.lblAvgWage.TabIndex = 8;
            this.lblAvgWage.Text = "150$";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::GUI.Properties.Resources.man_icon;
            this.picAvatar.Location = new System.Drawing.Point(35, 64);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(90, 90);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 6;
            this.picAvatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tho sua dien tu lanh, may giat";
            // 
            // ucWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvgWage);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnBack);
            this.Name = "ucWorker";
            this.Size = new System.Drawing.Size(448, 186);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAge;
        private Krypton.Toolkit.KryptonButton btnBack;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblAvgWage;
        private System.Windows.Forms.Label label1;
    }
}
