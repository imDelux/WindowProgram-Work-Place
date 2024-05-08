namespace GUI
{
    partial class fChangeInformation
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
            this.txtAge = new Krypton.Toolkit.KryptonTextBox();
            this.lblAgeHeader = new System.Windows.Forms.Label();
            this.btnConfirm = new Krypton.Toolkit.KryptonButton();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            this.lblNameHeader = new System.Windows.Forms.Label();
            this.txtTelephone = new Krypton.Toolkit.KryptonTextBox();
            this.lblTelephoneHeader = new System.Windows.Forms.Label();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.lblEmailHeader = new System.Windows.Forms.Label();
            this.txtLocation = new Krypton.Toolkit.KryptonTextBox();
            this.lblLocationHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(427, 58);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(117, 43);
            this.txtAge.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtAge.StateActive.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtAge.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtAge.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtAge.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAge.StateCommon.Border.Rounding = 10F;
            this.txtAge.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtAge.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtAge.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtAge.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAge.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.txtAge.StateDisabled.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtAge.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtAge.StateNormal.Content.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtAge.TabIndex = 2;
            // 
            // lblAgeHeader
            // 
            this.lblAgeHeader.AutoSize = true;
            this.lblAgeHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblAgeHeader.Location = new System.Drawing.Point(461, 27);
            this.lblAgeHeader.Name = "lblAgeHeader";
            this.lblAgeHeader.Size = new System.Drawing.Size(47, 28);
            this.lblAgeHeader.TabIndex = 56;
            this.lblAgeHeader.Text = "Age";
            // 
            // btnConfirm
            // 
            this.btnConfirm.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.btnConfirm.Location = new System.Drawing.Point(242, 389);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumPurple;
            this.btnConfirm.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.Size = new System.Drawing.Size(107, 39);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnConfirm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateNormal.Border.Rounding = 10F;
            this.btnConfirm.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnConfirm.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StatePressed.Border.Rounding = 15F;
            this.btnConfirm.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            this.btnConfirm.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateTracking.Border.Rounding = 15F;
            this.btnConfirm.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.btnConfirm.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Values.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(40, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 43);
            this.txtName.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtName.StateActive.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.Rounding = 10F;
            this.txtName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtName.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtName.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtName.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.txtName.StateDisabled.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtName.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtName.StateNormal.Content.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtName.TabIndex = 1;
            // 
            // lblNameHeader
            // 
            this.lblNameHeader.AutoSize = true;
            this.lblNameHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblNameHeader.Location = new System.Drawing.Point(66, 27);
            this.lblNameHeader.Name = "lblNameHeader";
            this.lblNameHeader.Size = new System.Drawing.Size(64, 28);
            this.lblNameHeader.TabIndex = 58;
            this.lblNameHeader.Text = "Name";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(40, 141);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(504, 43);
            this.txtTelephone.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtTelephone.StateActive.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtTelephone.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTelephone.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTelephone.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTelephone.StateCommon.Border.Rounding = 10F;
            this.txtTelephone.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtTelephone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTelephone.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTelephone.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTelephone.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.txtTelephone.StateDisabled.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtTelephone.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtTelephone.StateNormal.Content.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtTelephone.TabIndex = 3;
            // 
            // lblTelephoneHeader
            // 
            this.lblTelephoneHeader.AutoSize = true;
            this.lblTelephoneHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblTelephoneHeader.Location = new System.Drawing.Point(66, 110);
            this.lblTelephoneHeader.Name = "lblTelephoneHeader";
            this.lblTelephoneHeader.Size = new System.Drawing.Size(101, 28);
            this.lblTelephoneHeader.TabIndex = 60;
            this.lblTelephoneHeader.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(40, 226);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(504, 43);
            this.txtEmail.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtEmail.StateActive.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 10F;
            this.txtEmail.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtEmail.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEmail.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtEmail.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.txtEmail.StateDisabled.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtEmail.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateNormal.Content.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmailHeader
            // 
            this.lblEmailHeader.AutoSize = true;
            this.lblEmailHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblEmailHeader.Location = new System.Drawing.Point(66, 195);
            this.lblEmailHeader.Name = "lblEmailHeader";
            this.lblEmailHeader.Size = new System.Drawing.Size(59, 28);
            this.lblEmailHeader.TabIndex = 62;
            this.lblEmailHeader.Text = "Email";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(40, 311);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(504, 43);
            this.txtLocation.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.txtLocation.StateActive.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.StateActive.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtLocation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtLocation.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtLocation.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLocation.StateCommon.Border.Rounding = 10F;
            this.txtLocation.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtLocation.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtLocation.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtLocation.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLocation.StateDisabled.Content.Color1 = System.Drawing.Color.Gray;
            this.txtLocation.StateDisabled.Content.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtLocation.StateNormal.Content.Color1 = System.Drawing.Color.White;
            this.txtLocation.StateNormal.Content.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.StateNormal.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtLocation.TabIndex = 5;
            // 
            // lblLocationHeader
            // 
            this.lblLocationHeader.AutoSize = true;
            this.lblLocationHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblLocationHeader.Location = new System.Drawing.Point(66, 280);
            this.lblLocationHeader.Name = "lblLocationHeader";
            this.lblLocationHeader.Size = new System.Drawing.Size(87, 28);
            this.lblLocationHeader.TabIndex = 64;
            this.lblLocationHeader.Text = "Location";
            // 
            // fChangeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocationHeader);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmailHeader);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephoneHeader);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNameHeader);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAgeHeader);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fChangeInformation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 10F;
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtAge;
        private System.Windows.Forms.Label lblAgeHeader;
        private Krypton.Toolkit.KryptonButton btnConfirm;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private System.Windows.Forms.Label lblNameHeader;
        private Krypton.Toolkit.KryptonTextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephoneHeader;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label lblEmailHeader;
        private Krypton.Toolkit.KryptonTextBox txtLocation;
        private System.Windows.Forms.Label lblLocationHeader;
    }
}