namespace GUI
{
    partial class ucHiringCard
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
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.lblWorkerAge = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.lblJobDesciption = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.btnBack = new Krypton.Toolkit.KryptonButton();
            this.picJobStatus = new System.Windows.Forms.PictureBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.picLine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picJobStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoEllipsis = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.White;
            this.lblWorkerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWorkerName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.Location = new System.Drawing.Point(120, 37);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(148, 27);
            this.lblWorkerName.TabIndex = 42;
            this.lblWorkerName.Text = "Gabiel Erickson";
            this.lblWorkerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWorkerName.Click += new System.EventHandler(this.lblJobName_Click);
            // 
            // lblWorkerAge
            // 
            this.lblWorkerAge.AutoEllipsis = true;
            this.lblWorkerAge.AutoSize = true;
            this.lblWorkerAge.BackColor = System.Drawing.Color.White;
            this.lblWorkerAge.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerAge.Location = new System.Drawing.Point(122, 74);
            this.lblWorkerAge.Name = "lblWorkerAge";
            this.lblWorkerAge.Size = new System.Drawing.Size(60, 16);
            this.lblWorkerAge.TabIndex = 43;
            this.lblWorkerAge.Text = "Age : 25";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoEllipsis = true;
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(122, 105);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(146, 23);
            this.lblLocation.TabIndex = 44;
            this.lblLocation.Text = "Location: Ho Chi Minh City";
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoEllipsis = true;
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.BackColor = System.Drawing.Color.White;
            this.lblJobDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDate.Location = new System.Drawing.Point(299, 74);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(67, 16);
            this.lblJobDate.TabIndex = 39;
            this.lblJobDate.Text = "Job date";
            // 
            // lblJobDesciption
            // 
            this.lblJobDesciption.AutoEllipsis = true;
            this.lblJobDesciption.BackColor = System.Drawing.Color.White;
            this.lblJobDesciption.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDesciption.Location = new System.Drawing.Point(299, 105);
            this.lblJobDesciption.Name = "lblJobDesciption";
            this.lblJobDesciption.Size = new System.Drawing.Size(126, 23);
            this.lblJobDesciption.TabIndex = 40;
            this.lblJobDesciption.Text = "Job description goes  here";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoEllipsis = true;
            this.lblJobName.BackColor = System.Drawing.Color.White;
            this.lblJobName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJobName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(298, 37);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(128, 27);
            this.lblJobName.TabIndex = 38;
            this.lblJobName.Text = "Job name";
            this.lblJobName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJobName.Click += new System.EventHandler(this.lblJobName_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(20, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBack.Size = new System.Drawing.Size(445, 144);
            this.btnBack.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.Rounding = 20F;
            this.btnBack.StateCommon.Border.Width = 2;
            this.btnBack.TabIndex = 45;
            this.btnBack.Values.Text = "";
            // 
            // picJobStatus
            // 
            this.picJobStatus.BackColor = System.Drawing.Color.White;
            this.picJobStatus.Image = global::GUI.Properties.Resources.jobOnWaiting;
            this.picJobStatus.Location = new System.Drawing.Point(444, 0);
            this.picJobStatus.Name = "picJobStatus";
            this.picJobStatus.Size = new System.Drawing.Size(36, 35);
            this.picJobStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJobStatus.TabIndex = 28;
            this.picJobStatus.TabStop = false;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Image = global::GUI.Properties.Resources.man_icon;
            this.picAvatar.Location = new System.Drawing.Point(43, 46);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(71, 74);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 41;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.lblJobName_Click);
            // 
            // picLine
            // 
            this.picLine.BackColor = System.Drawing.Color.White;
            this.picLine.Image = global::GUI.Properties.Resources.line;
            this.picLine.Location = new System.Drawing.Point(276, 18);
            this.picLine.Name = "picLine";
            this.picLine.Size = new System.Drawing.Size(10, 126);
            this.picLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLine.TabIndex = 46;
            this.picLine.TabStop = false;
            // 
            // ucHiringCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.picJobStatus);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.lblWorkerAge);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.lblJobDesciption);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.picLine);
            this.Controls.Add(this.btnBack);
            this.Name = "ucHiringCard";
            this.Size = new System.Drawing.Size(485, 162);
            ((System.ComponentModel.ISupportInitialize)(this.picJobStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picJobStatus;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.Label lblWorkerAge;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Label lblJobDesciption;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.PictureBox picLine;
        private Krypton.Toolkit.KryptonButton btnBack;
    }
}
