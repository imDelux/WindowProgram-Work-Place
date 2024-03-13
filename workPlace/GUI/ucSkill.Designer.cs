namespace GUI
{
    partial class ucSkill
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
            this.btnSkillNameContainer = new Krypton.Toolkit.KryptonButton();
            this.lblSkillRate = new System.Windows.Forms.Label();
            this.btnSkillDescribeContainer = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnSkillNameContainer
            // 
            this.btnSkillNameContainer.Enabled = false;
            this.btnSkillNameContainer.Location = new System.Drawing.Point(16, 18);
            this.btnSkillNameContainer.Name = "btnSkillNameContainer";
            this.btnSkillNameContainer.Size = new System.Drawing.Size(250, 50);
            this.btnSkillNameContainer.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(225)))));
            this.btnSkillNameContainer.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(225)))));
            this.btnSkillNameContainer.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSkillNameContainer.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSkillNameContainer.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSkillNameContainer.StateDisabled.Border.Rounding = 20F;
            this.btnSkillNameContainer.StateDisabled.Border.Width = 1;
            this.btnSkillNameContainer.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSkillNameContainer.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSkillNameContainer.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkillNameContainer.TabIndex = 0;
            this.btnSkillNameContainer.Values.Text = "Skill name goes there";
            // 
            // lblSkillRate
            // 
            this.lblSkillRate.AutoSize = true;
            this.lblSkillRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillRate.Location = new System.Drawing.Point(289, 30);
            this.lblSkillRate.Name = "lblSkillRate";
            this.lblSkillRate.Size = new System.Drawing.Size(84, 23);
            this.lblSkillRate.TabIndex = 2;
            this.lblSkillRate.Text = "0.0/10.0";
            // 
            // btnSkillDescribeContainer
            // 
            this.btnSkillDescribeContainer.Enabled = false;
            this.btnSkillDescribeContainer.Location = new System.Drawing.Point(16, 86);
            this.btnSkillDescribeContainer.Name = "btnSkillDescribeContainer";
            this.btnSkillDescribeContainer.Size = new System.Drawing.Size(578, 102);
            this.btnSkillDescribeContainer.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSkillDescribeContainer.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSkillDescribeContainer.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSkillDescribeContainer.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSkillDescribeContainer.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSkillDescribeContainer.StateDisabled.Border.Rounding = 10F;
            this.btnSkillDescribeContainer.StateDisabled.Border.Width = 1;
            this.btnSkillDescribeContainer.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSkillDescribeContainer.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSkillDescribeContainer.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkillDescribeContainer.TabIndex = 3;
            this.btnSkillDescribeContainer.Values.Text = "";
            // 
            // ucSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnSkillDescribeContainer);
            this.Controls.Add(this.lblSkillRate);
            this.Controls.Add(this.btnSkillNameContainer);
            this.Name = "ucSkill";
            this.Size = new System.Drawing.Size(610, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnSkillNameContainer;
        private System.Windows.Forms.Label lblSkillRate;
        private Krypton.Toolkit.KryptonButton btnSkillDescribeContainer;
    }
}
