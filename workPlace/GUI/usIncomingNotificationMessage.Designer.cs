namespace GUI
{
    partial class usIncomingNotificationMessage
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
            this.pnlBottomLine = new System.Windows.Forms.Panel();
            this.lblMainMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlBottomLine
            // 
            this.pnlBottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.pnlBottomLine.Location = new System.Drawing.Point(0, 39);
            this.pnlBottomLine.Name = "pnlBottomLine";
            this.pnlBottomLine.Size = new System.Drawing.Size(340, 10);
            this.pnlBottomLine.TabIndex = 1;
            // 
            // lblMainMessage
            // 
            this.lblMainMessage.AutoSize = true;
            this.lblMainMessage.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMessage.Location = new System.Drawing.Point(10, 5);
            this.lblMainMessage.Name = "lblMainMessage";
            this.lblMainMessage.Size = new System.Drawing.Size(233, 28);
            this.lblMainMessage.TabIndex = 2;
            this.lblMainMessage.Text = "Message goes here ...";
            // 
            // usIncomingNotificationMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMainMessage);
            this.Controls.Add(this.pnlBottomLine);
            this.Name = "usIncomingNotificationMessage";
            this.Size = new System.Drawing.Size(316, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottomLine;
        private System.Windows.Forms.Label lblMainMessage;
    }
}
