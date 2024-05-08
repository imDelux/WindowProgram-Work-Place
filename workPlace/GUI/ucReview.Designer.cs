namespace GUI
{
    partial class ucReview
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
            this.picAvatar = new Krypton.Toolkit.KryptonPictureBox();
            this.lblReviewerName = new System.Windows.Forms.Label();
            this.lblReviewRating = new System.Windows.Forms.Label();
            this.btnReviewContainer = new Krypton.Toolkit.KryptonButton();
            this.btnReviewContentContainer = new Krypton.Toolkit.KryptonButton();
            this.btnJobDetail = new Krypton.Toolkit.KryptonButton();
            this.lblComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::GUI.Properties.Resources.man_icon;
            this.picAvatar.Location = new System.Drawing.Point(34, 22);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(60, 60);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // lblReviewerName
            // 
            this.lblReviewerName.AutoSize = true;
            this.lblReviewerName.BackColor = System.Drawing.Color.White;
            this.lblReviewerName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewerName.Location = new System.Drawing.Point(114, 29);
            this.lblReviewerName.Name = "lblReviewerName";
            this.lblReviewerName.Size = new System.Drawing.Size(169, 22);
            this.lblReviewerName.TabIndex = 2;
            this.lblReviewerName.Text = "Reviewer Name";
            // 
            // lblReviewRating
            // 
            this.lblReviewRating.AutoSize = true;
            this.lblReviewRating.BackColor = System.Drawing.Color.White;
            this.lblReviewRating.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewRating.Location = new System.Drawing.Point(117, 56);
            this.lblReviewRating.Name = "lblReviewRating";
            this.lblReviewRating.Size = new System.Drawing.Size(121, 18);
            this.lblReviewRating.TabIndex = 3;
            this.lblReviewRating.Text = "Rate: 1.0/10.0";
            // 
            // btnReviewContainer
            // 
            this.btnReviewContainer.Enabled = false;
            this.btnReviewContainer.Location = new System.Drawing.Point(0, 0);
            this.btnReviewContainer.Name = "btnReviewContainer";
            this.btnReviewContainer.Size = new System.Drawing.Size(414, 209);
            this.btnReviewContainer.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnReviewContainer.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnReviewContainer.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnReviewContainer.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnReviewContainer.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReviewContainer.StateDisabled.Border.Rounding = 6F;
            this.btnReviewContainer.StateDisabled.Border.Width = 1;
            this.btnReviewContainer.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnReviewContainer.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnReviewContainer.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnReviewContainer.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnReviewContainer.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReviewContainer.StateNormal.Border.Rounding = 6F;
            this.btnReviewContainer.StateNormal.Border.Width = 1;
            this.btnReviewContainer.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnReviewContainer.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnReviewContainer.TabIndex = 4;
            this.btnReviewContainer.Values.Text = "";
            // 
            // btnReviewContentContainer
            // 
            this.btnReviewContentContainer.Enabled = false;
            this.btnReviewContentContainer.Location = new System.Drawing.Point(34, 94);
            this.btnReviewContentContainer.Name = "btnReviewContentContainer";
            this.btnReviewContentContainer.Size = new System.Drawing.Size(350, 92);
            this.btnReviewContentContainer.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnReviewContentContainer.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnReviewContentContainer.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnReviewContentContainer.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnReviewContentContainer.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReviewContentContainer.StateDisabled.Border.Rounding = 10F;
            this.btnReviewContentContainer.StateDisabled.Border.Width = 0;
            this.btnReviewContentContainer.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnReviewContentContainer.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnReviewContentContainer.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnReviewContentContainer.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnReviewContentContainer.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReviewContentContainer.StateNormal.Border.Rounding = 10F;
            this.btnReviewContentContainer.StateNormal.Border.Width = 0;
            this.btnReviewContentContainer.TabIndex = 6;
            this.btnReviewContentContainer.Values.Text = "";
            // 
            // btnJobDetail
            // 
            this.btnJobDetail.Location = new System.Drawing.Point(319, 56);
            this.btnJobDetail.Name = "btnJobDetail";
            this.btnJobDetail.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnJobDetail.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnJobDetail.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnJobDetail.OverrideDefault.Border.Rounding = 4F;
            this.btnJobDetail.OverrideDefault.Border.Width = 0;
            this.btnJobDetail.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnJobDetail.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnJobDetail.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobDetail.Size = new System.Drawing.Size(65, 20);
            this.btnJobDetail.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnJobDetail.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnJobDetail.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnJobDetail.StateNormal.Border.Rounding = 4F;
            this.btnJobDetail.StateNormal.Border.Width = 0;
            this.btnJobDetail.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnJobDetail.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnJobDetail.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobDetail.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnJobDetail.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnJobDetail.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnJobDetail.StatePressed.Border.Rounding = 4F;
            this.btnJobDetail.StatePressed.Border.Width = 0;
            this.btnJobDetail.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnJobDetail.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnJobDetail.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobDetail.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnJobDetail.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.btnJobDetail.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnJobDetail.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnJobDetail.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnJobDetail.StateTracking.Border.Rounding = 4F;
            this.btnJobDetail.StateTracking.Border.Width = 1;
            this.btnJobDetail.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnJobDetail.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnJobDetail.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobDetail.TabIndex = 7;
            this.btnJobDetail.Values.Text = "Detail";
            this.btnJobDetail.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // lblComment
            // 
            this.lblComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblComment.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblComment.Location = new System.Drawing.Point(48, 104);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(320, 72);
            this.lblComment.TabIndex = 8;
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnJobDetail);
            this.Controls.Add(this.btnReviewContentContainer);
            this.Controls.Add(this.lblReviewRating);
            this.Controls.Add(this.lblReviewerName);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnReviewContainer);
            this.Name = "ucReview";
            this.Size = new System.Drawing.Size(414, 209);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPictureBox picAvatar;
        private System.Windows.Forms.Label lblReviewerName;
        private System.Windows.Forms.Label lblReviewRating;
        private Krypton.Toolkit.KryptonButton btnReviewContainer;
        private Krypton.Toolkit.KryptonButton btnReviewContentContainer;
        private Krypton.Toolkit.KryptonButton btnJobDetail;
        private System.Windows.Forms.Label lblComment;
    }
}
