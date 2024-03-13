namespace GUI
{
    partial class usDay
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
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton1.Enabled = false;
            this.kryptonButton1.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(111, 75);
            this.kryptonButton1.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonButton1.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonButton1.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateDisabled.Border.Rounding = 5F;
            this.kryptonButton1.StateDisabled.Border.Width = 1;
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.White;
            this.lblDay.Font = new System.Drawing.Font("Verdana Ref", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Black;
            this.lblDay.Location = new System.Drawing.Point(7, 7);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(38, 27);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "00";
            // 
            // usDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.kryptonButton1);
            this.Name = "usDay";
            this.Size = new System.Drawing.Size(111, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label lblDay;
    }
}
