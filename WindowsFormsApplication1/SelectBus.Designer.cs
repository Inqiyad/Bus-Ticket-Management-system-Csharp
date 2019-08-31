namespace WindowsFormsApplication1
{
    partial class SelectBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectBus));
            this.BusNmL = new System.Windows.Forms.Label();
            this.BusNmCMbox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BusSltL = new System.Windows.Forms.Label();
            this.BackB = new System.Windows.Forms.Button();
            this.NextB = new System.Windows.Forms.Button();
            this.BusTypeL = new System.Windows.Forms.Label();
            this.BusTypeCMbox = new System.Windows.Forms.ComboBox();
            this.TravelTmL = new System.Windows.Forms.Label();
            this.TravelTimeCMbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BusNmL
            // 
            this.BusNmL.AutoSize = true;
            this.BusNmL.Location = new System.Drawing.Point(253, 101);
            this.BusNmL.Name = "BusNmL";
            this.BusNmL.Size = new System.Drawing.Size(56, 13);
            this.BusNmL.TabIndex = 0;
            this.BusNmL.Text = "Bus Name";
            // 
            // BusNmCMbox
            // 
            this.BusNmCMbox.FormattingEnabled = true;
            this.BusNmCMbox.Items.AddRange(new object[] {
            "Shah Fateh Ali",
            "Hanif Enterprise",
            "S.R Travels",
            "Dipjol Travels",
            "Nabil Paribahan",
            "National Travels",
            "Desh Travels"});
            this.BusNmCMbox.Location = new System.Drawing.Point(336, 98);
            this.BusNmCMbox.Name = "BusNmCMbox";
            this.BusNmCMbox.Size = new System.Drawing.Size(192, 21);
            this.BusNmCMbox.TabIndex = 2;
            this.BusNmCMbox.SelectedIndexChanged += new System.EventHandler(this.BusNmbox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BusSltL
            // 
            this.BusSltL.AutoSize = true;
            this.BusSltL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusSltL.ForeColor = System.Drawing.Color.Crimson;
            this.BusSltL.Location = new System.Drawing.Point(331, 37);
            this.BusSltL.Name = "BusSltL";
            this.BusSltL.Size = new System.Drawing.Size(138, 29);
            this.BusSltL.TabIndex = 5;
            this.BusSltL.Text = "Select Bus";
            // 
            // BackB
            // 
            this.BackB.ForeColor = System.Drawing.Color.Crimson;
            this.BackB.Location = new System.Drawing.Point(336, 220);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(75, 23);
            this.BackB.TabIndex = 6;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // NextB
            // 
            this.NextB.ForeColor = System.Drawing.Color.Green;
            this.NextB.Location = new System.Drawing.Point(453, 220);
            this.NextB.Name = "NextB";
            this.NextB.Size = new System.Drawing.Size(75, 23);
            this.NextB.TabIndex = 8;
            this.NextB.Text = "Next";
            this.NextB.UseVisualStyleBackColor = true;
            this.NextB.Click += new System.EventHandler(this.NextB_Click);
            // 
            // BusTypeL
            // 
            this.BusTypeL.AutoSize = true;
            this.BusTypeL.Location = new System.Drawing.Point(253, 135);
            this.BusTypeL.Name = "BusTypeL";
            this.BusTypeL.Size = new System.Drawing.Size(52, 13);
            this.BusTypeL.TabIndex = 9;
            this.BusTypeL.Text = "Bus Type";
            // 
            // BusTypeCMbox
            // 
            this.BusTypeCMbox.FormattingEnabled = true;
            this.BusTypeCMbox.Items.AddRange(new object[] {
            "AC",
            "Non AC"});
            this.BusTypeCMbox.Location = new System.Drawing.Point(336, 132);
            this.BusTypeCMbox.Name = "BusTypeCMbox";
            this.BusTypeCMbox.Size = new System.Drawing.Size(192, 21);
            this.BusTypeCMbox.TabIndex = 10;
            this.BusTypeCMbox.SelectedIndexChanged += new System.EventHandler(this.BusTypeCMbox_SelectedIndexChanged);
            // 
            // TravelTmL
            // 
            this.TravelTmL.AutoSize = true;
            this.TravelTmL.Location = new System.Drawing.Point(253, 170);
            this.TravelTmL.Name = "TravelTmL";
            this.TravelTmL.Size = new System.Drawing.Size(77, 13);
            this.TravelTmL.TabIndex = 1;
            this.TravelTmL.Text = "Traveling Time";
            this.TravelTmL.Click += new System.EventHandler(this.TravelTmL_Click);
            // 
            // TravelTimeCMbox
            // 
            this.TravelTimeCMbox.FormattingEnabled = true;
            this.TravelTimeCMbox.Items.AddRange(new object[] {
            "7:00  AM",
            "8:00  AM",
            "9:00  AM",
            "10:00  AM",
            "11:00  AM",
            "12:00  PM",
            "1:00  PM",
            "2:00  PM",
            "3:00  PM",
            "4:00  PM",
            "5:00  PM",
            "6:00  PM",
            "7:00  PM",
            "8:00  PM",
            "9:00  PM",
            "10:00  PM",
            "11:00  PM",
            "12:00  AM"});
            this.TravelTimeCMbox.Location = new System.Drawing.Point(336, 167);
            this.TravelTimeCMbox.Name = "TravelTimeCMbox";
            this.TravelTimeCMbox.Size = new System.Drawing.Size(192, 21);
            this.TravelTimeCMbox.TabIndex = 11;
            // 
            // SelectBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(572, 275);
            this.Controls.Add(this.TravelTimeCMbox);
            this.Controls.Add(this.BusTypeCMbox);
            this.Controls.Add(this.BusTypeL);
            this.Controls.Add(this.NextB);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.BusSltL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BusNmCMbox);
            this.Controls.Add(this.TravelTmL);
            this.Controls.Add(this.BusNmL);
            this.Name = "SelectBus";
            this.Text = "SelectBus";
            this.Load += new System.EventHandler(this.SelectBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BusNmL;
        private System.Windows.Forms.ComboBox BusNmCMbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BusSltL;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Button NextB;
        private System.Windows.Forms.Label BusTypeL;
        private System.Windows.Forms.ComboBox BusTypeCMbox;
        private System.Windows.Forms.Label TravelTmL;
        private System.Windows.Forms.ComboBox TravelTimeCMbox;
    }
}