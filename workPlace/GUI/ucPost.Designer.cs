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
            this.fpnlPostContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoPostNotification = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picAddPost = new Krypton.Toolkit.KryptonPictureBox();
            this.fpnlPostContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddPost)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnlPostContainer
            // 
            this.fpnlPostContainer.AutoScroll = true;
            this.fpnlPostContainer.Controls.Add(this.lblNoPostNotification);
            this.fpnlPostContainer.Location = new System.Drawing.Point(35, 101);
            this.fpnlPostContainer.Name = "fpnlPostContainer";
            this.fpnlPostContainer.Size = new System.Drawing.Size(939, 611);
            this.fpnlPostContainer.TabIndex = 16;
            // 
            // lblNoPostNotification
            // 
            this.lblNoPostNotification.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPostNotification.ForeColor = System.Drawing.Color.Gray;
            this.lblNoPostNotification.Location = new System.Drawing.Point(3, 0);
            this.lblNoPostNotification.Name = "lblNoPostNotification";
            this.lblNoPostNotification.Size = new System.Drawing.Size(896, 571);
            this.lblNoPostNotification.TabIndex = 2;
            this.lblNoPostNotification.Text = "No post posted.\r\nGo create new one.\r\n";
            this.lblNoPostNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblHeader.Location = new System.Drawing.Point(37, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(417, 49);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Your Posted Posts";
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
            // ucPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.fpnlPostContainer);
            this.Controls.Add(this.picAddPost);
            this.Name = "ucPost";
            this.Size = new System.Drawing.Size(1002, 749);
            this.fpnlPostContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPictureBox picAddPost;
        private System.Windows.Forms.FlowLayoutPanel fpnlPostContainer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblNoPostNotification;
    }
}
