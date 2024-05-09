namespace GUI
{
    partial class fReview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRateHeader = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.btnConfirm = new Krypton.Toolkit.KryptonButton();
            this.tlpnlPhoto = new System.Windows.Forms.TableLayoutPanel();
            this.picPhoto2 = new System.Windows.Forms.PictureBox();
            this.picPhoto3 = new System.Windows.Forms.PictureBox();
            this.picPhoto1 = new System.Windows.Forms.PictureBox();
            this.lblAddPhoto = new System.Windows.Forms.Label();
            this.tlpnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRateHeader
            // 
            this.lblRateHeader.AutoSize = true;
            this.lblRateHeader.ForeColor = System.Drawing.Color.Gray;
            this.lblRateHeader.Location = new System.Drawing.Point(32, 74);
            this.lblRateHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRateHeader.Name = "lblRateHeader";
            this.lblRateHeader.Size = new System.Drawing.Size(49, 21);
            this.lblRateHeader.TabIndex = 0;
            this.lblRateHeader.Text = "Score";
            // 
            // txtPoint
            // 
            this.txtPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPoint.Location = new System.Drawing.Point(102, 72);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(81, 29);
            this.txtPoint.TabIndex = 1;
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.ForeColor = System.Drawing.Color.Gray;
            this.lblMaxScore.Location = new System.Drawing.Point(186, 74);
            this.lblMaxScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(34, 21);
            this.lblMaxScore.TabIndex = 2;
            this.lblMaxScore.Text = "/10";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.ForeColor = System.Drawing.Color.Gray;
            this.lblC.Location = new System.Drawing.Point(32, 118);
            this.lblC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(132, 21);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "Leave a comment";
            // 
            // txtDescription
            // 
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(28, 153);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(322, 78);
            this.txtDescription.TabIndex = 4;
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThumbnail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblThumbnail.Location = new System.Drawing.Point(132, 7);
            this.lblThumbnail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(109, 37);
            this.lblThumbnail.TabIndex = 5;
            this.lblThumbnail.Text = "Review";
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirm.Location = new System.Drawing.Point(139, 385);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfirm.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnConfirm.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnConfirm.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.OverrideDefault.Border.Rounding = 10F;
            this.btnConfirm.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfirm.Size = new System.Drawing.Size(81, 35);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfirm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateCommon.Border.Rounding = 10F;
            this.btnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnConfirm.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnConfirm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Values.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tlpnlPhoto
            // 
            this.tlpnlPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tlpnlPhoto.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpnlPhoto.ColumnCount = 3;
            this.tlpnlPhoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlPhoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlPhoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlPhoto.Controls.Add(this.picPhoto2, 1, 0);
            this.tlpnlPhoto.Controls.Add(this.picPhoto3, 2, 0);
            this.tlpnlPhoto.Controls.Add(this.picPhoto1, 0, 0);
            this.tlpnlPhoto.Location = new System.Drawing.Point(28, 265);
            this.tlpnlPhoto.Name = "tlpnlPhoto";
            this.tlpnlPhoto.RowCount = 1;
            this.tlpnlPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlPhoto.Size = new System.Drawing.Size(322, 100);
            this.tlpnlPhoto.TabIndex = 9;
            // 
            // picPhoto2
            // 
            this.picPhoto2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhoto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhoto2.Image = global::GUI.Properties.Resources.add_photo__1_;
            this.picPhoto2.Location = new System.Drawing.Point(120, 20);
            this.picPhoto2.Name = "picPhoto2";
            this.picPhoto2.Size = new System.Drawing.Size(80, 60);
            this.picPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto2.TabIndex = 8;
            this.picPhoto2.TabStop = false;
            this.picPhoto2.Click += new System.EventHandler(this.picPhoto2_Click);
            // 
            // picPhoto3
            // 
            this.picPhoto3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhoto3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhoto3.Image = global::GUI.Properties.Resources.add_photo__1_;
            this.picPhoto3.Location = new System.Drawing.Point(227, 20);
            this.picPhoto3.Name = "picPhoto3";
            this.picPhoto3.Size = new System.Drawing.Size(80, 60);
            this.picPhoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto3.TabIndex = 8;
            this.picPhoto3.TabStop = false;
            this.picPhoto3.Click += new System.EventHandler(this.picPhoto3_Click);
            // 
            // picPhoto1
            // 
            this.picPhoto1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhoto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhoto1.Image = global::GUI.Properties.Resources.add_photo__1_;
            this.picPhoto1.Location = new System.Drawing.Point(14, 20);
            this.picPhoto1.Name = "picPhoto1";
            this.picPhoto1.Size = new System.Drawing.Size(80, 60);
            this.picPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto1.TabIndex = 8;
            this.picPhoto1.TabStop = false;
            this.picPhoto1.Click += new System.EventHandler(this.picPhoto1_Click);
            // 
            // lblAddPhoto
            // 
            this.lblAddPhoto.AutoSize = true;
            this.lblAddPhoto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPhoto.ForeColor = System.Drawing.Color.Gray;
            this.lblAddPhoto.Location = new System.Drawing.Point(117, 241);
            this.lblAddPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddPhoto.Name = "lblAddPhoto";
            this.lblAddPhoto.Size = new System.Drawing.Size(139, 21);
            this.lblAddPhoto.TabIndex = 3;
            this.lblAddPhoto.Text = "Add photos (0/3)";
            // 
            // fReview
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(372, 426);
            this.CloseBox = false;
            this.Controls.Add(this.tlpnlPhoto);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblThumbnail);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAddPhoto);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.lblRateHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fReview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 20F;
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.White;
            this.tlpnlPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRateHeader;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblThumbnail;
        private Krypton.Toolkit.KryptonButton btnConfirm;
        private System.Windows.Forms.PictureBox picPhoto1;
        private System.Windows.Forms.PictureBox picPhoto2;
        private System.Windows.Forms.TableLayoutPanel tlpnlPhoto;
        private System.Windows.Forms.PictureBox picPhoto3;
        private System.Windows.Forms.Label lblAddPhoto;
    }
}