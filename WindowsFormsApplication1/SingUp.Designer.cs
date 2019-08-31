namespace WindowsFormsApplication1
{
    partial class SingUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingUp));
            this.NameL = new System.Windows.Forms.Label();
            this.UNL = new System.Windows.Forms.Label();
            this.CheckL = new System.Windows.Forms.Label();
            this.PhoneL = new System.Windows.Forms.Label();
            this.AddressL = new System.Windows.Forms.Label();
            this.EmailL = new System.Windows.Forms.Label();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Emailbox = new System.Windows.Forms.TextBox();
            this.UNbox = new System.Windows.Forms.TextBox();
            this.CreateB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.PhNobox = new System.Windows.Forms.TextBox();
            this.PWbox = new System.Windows.Forms.TextBox();
            this.Addressbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignUpL = new System.Windows.Forms.Label();
            this.CheckAvailableB = new System.Windows.Forms.Button();
            this.checkavlblL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(284, 143);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(54, 13);
            this.NameL.TabIndex = 0;
            this.NameL.Text = "Full Name";
            // 
            // UNL
            // 
            this.UNL.AutoSize = true;
            this.UNL.Location = new System.Drawing.Point(284, 78);
            this.UNL.Name = "UNL";
            this.UNL.Size = new System.Drawing.Size(60, 13);
            this.UNL.TabIndex = 1;
            this.UNL.Text = "User Name";
            // 
            // CheckL
            // 
            this.CheckL.AutoSize = true;
            this.CheckL.Location = new System.Drawing.Point(489, 110);
            this.CheckL.Name = "CheckL";
            this.CheckL.Size = new System.Drawing.Size(56, 13);
            this.CheckL.TabIndex = 3;
            this.CheckL.Text = "Available!!";
            this.CheckL.Visible = false;
            this.CheckL.Click += new System.EventHandler(this.CheckL_Click);
            // 
            // PhoneL
            // 
            this.PhoneL.AutoSize = true;
            this.PhoneL.Location = new System.Drawing.Point(284, 247);
            this.PhoneL.Name = "PhoneL";
            this.PhoneL.Size = new System.Drawing.Size(55, 13);
            this.PhoneL.TabIndex = 4;
            this.PhoneL.Text = "Phone No";
            // 
            // AddressL
            // 
            this.AddressL.AutoSize = true;
            this.AddressL.Location = new System.Drawing.Point(284, 282);
            this.AddressL.Name = "AddressL";
            this.AddressL.Size = new System.Drawing.Size(45, 13);
            this.AddressL.TabIndex = 5;
            this.AddressL.Text = "Address";
            // 
            // EmailL
            // 
            this.EmailL.AutoSize = true;
            this.EmailL.Location = new System.Drawing.Point(284, 178);
            this.EmailL.Name = "EmailL";
            this.EmailL.Size = new System.Drawing.Size(73, 13);
            this.EmailL.TabIndex = 6;
            this.EmailL.Text = "Email Address";
            // 
            // Namebox
            // 
            this.Namebox.Enabled = false;
            this.Namebox.Location = new System.Drawing.Point(379, 140);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(222, 20);
            this.Namebox.TabIndex = 7;
            // 
            // Emailbox
            // 
            this.Emailbox.Enabled = false;
            this.Emailbox.Location = new System.Drawing.Point(379, 175);
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.Size = new System.Drawing.Size(222, 20);
            this.Emailbox.TabIndex = 11;
            // 
            // UNbox
            // 
            this.UNbox.Location = new System.Drawing.Point(379, 75);
            this.UNbox.Name = "UNbox";
            this.UNbox.Size = new System.Drawing.Size(222, 20);
            this.UNbox.TabIndex = 12;
            // 
            // CreateB
            // 
            this.CreateB.ForeColor = System.Drawing.Color.Green;
            this.CreateB.Location = new System.Drawing.Point(379, 351);
            this.CreateB.Name = "CreateB";
            this.CreateB.Size = new System.Drawing.Size(75, 23);
            this.CreateB.TabIndex = 13;
            this.CreateB.Text = "Create";
            this.CreateB.UseVisualStyleBackColor = true;
            this.CreateB.Visible = false;
            this.CreateB.Click += new System.EventHandler(this.CreateB_Click);
            // 
            // CancelB
            // 
            this.CancelB.ForeColor = System.Drawing.Color.Crimson;
            this.CancelB.Location = new System.Drawing.Point(526, 351);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 14;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // PhNobox
            // 
            this.PhNobox.Enabled = false;
            this.PhNobox.Location = new System.Drawing.Point(379, 244);
            this.PhNobox.Name = "PhNobox";
            this.PhNobox.Size = new System.Drawing.Size(222, 20);
            this.PhNobox.TabIndex = 15;
            // 
            // PWbox
            // 
            this.PWbox.Enabled = false;
            this.PWbox.Location = new System.Drawing.Point(379, 210);
            this.PWbox.Name = "PWbox";
            this.PWbox.Size = new System.Drawing.Size(222, 20);
            this.PWbox.TabIndex = 17;
            // 
            // Addressbox
            // 
            this.Addressbox.Enabled = false;
            this.Addressbox.Location = new System.Drawing.Point(379, 279);
            this.Addressbox.Multiline = true;
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.Size = new System.Drawing.Size(222, 43);
            this.Addressbox.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignUpL
            // 
            this.SignUpL.AutoSize = true;
            this.SignUpL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SignUpL.Location = new System.Drawing.Point(376, 20);
            this.SignUpL.Name = "SignUpL";
            this.SignUpL.Size = new System.Drawing.Size(125, 33);
            this.SignUpL.TabIndex = 20;
            this.SignUpL.Text = "Sign Up";
            // 
            // CheckAvailableB
            // 
            this.CheckAvailableB.ForeColor = System.Drawing.Color.Green;
            this.CheckAvailableB.Location = new System.Drawing.Point(379, 105);
            this.CheckAvailableB.Name = "CheckAvailableB";
            this.CheckAvailableB.Size = new System.Drawing.Size(104, 23);
            this.CheckAvailableB.TabIndex = 21;
            this.CheckAvailableB.Text = "Check Availability";
            this.CheckAvailableB.UseVisualStyleBackColor = true;
            this.CheckAvailableB.Click += new System.EventHandler(this.CheckAvailableB_Click);
            // 
            // checkavlblL
            // 
            this.checkavlblL.AutoSize = true;
            this.checkavlblL.Location = new System.Drawing.Point(501, 110);
            this.checkavlblL.Name = "checkavlblL";
            this.checkavlblL.Size = new System.Drawing.Size(0, 13);
            this.checkavlblL.TabIndex = 22;
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Location = new System.Drawing.Point(284, 213);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(53, 13);
            this.PasswordL.TabIndex = 23;
            this.PasswordL.Text = "Password";
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(643, 418);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.checkavlblL);
            this.Controls.Add(this.CheckAvailableB);
            this.Controls.Add(this.SignUpL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Addressbox);
            this.Controls.Add(this.PWbox);
            this.Controls.Add(this.PhNobox);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.CreateB);
            this.Controls.Add(this.UNbox);
            this.Controls.Add(this.Emailbox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.EmailL);
            this.Controls.Add(this.AddressL);
            this.Controls.Add(this.PhoneL);
            this.Controls.Add(this.CheckL);
            this.Controls.Add(this.UNL);
            this.Controls.Add(this.NameL);
            this.Name = "SingUp";
            this.Text = "SingUp";
            this.Load += new System.EventHandler(this.SingUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label UNL;
        private System.Windows.Forms.Label CheckL;
        private System.Windows.Forms.Label PhoneL;
        private System.Windows.Forms.Label AddressL;
        private System.Windows.Forms.Label EmailL;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox Emailbox;
        private System.Windows.Forms.TextBox UNbox;
        private System.Windows.Forms.Button CreateB;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.TextBox PhNobox;
        private System.Windows.Forms.TextBox PWbox;
        private System.Windows.Forms.TextBox Addressbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SignUpL;
        private System.Windows.Forms.Button CheckAvailableB;
        private System.Windows.Forms.Label checkavlblL;
        private System.Windows.Forms.Label PasswordL;
    }
}