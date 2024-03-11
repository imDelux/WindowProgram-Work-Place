namespace GUI
{
    partial class fWorker
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
            this.components = new System.ComponentModel.Container();
            this.kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSchedule = new Krypton.Toolkit.KryptonButton();
            this.btnNotification = new Krypton.Toolkit.KryptonButton();
            this.btnProfile = new Krypton.Toolkit.KryptonButton();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            this.kryptonCustomPaletteBase1.BaseFont = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonCustomPaletteBase1.BaseFontSize = 9F;
            this.kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            this.kryptonCustomPaletteBase1.ThemeName = "";
            this.kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.White;
            this.pnlDashboard.Controls.Add(this.btnProfile);
            this.pnlDashboard.Controls.Add(this.btnNotification);
            this.pnlDashboard.Controls.Add(this.btnSchedule);
            this.pnlDashboard.Controls.Add(this.panel1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(264, 766);
            this.pnlDashboard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(75, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unemployed";
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::GUI.Properties.Resources.work_place_logo;
            this.kryptonPictureBox1.InitialImage = global::GUI.Properties.Resources.work_place_logo;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(86, 42);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(92, 92);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 0;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 216);
            this.panel1.TabIndex = 6;
            // 
            // btnSchedule
            // 
            this.btnSchedule.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.Location = new System.Drawing.Point(0, 216);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnSchedule.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnSchedule.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSchedule.OverrideDefault.Border.Width = 0;
            this.btnSchedule.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSchedule.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSchedule.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnSchedule.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnSchedule.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSchedule.OverrideFocus.Border.Width = 0;
            this.btnSchedule.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSchedule.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSchedule.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Size = new System.Drawing.Size(264, 56);
            this.btnSchedule.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSchedule.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSchedule.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnSchedule.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnSchedule.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.btnSchedule.StateNormal.Border.Width = 1;
            this.btnSchedule.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSchedule.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSchedule.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnSchedule.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnSchedule.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSchedule.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSchedule.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSchedule.StatePressed.Border.Width = 0;
            this.btnSchedule.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSchedule.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSchedule.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSchedule.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSchedule.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnSchedule.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnSchedule.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.btnSchedule.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)(((Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSchedule.StateTracking.Border.Width = 1;
            this.btnSchedule.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSchedule.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnSchedule.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.TabIndex = 7;
            this.btnSchedule.Values.Text = "Schedule";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            this.btnSchedule.Leave += new System.EventHandler(this.btnSchedule_Leave);
            // 
            // btnNotification
            // 
            this.btnNotification.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnNotification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotification.Location = new System.Drawing.Point(0, 272);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNotification.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNotification.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNotification.OverrideDefault.Border.Width = 0;
            this.btnNotification.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNotification.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNotification.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNotification.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNotification.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNotification.OverrideFocus.Border.Width = 0;
            this.btnNotification.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNotification.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNotification.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.Size = new System.Drawing.Size(264, 56);
            this.btnNotification.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNotification.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNotification.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnNotification.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnNotification.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.btnNotification.StateNormal.Border.Width = 1;
            this.btnNotification.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnNotification.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnNotification.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNotification.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnNotification.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNotification.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnNotification.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNotification.StatePressed.Border.Width = 0;
            this.btnNotification.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNotification.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNotification.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNotification.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNotification.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnNotification.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnNotification.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.btnNotification.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)(((Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNotification.StateTracking.Border.Width = 1;
            this.btnNotification.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnNotification.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnNotification.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.TabIndex = 8;
            this.btnNotification.Values.Text = "Notification";
            this.btnNotification.Click += new System.EventHandler(this.btnSchedule_Click);
            this.btnNotification.Leave += new System.EventHandler(this.btnSchedule_Leave);
            // 
            // btnProfile
            // 
            this.btnProfile.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Location = new System.Drawing.Point(0, 328);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProfile.OverrideDefault.Border.Width = 0;
            this.btnProfile.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProfile.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProfile.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProfile.OverrideFocus.Border.Width = 0;
            this.btnProfile.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProfile.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProfile.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Size = new System.Drawing.Size(264, 56);
            this.btnProfile.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnProfile.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnProfile.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnProfile.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnProfile.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.btnProfile.StateNormal.Border.Width = 1;
            this.btnProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnProfile.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnProfile.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnProfile.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnProfile.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnProfile.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProfile.StatePressed.Border.Width = 0;
            this.btnProfile.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProfile.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnProfile.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnProfile.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnProfile.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnProfile.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnProfile.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.btnProfile.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)(((Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProfile.StateTracking.Border.Width = 1;
            this.btnProfile.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnProfile.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.btnProfile.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Values.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnSchedule_Click);
            this.btnProfile.Leave += new System.EventHandler(this.btnSchedule_Leave);
            // 
            // fWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1260, 766);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fWorker";
            this.Palette = this.kryptonCustomPaletteBase1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(225)))));
            this.StateActive.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 20F;
            this.StateActive.Border.Width = 1;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(225)))));
            this.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.StateCommon.Border.ColorAngle = 0F;
            this.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Width = 1;
            this.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False;
            this.Text = "fWorker";
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private System.Windows.Forms.Panel pnlDashboard;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnProfile;
        private Krypton.Toolkit.KryptonButton btnNotification;
        private Krypton.Toolkit.KryptonButton btnSchedule;
    }
}