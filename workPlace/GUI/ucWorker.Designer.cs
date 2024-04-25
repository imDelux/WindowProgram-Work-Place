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
            this.lblWokerName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblAvgWage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.ucSkillTag1 = new GUI.ucSkillTag();
            this.ucSkillTag2 = new GUI.ucSkillTag();
            this.ucSkillTag3 = new GUI.ucSkillTag();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWokerName
            // 
            this.lblWokerName.AutoEllipsis = true;
            this.lblWokerName.BackColor = System.Drawing.Color.White;
            this.lblWokerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWokerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWokerName.Location = new System.Drawing.Point(137, 41);
            this.lblWokerName.Name = "lblWokerName";
            this.lblWokerName.Size = new System.Drawing.Size(277, 29);
            this.lblWokerName.TabIndex = 3;
            this.lblWokerName.Text = "Bien Xuan Huy";
            this.lblWokerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWokerName.Click += new System.EventHandler(this.lblWokerName_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoEllipsis = true;
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(137, 94);
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
            this.lblAge.Location = new System.Drawing.Point(137, 70);
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
            this.lblRating.Location = new System.Drawing.Point(273, 10);
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
            this.lblAvgWage.Location = new System.Drawing.Point(373, 10);
            this.lblAvgWage.Name = "lblAvgWage";
            this.lblAvgWage.Size = new System.Drawing.Size(58, 23);
            this.lblAvgWage.TabIndex = 8;
            this.lblAvgWage.Text = "150$";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.ucSkillTag1);
            this.flowLayoutPanel1.Controls.Add(this.ucSkillTag2);
            this.flowLayoutPanel1.Controls.Add(this.ucSkillTag3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(375, 44);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::GUI.Properties.Resources.man_icon;
            this.picAvatar.Location = new System.Drawing.Point(41, 30);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(90, 90);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 6;
            this.picAvatar.TabStop = false;
            // 
            // ucSkillTag1
            // 
            this.ucSkillTag1.AutoSize = true;
            this.ucSkillTag1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucSkillTag1.Location = new System.Drawing.Point(0, 0);
            this.ucSkillTag1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ucSkillTag1.Name = "ucSkillTag1";
            this.ucSkillTag1.Size = new System.Drawing.Size(60, 39);
            this.ucSkillTag1.TabIndex = 0;
            // 
            // ucSkillTag2
            // 
            this.ucSkillTag2.AutoSize = true;
            this.ucSkillTag2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucSkillTag2.Location = new System.Drawing.Point(63, 0);
            this.ucSkillTag2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ucSkillTag2.Name = "ucSkillTag2";
            this.ucSkillTag2.Size = new System.Drawing.Size(60, 39);
            this.ucSkillTag2.TabIndex = 1;
            // 
            // ucSkillTag3
            // 
            this.ucSkillTag3.AutoSize = true;
            this.ucSkillTag3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucSkillTag3.Location = new System.Drawing.Point(126, 0);
            this.ucSkillTag3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ucSkillTag3.Name = "ucSkillTag3";
            this.ucSkillTag3.Size = new System.Drawing.Size(60, 39);
            this.ucSkillTag3.TabIndex = 2;
            // 
            // ucWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblAvgWage);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblWokerName);
            this.Controls.Add(this.btnBack);
            this.Name = "ucWorker";
            this.Size = new System.Drawing.Size(448, 186);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWokerName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAge;
        private Krypton.Toolkit.KryptonButton btnBack;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblAvgWage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ucSkillTag ucSkillTag1;
        private ucSkillTag ucSkillTag2;
        private ucSkillTag ucSkillTag3;
    }
}
