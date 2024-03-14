namespace GUI
{
    partial class ucEvaluate
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
            this.txtComment = new Krypton.Toolkit.KryptonTextBox();
            this.btnDetails = new Krypton.Toolkit.KryptonButton();
            this.picAvt = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWokerName
            // 
            this.lblWokerName.AutoSize = false;
            this.lblWokerName.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblWokerName.Location = new System.Drawing.Point(115, 22);
            this.lblWokerName.Name = "lblWokerName";
            this.lblWokerName.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.lblWokerName.Size = new System.Drawing.Size(258, 25);
            this.lblWokerName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWokerName.TabIndex = 2;
            this.lblWokerName.Values.Text = "Worker Name";
            // 
            // lblRate
            // 
            this.lblRate.Location = new System.Drawing.Point(115, 53);
            this.lblRate.Name = "lblRate";
            this.lblRate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.lblRate.Size = new System.Drawing.Size(102, 21);
            this.lblRate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRate.TabIndex = 3;
            this.lblRate.Values.Text = "Rate: xx.x/10.0";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(32, 102);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txtComment.Size = new System.Drawing.Size(350, 90);
            this.txtComment.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtComment.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtComment.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtComment.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtComment.StateCommon.Border.Rounding = 20F;
            this.txtComment.TabIndex = 4;
            this.txtComment.Text = "Run.";
            // 
            // btnDetails
            // 
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.Location = new System.Drawing.Point(283, 57);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDetails.Size = new System.Drawing.Size(90, 25);
            this.btnDetails.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnDetails.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnDetails.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnDetails.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnDetails.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDetails.StateCommon.Border.Rounding = 2F;
            this.btnDetails.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDetails.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDetails.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Values.Text = "Detail";
            // 
            // picAvt
            // 
            this.picAvt.Image = global::GUI.Properties.Resources._4043260_avatar_male_man_portrait_icon__2_;
            this.picAvt.Location = new System.Drawing.Point(32, 22);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(60, 60);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvt.TabIndex = 1;
            this.picAvt.TabStop = false;
            // 
            // ucEvaluate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblWokerName);
            this.Controls.Add(this.picAvt);
            this.Name = "ucEvaluate";
            this.Size = new System.Drawing.Size(414, 212);
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox picAvt;
        private Krypton.Toolkit.KryptonLabel lblWokerName;
        private Krypton.Toolkit.KryptonLabel lblRate;
        private Krypton.Toolkit.KryptonTextBox txtComment;
        private Krypton.Toolkit.KryptonButton btnDetails;
    }
}
