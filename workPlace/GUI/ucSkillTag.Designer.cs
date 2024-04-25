namespace GUI
{
    partial class ucSkillTag
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
            this.btnContainer = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.AutoSize = true;
            this.btnContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContainer.Enabled = false;
            this.btnContainer.Location = new System.Drawing.Point(0, 0);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(0);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(60, 39);
            this.btnContainer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnContainer.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnContainer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContainer.StateCommon.Border.Rounding = 20F;
            this.btnContainer.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnContainer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnContainer.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnContainer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContainer.TabIndex = 0;
            this.btnContainer.Values.Text = "Skill i";
            // 
            // ucSkillTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnContainer);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Name = "ucSkillTag";
            this.Size = new System.Drawing.Size(60, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnContainer;
    }
}
