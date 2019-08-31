namespace WindowsFormsApplication1
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.FromL = new System.Windows.Forms.Label();
            this.ToL = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.JourneyDtL = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.Hmpage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FromCMbox = new System.Windows.Forms.ComboBox();
            this.ToCMbox = new System.Windows.Forms.ComboBox();
            this.LogoutB = new System.Windows.Forms.Button();
            this.ProfileLL = new System.Windows.Forms.LinkLabel();
            this.UNL = new System.Windows.Forms.Label();
            this.UNbox = new System.Windows.Forms.TextBox();
            this.CheckTicktB = new System.Windows.Forms.Button();
            this.RefBx = new System.Windows.Forms.TextBox();
            this.RefBox = new System.Windows.Forms.Label();
            this.CheckAVB = new System.Windows.Forms.Button();
            this.AvailabilityL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FromL
            // 
            this.FromL.AutoSize = true;
            this.FromL.Location = new System.Drawing.Point(355, 110);
            this.FromL.Name = "FromL";
            this.FromL.Size = new System.Drawing.Size(30, 13);
            this.FromL.TabIndex = 0;
            this.FromL.Text = "From";
            // 
            // ToL
            // 
            this.ToL.AutoSize = true;
            this.ToL.Location = new System.Drawing.Point(355, 163);
            this.ToL.Name = "ToL";
            this.ToL.Size = new System.Drawing.Size(20, 13);
            this.ToL.TabIndex = 1;
            this.ToL.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(358, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2018, 9, 3, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // JourneyDtL
            // 
            this.JourneyDtL.AutoSize = true;
            this.JourneyDtL.Location = new System.Drawing.Point(355, 223);
            this.JourneyDtL.Name = "JourneyDtL";
            this.JourneyDtL.Size = new System.Drawing.Size(70, 13);
            this.JourneyDtL.TabIndex = 5;
            this.JourneyDtL.Text = "Journey Date";
            // 
            // searchB
            // 
            this.searchB.Enabled = false;
            this.searchB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.searchB.Location = new System.Drawing.Point(504, 287);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(54, 23);
            this.searchB.TabIndex = 6;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitB.ForeColor = System.Drawing.Color.Crimson;
            this.ExitB.Location = new System.Drawing.Point(358, 287);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(58, 23);
            this.ExitB.TabIndex = 7;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // Hmpage
            // 
            this.Hmpage.AutoSize = true;
            this.Hmpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hmpage.ForeColor = System.Drawing.Color.ForestGreen;
            this.Hmpage.Location = new System.Drawing.Point(377, 9);
            this.Hmpage.Name = "Hmpage";
            this.Hmpage.Size = new System.Drawing.Size(150, 29);
            this.Hmpage.TabIndex = 8;
            this.Hmpage.Text = "Home Page";
            this.Hmpage.Click += new System.EventHandler(this.Hmpage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FromCMbox
            // 
            this.FromCMbox.AccessibleName = "";
            this.FromCMbox.Enabled = false;
            this.FromCMbox.FormattingEnabled = true;
            this.FromCMbox.Items.AddRange(new object[] {
            "Bogra",
            "Barisal",
            "Rajshahi",
            "Dhaka",
            "Feni",
            "Rangpur",
            "Chittagong",
            "Dinajpur",
            "Khulna"});
            this.FromCMbox.Location = new System.Drawing.Point(358, 127);
            this.FromCMbox.Name = "FromCMbox";
            this.FromCMbox.Size = new System.Drawing.Size(200, 21);
            this.FromCMbox.TabIndex = 10;
            this.FromCMbox.Text = "Select Pick Up Point";
            this.FromCMbox.SelectedIndexChanged += new System.EventHandler(this.FromCMbox_SelectedIndexChanged);
            // 
            // ToCMbox
            // 
            this.ToCMbox.Enabled = false;
            this.ToCMbox.FormattingEnabled = true;
            this.ToCMbox.Items.AddRange(new object[] {
            "Bogra",
            "Barisal",
            "Rajshahi",
            "Dhaka",
            "Feni",
            "Rangpur",
            "Chittagong",
            "Dinajpur",
            "Khulna"});
            this.ToCMbox.Location = new System.Drawing.Point(358, 182);
            this.ToCMbox.Name = "ToCMbox";
            this.ToCMbox.Size = new System.Drawing.Size(200, 21);
            this.ToCMbox.TabIndex = 11;
            this.ToCMbox.Text = "Select Destination point";
            // 
            // LogoutB
            // 
            this.LogoutB.ForeColor = System.Drawing.Color.Maroon;
            this.LogoutB.Location = new System.Drawing.Point(433, 287);
            this.LogoutB.Name = "LogoutB";
            this.LogoutB.Size = new System.Drawing.Size(54, 23);
            this.LogoutB.TabIndex = 12;
            this.LogoutB.Text = "Logout";
            this.LogoutB.UseVisualStyleBackColor = true;
            this.LogoutB.Click += new System.EventHandler(this.LogoutB_Click);
            // 
            // ProfileLL
            // 
            this.ProfileLL.AutoSize = true;
            this.ProfileLL.Location = new System.Drawing.Point(345, 341);
            this.ProfileLL.Name = "ProfileLL";
            this.ProfileLL.Size = new System.Drawing.Size(82, 13);
            this.ProfileLL.TabIndex = 13;
            this.ProfileLL.TabStop = true;
            this.ProfileLL.Text = "Edit Your Profile";
            this.ProfileLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProfileLL_LinkClicked);
            // 
            // UNL
            // 
            this.UNL.AutoSize = true;
            this.UNL.Location = new System.Drawing.Point(56, 30);
            this.UNL.Name = "UNL";
            this.UNL.Size = new System.Drawing.Size(60, 13);
            this.UNL.TabIndex = 14;
            this.UNL.Text = "User Name";
            // 
            // UNbox
            // 
            this.UNbox.Location = new System.Drawing.Point(128, 27);
            this.UNbox.Name = "UNbox";
            this.UNbox.ReadOnly = true;
            this.UNbox.Size = new System.Drawing.Size(131, 20);
            this.UNbox.TabIndex = 15;
            // 
            // CheckTicktB
            // 
            this.CheckTicktB.ForeColor = System.Drawing.Color.Maroon;
            this.CheckTicktB.Location = new System.Drawing.Point(433, 336);
            this.CheckTicktB.Name = "CheckTicktB";
            this.CheckTicktB.Size = new System.Drawing.Size(125, 23);
            this.CheckTicktB.TabIndex = 16;
            this.CheckTicktB.Text = "Check Ticket Details";
            this.CheckTicktB.UseVisualStyleBackColor = true;
            this.CheckTicktB.Click += new System.EventHandler(this.CheckTicktB_Click);
            // 
            // RefBx
            // 
            this.RefBx.Location = new System.Drawing.Point(128, 53);
            this.RefBx.Name = "RefBx";
            this.RefBx.Size = new System.Drawing.Size(131, 20);
            this.RefBx.TabIndex = 18;
            this.RefBx.TextChanged += new System.EventHandler(this.RefBx_TextChanged);
            // 
            // RefBox
            // 
            this.RefBox.AutoSize = true;
            this.RefBox.Location = new System.Drawing.Point(56, 56);
            this.RefBox.Name = "RefBox";
            this.RefBox.Size = new System.Drawing.Size(27, 13);
            this.RefBox.TabIndex = 17;
            this.RefBox.Text = "Ref.";
            // 
            // CheckAVB
            // 
            this.CheckAVB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckAVB.ForeColor = System.Drawing.Color.Crimson;
            this.CheckAVB.Location = new System.Drawing.Point(276, 51);
            this.CheckAVB.Name = "CheckAVB";
            this.CheckAVB.Size = new System.Drawing.Size(109, 23);
            this.CheckAVB.TabIndex = 19;
            this.CheckAVB.Text = "Check Availability";
            this.CheckAVB.UseVisualStyleBackColor = false;
            this.CheckAVB.Click += new System.EventHandler(this.CheckAVB_Click);
            // 
            // AvailabilityL
            // 
            this.AvailabilityL.AutoSize = true;
            this.AvailabilityL.Location = new System.Drawing.Point(125, 80);
            this.AvailabilityL.Name = "AvailabilityL";
            this.AvailabilityL.Size = new System.Drawing.Size(70, 13);
            this.AvailabilityL.TabIndex = 20;
            this.AvailabilityL.Text = "Not Available";
            this.AvailabilityL.Visible = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(589, 392);
            this.Controls.Add(this.AvailabilityL);
            this.Controls.Add(this.CheckAVB);
            this.Controls.Add(this.RefBx);
            this.Controls.Add(this.RefBox);
            this.Controls.Add(this.CheckTicktB);
            this.Controls.Add(this.UNbox);
            this.Controls.Add(this.UNL);
            this.Controls.Add(this.ProfileLL);
            this.Controls.Add(this.LogoutB);
            this.Controls.Add(this.ToCMbox);
            this.Controls.Add(this.FromCMbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hmpage);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.JourneyDtL);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ToL);
            this.Controls.Add(this.FromL);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromL;
        private System.Windows.Forms.Label ToL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label JourneyDtL;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Label Hmpage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox FromCMbox;
        private System.Windows.Forms.ComboBox ToCMbox;
        private System.Windows.Forms.Button LogoutB;
        private System.Windows.Forms.LinkLabel ProfileLL;
        private System.Windows.Forms.Label UNL;
        private System.Windows.Forms.TextBox UNbox;
        private System.Windows.Forms.Button CheckTicktB;
        private System.Windows.Forms.TextBox RefBx;
        private System.Windows.Forms.Label RefBox;
        private System.Windows.Forms.Button CheckAVB;
        private System.Windows.Forms.Label AvailabilityL;

    }
}