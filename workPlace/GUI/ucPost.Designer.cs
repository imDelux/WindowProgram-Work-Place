namespace GUI
{
    partial class ucPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPost));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.picAddPost = new Krypton.Toolkit.KryptonPictureBox();
            this.ucJobCard1 = new GUI.ucJobCard();
            this.ucJobCard2 = new GUI.ucJobCard();
            this.ucJobCard3 = new GUI.ucJobCard();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPost)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucJobCard1);
            this.flowLayoutPanel1.Controls.Add(this.ucJobCard2);
            this.flowLayoutPanel1.Controls.Add(this.ucJobCard3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(912, 611);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "Your Posted Posts";
            // 
            // picAddPost
            // 
            this.picAddPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddPost.Image = ((System.Drawing.Image)(resources.GetObject("picAddPost.Image")));
            this.picAddPost.Location = new System.Drawing.Point(919, 20);
            this.picAddPost.Name = "picAddPost";
            this.picAddPost.Size = new System.Drawing.Size(55, 55);
            this.picAddPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddPost.TabIndex = 15;
            this.picAddPost.TabStop = false;
            this.picAddPost.Click += new System.EventHandler(this.picAddPost_Click);
            // 
            // ucJobCard1
            // 
            this.ucJobCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucJobCard1.Location = new System.Drawing.Point(0, 0);
            this.ucJobCard1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ucJobCard1.Name = "ucJobCard1";
            this.ucJobCard1.Size = new System.Drawing.Size(912, 163);
            this.ucJobCard1.TabIndex = 0;
            // 
            // ucJobCard2
            // 
            this.ucJobCard2.BackColor = System.Drawing.Color.Transparent;
            this.ucJobCard2.Location = new System.Drawing.Point(0, 166);
            this.ucJobCard2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ucJobCard2.Name = "ucJobCard2";
            this.ucJobCard2.Size = new System.Drawing.Size(912, 163);
            this.ucJobCard2.TabIndex = 1;
            // 
            // ucJobCard3
            // 
            this.ucJobCard3.BackColor = System.Drawing.Color.Transparent;
            this.ucJobCard3.Location = new System.Drawing.Point(0, 332);
            this.ucJobCard3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ucJobCard3.Name = "ucJobCard3";
            this.ucJobCard3.Size = new System.Drawing.Size(912, 163);
            this.ucJobCard3.TabIndex = 2;
            // 
            // ucPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.picAddPost);
            this.Name = "ucPost";
            this.Size = new System.Drawing.Size(1002, 749);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPictureBox picAddPost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private ucJobCard ucJobCard1;
        private ucJobCard ucJobCard2;
        private ucJobCard ucJobCard3;
    }
}
