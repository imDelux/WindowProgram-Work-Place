namespace GUI
{
    partial class ucDoneJob
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
            this.ptbState = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.lblJobdes = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbState
            // 
            this.ptbState.BackColor = System.Drawing.Color.White;
            this.ptbState.Image = global::GUI.Properties.Resources.rec__1_;
            this.ptbState.Location = new System.Drawing.Point(412, 20);
            this.ptbState.Name = "ptbState";
            this.ptbState.Size = new System.Drawing.Size(36, 35);
            this.ptbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbState.TabIndex = 28;
            this.ptbState.TabStop = false;
            this.ptbState.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(127, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 34);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Gabiel Erickson";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAge
            // 
            this.lblAge.AutoEllipsis = true;
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.White;
            this.lblAge.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(129, 74);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(60, 16);
            this.lblAge.TabIndex = 43;
            this.lblAge.Text = "Age : 25";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoEllipsis = true;
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(129, 105);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(149, 36);
            this.lblLocation.TabIndex = 44;
            this.lblLocation.Text = "Location: Ho Chi Minh City";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::GUI.Properties.Resources.man_icon;
            this.picAvatar.Location = new System.Drawing.Point(50, 37);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(71, 82);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 41;
            this.picAvatar.TabStop = false;
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoEllipsis = true;
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.BackColor = System.Drawing.Color.White;
            this.lblJobDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDate.Location = new System.Drawing.Point(306, 74);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(67, 16);
            this.lblJobDate.TabIndex = 39;
            this.lblJobDate.Text = "Job date";
            // 
            // lblJobdes
            // 
            this.lblJobdes.AutoEllipsis = true;
            this.lblJobdes.BackColor = System.Drawing.Color.White;
            this.lblJobdes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobdes.Location = new System.Drawing.Point(306, 105);
            this.lblJobdes.Name = "lblJobdes";
            this.lblJobdes.Size = new System.Drawing.Size(126, 36);
            this.lblJobdes.TabIndex = 40;
            this.lblJobdes.Text = "Job description goes  here";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoEllipsis = true;
            this.lblJobName.BackColor = System.Drawing.Color.White;
            this.lblJobName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJobName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(304, 20);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(128, 53);
            this.lblJobName.TabIndex = 38;
            this.lblJobName.Text = "Job name";
            this.lblJobName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(270, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(27, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBack.Size = new System.Drawing.Size(445, 144);
            this.btnBack.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.Rounding = 20F;
            this.btnBack.StateCommon.Border.Width = 2;
            this.btnBack.TabIndex = 45;
            this.btnBack.Values.Text = "";
            // 
            // ucDoneJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ptbState);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.lblJobdes);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBack);
            this.Name = "ucDoneJob";
            this.Size = new System.Drawing.Size(485, 162);
            this.Load += new System.EventHandler(this.ucDoneJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbState;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Label lblJobdes;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonButton btnBack;
    }
}
