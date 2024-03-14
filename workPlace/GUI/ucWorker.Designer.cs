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
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.picAvt = new Krypton.Toolkit.KryptonPictureBox();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWokerName
            // 
            this.lblWokerName.AutoEllipsis = true;
            this.lblWokerName.BackColor = System.Drawing.Color.White;
            this.lblWokerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWokerName.Location = new System.Drawing.Point(137, 28);
            this.lblWokerName.Name = "lblWokerName";
            this.lblWokerName.Size = new System.Drawing.Size(291, 23);
            this.lblWokerName.TabIndex = 3;
            this.lblWokerName.Text = "Worker Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoEllipsis = true;
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(138, 98);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(290, 17);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Place: United State";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoEllipsis = true;
            this.lblSkill.BackColor = System.Drawing.Color.White;
            this.lblSkill.Location = new System.Drawing.Point(17, 137);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(411, 66);
            this.lblSkill.TabIndex = 4;
            this.lblSkill.Text = "Skill: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoEllipsis = true;
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(138, 70);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age: xx";
            // 
            // picAvt
            // 
            this.picAvt.Image = global::GUI.Properties.Resources._4043260_avatar_male_man_portrait_icon__2_;
            this.picAvt.Location = new System.Drawing.Point(20, 20);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(98, 98);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvt.TabIndex = 0;
            this.picAvt.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBack.Size = new System.Drawing.Size(448, 222);
            this.btnBack.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.Rounding = 20F;
            this.btnBack.TabIndex = 5;
            this.btnBack.Values.Text = "";
            this.btnBack.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ucWorker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblSkill);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblWokerName);
            this.Controls.Add(this.picAvt);
            this.Controls.Add(this.btnBack);
            this.Name = "ucWorker";
            this.Size = new System.Drawing.Size(451, 228);
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox picAvt;
        private System.Windows.Forms.Label lblWokerName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblAge;
        private Krypton.Toolkit.KryptonButton btnBack;
    }
}
