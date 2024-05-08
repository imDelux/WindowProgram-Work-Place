namespace GUI
{
    partial class ucFindJob
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
            this.fpnlPostContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSkillFieldHeader = new System.Windows.Forms.Label();
            this.cbbSkillField = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSkillField)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnlPostContainer
            // 
            this.fpnlPostContainer.Location = new System.Drawing.Point(45, 109);
            this.fpnlPostContainer.Name = "fpnlPostContainer";
            this.fpnlPostContainer.Size = new System.Drawing.Size(913, 600);
            this.fpnlPostContainer.TabIndex = 2;
            // 
            // lblSkillFieldHeader
            // 
            this.lblSkillFieldHeader.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillFieldHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblSkillFieldHeader.Location = new System.Drawing.Point(47, 25);
            this.lblSkillFieldHeader.Name = "lblSkillFieldHeader";
            this.lblSkillFieldHeader.Size = new System.Drawing.Size(590, 60);
            this.lblSkillFieldHeader.TabIndex = 18;
            this.lblSkillFieldHeader.Text = "--Skill Field--";
            this.lblSkillFieldHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSkillField
            // 
            this.cbbSkillField.DropDownWidth = 316;
            this.cbbSkillField.IntegralHeight = false;
            this.cbbSkillField.Location = new System.Drawing.Point(671, 43);
            this.cbbSkillField.Name = "cbbSkillField";
            this.cbbSkillField.Size = new System.Drawing.Size(270, 31);
            this.cbbSkillField.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cbbSkillField.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbSkillField.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cbbSkillField.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DarkGray;
            this.cbbSkillField.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F);
            this.cbbSkillField.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbSkillField.TabIndex = 63;
            this.cbbSkillField.Text = "Skill fields";
            // 
            // ucFindJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.cbbSkillField);
            this.Controls.Add(this.lblSkillFieldHeader);
            this.Controls.Add(this.fpnlPostContainer);
            this.Name = "ucFindJob";
            this.Size = new System.Drawing.Size(995, 766);
            ((System.ComponentModel.ISupportInitialize)(this.cbbSkillField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fpnlPostContainer;
        private System.Windows.Forms.Label lblSkillFieldHeader;
        private Krypton.Toolkit.KryptonComboBox cbbSkillField;
    }
}
