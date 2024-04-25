namespace GUI
{
    partial class fPostJob
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTilte = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.lblJobDes = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.rbtnNight = new Krypton.Toolkit.KryptonRadioButton();
            this.rbtnMorning = new Krypton.Toolkit.KryptonRadioButton();
            this.txtSkill = new Krypton.Toolkit.KryptonTextBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.picExit = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(125, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(193, 34);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Post a job for free";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(126, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 36);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "Increase quality of your hire";
            this.lblTitle.Click += new System.EventHandler(this.lblJobdes_Click);
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoEllipsis = true;
            this.lblJobTitle.BackColor = System.Drawing.Color.White;
            this.lblJobTitle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblJobTitle.Location = new System.Drawing.Point(34, 149);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(220, 33);
            this.lblJobTitle.TabIndex = 45;
            this.lblJobTitle.Text = "Job title";
            // 
            // txtJobTilte
            // 
            this.txtJobTilte.Location = new System.Drawing.Point(37, 185);
            this.txtJobTilte.Name = "txtJobTilte";
            this.txtJobTilte.Size = new System.Drawing.Size(320, 38);
            this.txtJobTilte.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtJobTilte.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtJobTilte.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtJobTilte.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobTilte.StateCommon.Border.Rounding = 5F;
            this.txtJobTilte.StateCommon.Border.Width = 1;
            this.txtJobTilte.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.txtJobTilte.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTilte.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtJobTilte.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txtJobTilte.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtJobTilte.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.txtJobTilte.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobTilte.StateNormal.Border.Rounding = 3F;
            this.txtJobTilte.StateNormal.Border.Width = 1;
            this.txtJobTilte.TabIndex = 46;
            this.txtJobTilte.Text = "Add a title you are hiring for";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(37, 265);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(320, 38);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 5F;
            this.kryptonTextBox1.StateCommon.Border.Width = 1;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonTextBox1.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateNormal.Border.Rounding = 3F;
            this.kryptonTextBox1.StateNormal.Border.Width = 1;
            this.kryptonTextBox1.TabIndex = 48;
            this.kryptonTextBox1.Text = "Write down your description about job";
            // 
            // lblJobDes
            // 
            this.lblJobDes.AutoEllipsis = true;
            this.lblJobDes.BackColor = System.Drawing.Color.White;
            this.lblJobDes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblJobDes.Location = new System.Drawing.Point(34, 240);
            this.lblJobDes.Name = "lblJobDes";
            this.lblJobDes.Size = new System.Drawing.Size(220, 36);
            this.lblJobDes.TabIndex = 47;
            this.lblJobDes.Text = "Job description";
            // 
            // lblTime
            // 
            this.lblTime.AutoEllipsis = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTime.Location = new System.Drawing.Point(34, 320);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(220, 36);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Time";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(37, 347);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(320, 31);
            this.kryptonDateTimePicker1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDateTimePicker1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDateTimePicker1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDateTimePicker1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDateTimePicker1.StateCommon.Border.Rounding = 7F;
            this.kryptonDateTimePicker1.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonDateTimePicker1.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDateTimePicker1.TabIndex = 50;
            // 
            // rbtnNight
            // 
            this.rbtnNight.Location = new System.Drawing.Point(208, 392);
            this.rbtnNight.Name = "rbtnNight";
            this.rbtnNight.Size = new System.Drawing.Size(60, 21);
            this.rbtnNight.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.rbtnNight.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.rbtnNight.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNight.TabIndex = 52;
            this.rbtnNight.Values.Text = "Night";
            // 
            // rbtnMorning
            // 
            this.rbtnMorning.Location = new System.Drawing.Point(97, 392);
            this.rbtnMorning.Name = "rbtnMorning";
            this.rbtnMorning.Size = new System.Drawing.Size(79, 21);
            this.rbtnMorning.StateCommon.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbtnMorning.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.rbtnMorning.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.rbtnMorning.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMorning.TabIndex = 51;
            this.rbtnMorning.Values.Text = "Morning";
            // 
            // txtSkill
            // 
            this.txtSkill.Location = new System.Drawing.Point(37, 452);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.Size = new System.Drawing.Size(320, 38);
            this.txtSkill.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSkill.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSkill.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSkill.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSkill.StateCommon.Border.Rounding = 5F;
            this.txtSkill.StateCommon.Border.Width = 1;
            this.txtSkill.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.txtSkill.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkill.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtSkill.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txtSkill.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtSkill.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.txtSkill.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSkill.StateNormal.Border.Rounding = 3F;
            this.txtSkill.StateNormal.Border.Width = 1;
            this.txtSkill.TabIndex = 54;
            this.txtSkill.Text = "Update your skill";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoEllipsis = true;
            this.lblSkill.BackColor = System.Drawing.Color.White;
            this.lblSkill.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkill.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSkill.Location = new System.Drawing.Point(34, 416);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(220, 26);
            this.lblSkill.TabIndex = 53;
            this.lblSkill.Text = "Skill";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(37, 540);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(320, 38);
            this.kryptonTextBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateCommon.Border.Rounding = 5F;
            this.kryptonTextBox2.StateCommon.Border.Width = 1;
            this.kryptonTextBox2.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonTextBox2.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox2.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateNormal.Border.Rounding = 3F;
            this.kryptonTextBox2.StateNormal.Border.Width = 1;
            this.kryptonTextBox2.TabIndex = 56;
            this.kryptonTextBox2.Text = "Add the wage you want";
            // 
            // lblWage
            // 
            this.lblWage.AutoEllipsis = true;
            this.lblWage.BackColor = System.Drawing.Color.White;
            this.lblWage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblWage.Location = new System.Drawing.Point(34, 511);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(220, 36);
            this.lblWage.TabIndex = 55;
            this.lblWage.Text = "Wage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.ask;
            this.pictureBox1.Location = new System.Drawing.Point(97, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 30);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Image = global::GUI.Properties.Resources.man;
            this.ptbAvatar.Location = new System.Drawing.Point(37, 54);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(73, 71);
            this.ptbAvatar.TabIndex = 0;
            this.ptbAvatar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.ask;
            this.pictureBox2.Location = new System.Drawing.Point(69, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 26);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.circle__2_;
            this.pictureBox3.Location = new System.Drawing.Point(291, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.btnNext.Location = new System.Drawing.Point(166, 600);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 55);
            this.btnNext.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.btnNext.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnNext.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnNext.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnNext.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnNext.StateNormal.Back.Image = global::GUI.Properties.Resources.right_arrow;
            this.btnNext.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnNext.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNext.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateNormal.Border.Rounding = 30F;
            this.btnNext.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNext.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(192)))));
            this.btnNext.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnNext.StatePressed.Back.Image = global::GUI.Properties.Resources.right_arrow;
            this.btnNext.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNext.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StatePressed.Border.Rounding = 30F;
            this.btnNext.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNext.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNext.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(192)))));
            this.btnNext.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateTracking.Back.Image = global::GUI.Properties.Resources.right_arrow;
            this.btnNext.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNext.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateTracking.Border.Rounding = 30F;
            this.btnNext.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNext.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNext.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.TabIndex = 60;
            this.btnNext.Values.Text = "";
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::GUI.Properties.Resources.reject;
            this.picExit.Location = new System.Drawing.Point(356, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(30, 30);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 61;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // fPostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 681);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonTextBox2);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.txtSkill);
            this.Controls.Add(this.lblSkill);
            this.Controls.Add(this.rbtnNight);
            this.Controls.Add(this.rbtnMorning);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.lblJobDes);
            this.Controls.Add(this.txtJobTilte);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ptbAvatar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPostJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 10F;
            this.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "fPostJob";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private Krypton.Toolkit.KryptonTextBox txtJobTilte;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Label lblJobDes;
        private System.Windows.Forms.Label lblTime;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonRadioButton rbtnNight;
        private Krypton.Toolkit.KryptonRadioButton rbtnMorning;
        private Krypton.Toolkit.KryptonTextBox txtSkill;
        private System.Windows.Forms.Label lblSkill;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonButton btnNext;
        private Krypton.Toolkit.KryptonPictureBox picExit;
    }
}