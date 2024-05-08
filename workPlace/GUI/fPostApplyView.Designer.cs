namespace GUI
{
    partial class fPostApplyView
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtWage = new Krypton.Toolkit.KryptonTextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.rbtnNight = new Krypton.Toolkit.KryptonRadioButton();
            this.rbtnMorning = new Krypton.Toolkit.KryptonRadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtJobDescription = new Krypton.Toolkit.KryptonTextBox();
            this.lblJobDes = new System.Windows.Forms.Label();
            this.txtJobTilte = new Krypton.Toolkit.KryptonTextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.pnlPostContainer = new System.Windows.Forms.Panel();
            this.lblPostHeader = new System.Windows.Forms.Label();
            this.lblApplyHeader = new System.Windows.Forms.Label();
            this.fpnlWorkerList = new System.Windows.Forms.FlowLayoutPanel();
            this.txtJobDate = new Krypton.Toolkit.KryptonTextBox();
            this.txtSkillRequired = new Krypton.Toolkit.KryptonTextBox();
            this.lblNoApllied = new System.Windows.Forms.Label();
            this.btnDeletePost = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlPostContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.ask;
            this.pictureBox2.Location = new System.Drawing.Point(84, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 26);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(52, 474);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(320, 38);
            this.txtWage.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtWage.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtWage.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtWage.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWage.StateCommon.Border.Rounding = 5F;
            this.txtWage.StateCommon.Border.Width = 1;
            this.txtWage.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtWage.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWage.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtWage.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txtWage.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtWage.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.txtWage.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtWage.StateNormal.Border.Rounding = 3F;
            this.txtWage.StateNormal.Border.Width = 1;
            this.txtWage.TabIndex = 74;
            this.txtWage.Text = "Add the wage you want";
            // 
            // lblWage
            // 
            this.lblWage.AutoEllipsis = true;
            this.lblWage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblWage.Location = new System.Drawing.Point(49, 448);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(220, 23);
            this.lblWage.TabIndex = 73;
            this.lblWage.Text = "Wage";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoEllipsis = true;
            this.lblSkill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSkill.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkill.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSkill.Location = new System.Drawing.Point(49, 354);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(220, 26);
            this.lblSkill.TabIndex = 72;
            this.lblSkill.Text = "Skill";
            // 
            // rbtnNight
            // 
            this.rbtnNight.Location = new System.Drawing.Point(223, 330);
            this.rbtnNight.Name = "rbtnNight";
            this.rbtnNight.Size = new System.Drawing.Size(60, 21);
            this.rbtnNight.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.rbtnNight.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.rbtnNight.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNight.TabIndex = 71;
            this.rbtnNight.Values.Text = "Night";
            // 
            // rbtnMorning
            // 
            this.rbtnMorning.Location = new System.Drawing.Point(112, 330);
            this.rbtnMorning.Name = "rbtnMorning";
            this.rbtnMorning.Size = new System.Drawing.Size(79, 21);
            this.rbtnMorning.StateCommon.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbtnMorning.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.rbtnMorning.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.rbtnMorning.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMorning.TabIndex = 70;
            this.rbtnMorning.Values.Text = "Morning";
            // 
            // lblTime
            // 
            this.lblTime.AutoEllipsis = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTime.Location = new System.Drawing.Point(49, 258);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(220, 24);
            this.lblTime.TabIndex = 68;
            this.lblTime.Text = "Time";
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.Location = new System.Drawing.Point(52, 203);
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.Size = new System.Drawing.Size(320, 38);
            this.txtJobDescription.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtJobDescription.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtJobDescription.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtJobDescription.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobDescription.StateCommon.Border.Rounding = 5F;
            this.txtJobDescription.StateCommon.Border.Width = 1;
            this.txtJobDescription.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtJobDescription.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F);
            this.txtJobDescription.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtJobDescription.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txtJobDescription.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtJobDescription.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.txtJobDescription.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobDescription.StateNormal.Border.Rounding = 3F;
            this.txtJobDescription.StateNormal.Border.Width = 1;
            this.txtJobDescription.TabIndex = 67;
            this.txtJobDescription.Text = "Write down your description about job";
            // 
            // lblJobDes
            // 
            this.lblJobDes.AutoEllipsis = true;
            this.lblJobDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblJobDes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblJobDes.Location = new System.Drawing.Point(49, 178);
            this.lblJobDes.Name = "lblJobDes";
            this.lblJobDes.Size = new System.Drawing.Size(220, 22);
            this.lblJobDes.TabIndex = 66;
            this.lblJobDes.Text = "Job description";
            // 
            // txtJobTilte
            // 
            this.txtJobTilte.Location = new System.Drawing.Point(52, 123);
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
            this.txtJobTilte.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
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
            this.txtJobTilte.TabIndex = 65;
            this.txtJobTilte.Text = "Add a title you are hiring for";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoEllipsis = true;
            this.lblJobTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblJobTitle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblJobTitle.Location = new System.Drawing.Point(49, 96);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(220, 24);
            this.lblJobTitle.TabIndex = 64;
            this.lblJobTitle.Text = "Job title";
            // 
            // pnlPostContainer
            // 
            this.pnlPostContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPostContainer.Controls.Add(this.btnDeletePost);
            this.pnlPostContainer.Controls.Add(this.txtSkillRequired);
            this.pnlPostContainer.Controls.Add(this.txtJobDate);
            this.pnlPostContainer.Controls.Add(this.lblPostHeader);
            this.pnlPostContainer.Controls.Add(this.txtJobTilte);
            this.pnlPostContainer.Controls.Add(this.lblJobTitle);
            this.pnlPostContainer.Controls.Add(this.pictureBox2);
            this.pnlPostContainer.Controls.Add(this.lblJobDes);
            this.pnlPostContainer.Controls.Add(this.txtWage);
            this.pnlPostContainer.Controls.Add(this.txtJobDescription);
            this.pnlPostContainer.Controls.Add(this.lblWage);
            this.pnlPostContainer.Controls.Add(this.lblTime);
            this.pnlPostContainer.Controls.Add(this.lblSkill);
            this.pnlPostContainer.Controls.Add(this.rbtnNight);
            this.pnlPostContainer.Controls.Add(this.rbtnMorning);
            this.pnlPostContainer.Location = new System.Drawing.Point(-1, -2);
            this.pnlPostContainer.Name = "pnlPostContainer";
            this.pnlPostContainer.Size = new System.Drawing.Size(425, 574);
            this.pnlPostContainer.TabIndex = 77;
            // 
            // lblPostHeader
            // 
            this.lblPostHeader.AutoSize = true;
            this.lblPostHeader.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostHeader.ForeColor = System.Drawing.Color.Gray;
            this.lblPostHeader.Location = new System.Drawing.Point(138, 38);
            this.lblPostHeader.Name = "lblPostHeader";
            this.lblPostHeader.Size = new System.Drawing.Size(131, 34);
            this.lblPostHeader.TabIndex = 77;
            this.lblPostHeader.Text = "Post Detail";
            // 
            // lblApplyHeader
            // 
            this.lblApplyHeader.AutoSize = true;
            this.lblApplyHeader.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplyHeader.ForeColor = System.Drawing.Color.IndianRed;
            this.lblApplyHeader.Location = new System.Drawing.Point(625, 33);
            this.lblApplyHeader.Name = "lblApplyHeader";
            this.lblApplyHeader.Size = new System.Drawing.Size(112, 34);
            this.lblApplyHeader.TabIndex = 78;
            this.lblApplyHeader.Text = "Apply: xx";
            // 
            // fpnlWorkerList
            // 
            this.fpnlWorkerList.AutoScroll = true;
            this.fpnlWorkerList.Location = new System.Drawing.Point(447, 84);
            this.fpnlWorkerList.Name = "fpnlWorkerList";
            this.fpnlWorkerList.Size = new System.Drawing.Size(478, 470);
            this.fpnlWorkerList.TabIndex = 79;
            // 
            // txtJobDate
            // 
            this.txtJobDate.Location = new System.Drawing.Point(52, 281);
            this.txtJobDate.Name = "txtJobDate";
            this.txtJobDate.Size = new System.Drawing.Size(320, 38);
            this.txtJobDate.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtJobDate.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtJobDate.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtJobDate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobDate.StateCommon.Border.Rounding = 5F;
            this.txtJobDate.StateCommon.Border.Width = 1;
            this.txtJobDate.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtJobDate.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F);
            this.txtJobDate.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtJobDate.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txtJobDate.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtJobDate.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.txtJobDate.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtJobDate.StateNormal.Border.Rounding = 3F;
            this.txtJobDate.StateNormal.Border.Width = 1;
            this.txtJobDate.TabIndex = 78;
            this.txtJobDate.Text = "Date";
            // 
            // txtSkillRequired
            // 
            this.txtSkillRequired.Location = new System.Drawing.Point(52, 383);
            this.txtSkillRequired.Name = "txtSkillRequired";
            this.txtSkillRequired.Size = new System.Drawing.Size(320, 38);
            this.txtSkillRequired.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSkillRequired.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSkillRequired.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSkillRequired.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSkillRequired.StateCommon.Border.Rounding = 5F;
            this.txtSkillRequired.StateCommon.Border.Width = 1;
            this.txtSkillRequired.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSkillRequired.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.8F);
            this.txtSkillRequired.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtSkillRequired.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txtSkillRequired.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtSkillRequired.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.txtSkillRequired.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSkillRequired.StateNormal.Border.Rounding = 3F;
            this.txtSkillRequired.StateNormal.Border.Width = 1;
            this.txtSkillRequired.TabIndex = 79;
            this.txtSkillRequired.Text = "Skill required";
            // 
            // lblNoApllied
            // 
            this.lblNoApllied.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoApllied.ForeColor = System.Drawing.Color.Gray;
            this.lblNoApllied.Location = new System.Drawing.Point(430, 295);
            this.lblNoApllied.Name = "lblNoApllied";
            this.lblNoApllied.Size = new System.Drawing.Size(511, 34);
            this.lblNoApllied.TabIndex = 80;
            this.lblNoApllied.Text = "No one applied to your job";
            this.lblNoApllied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.Location = new System.Drawing.Point(13, 14);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletePost.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletePost.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnDeletePost.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnDeletePost.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeletePost.OverrideDefault.Border.Rounding = 5F;
            this.btnDeletePost.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePost.Size = new System.Drawing.Size(76, 25);
            this.btnDeletePost.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletePost.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletePost.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnDeletePost.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnDeletePost.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeletePost.StateCommon.Border.Rounding = 5F;
            this.btnDeletePost.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeletePost.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDeletePost.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePost.TabIndex = 82;
            this.btnDeletePost.Values.Text = "Delete";
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // fPostApplyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(937, 570);
            this.Controls.Add(this.lblNoApllied);
            this.Controls.Add(this.fpnlWorkerList);
            this.Controls.Add(this.lblApplyHeader);
            this.Controls.Add(this.pnlPostContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fPostApplyView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 10F;
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlPostContainer.ResumeLayout(false);
            this.pnlPostContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonTextBox txtWage;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblSkill;
        private Krypton.Toolkit.KryptonRadioButton rbtnNight;
        private Krypton.Toolkit.KryptonRadioButton rbtnMorning;
        private System.Windows.Forms.Label lblTime;
        private Krypton.Toolkit.KryptonTextBox txtJobDescription;
        private System.Windows.Forms.Label lblJobDes;
        private Krypton.Toolkit.KryptonTextBox txtJobTilte;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Panel pnlPostContainer;
        private System.Windows.Forms.Label lblPostHeader;
        private System.Windows.Forms.Label lblApplyHeader;
        private System.Windows.Forms.FlowLayoutPanel fpnlWorkerList;
        private Krypton.Toolkit.KryptonTextBox txtSkillRequired;
        private Krypton.Toolkit.KryptonTextBox txtJobDate;
        private System.Windows.Forms.Label lblNoApllied;
        private Krypton.Toolkit.KryptonButton btnDeletePost;
    }
}