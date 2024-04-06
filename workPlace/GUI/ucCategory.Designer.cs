namespace GUI
{
    partial class ucCategory
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
            this.lblCat = new System.Windows.Forms.Label();
            this.lblNumWorker = new System.Windows.Forms.Label();
            this.lblNumSkills = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(20, 20);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(115, 32);
            this.lblCat.TabIndex = 0;
            this.lblCat.Text = "Cat #1";
            // 
            // lblNumWorker
            // 
            this.lblNumWorker.AutoSize = true;
            this.lblNumWorker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumWorker.Location = new System.Drawing.Point(3, 117);
            this.lblNumWorker.Name = "lblNumWorker";
            this.lblNumWorker.Size = new System.Drawing.Size(120, 21);
            this.lblNumWorker.TabIndex = 0;
            this.lblNumWorker.Text = "#numb workers";
            // 
            // lblNumSkills
            // 
            this.lblNumSkills.AutoSize = true;
            this.lblNumSkills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSkills.Location = new System.Drawing.Point(181, 117);
            this.lblNumSkills.Name = "lblNumSkills";
            this.lblNumSkills.Size = new System.Drawing.Size(98, 21);
            this.lblNumSkills.TabIndex = 0;
            this.lblNumSkills.Text = "#numb skills";
            // 
            // ucCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumSkills);
            this.Controls.Add(this.lblNumWorker);
            this.Controls.Add(this.lblCat);
            this.Name = "ucCategory";
            this.Size = new System.Drawing.Size(282, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblNumWorker;
        private System.Windows.Forms.Label lblNumSkills;
    }
}
