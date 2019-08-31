namespace WindowsFormsApplication1
{
    partial class PassengerProfile
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
            this.ProfileL = new System.Windows.Forms.Label();
            this.Addressbox = new System.Windows.Forms.TextBox();
            this.PhNobox = new System.Windows.Forms.TextBox();
            this.BackB = new System.Windows.Forms.Button();
            this.UNbox = new System.Windows.Forms.TextBox();
            this.Emailbox = new System.Windows.Forms.TextBox();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.EmailL = new System.Windows.Forms.Label();
            this.AddressL = new System.Windows.Forms.Label();
            this.PhoneL = new System.Windows.Forms.Label();
            this.NewPWL = new System.Windows.Forms.Label();
            this.UNL = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.Label();
            this.NewPWBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditB = new System.Windows.Forms.Button();
            this.confirmPWbox = new System.Windows.Forms.TextBox();
            this.ConfirmPWL = new System.Windows.Forms.Label();
            this.CancelB = new System.Windows.Forms.Button();
            this.FNSaveB = new System.Windows.Forms.Button();
            this.EASaveB = new System.Windows.Forms.Button();
            this.PWSaveB = new System.Windows.Forms.Button();
            this.PNSaveB = new System.Windows.Forms.Button();
            this.AdrsSaveB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileL
            // 
            this.ProfileL.AutoSize = true;
            this.ProfileL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ProfileL.Location = new System.Drawing.Point(227, 24);
            this.ProfileL.Name = "ProfileL";
            this.ProfileL.Size = new System.Drawing.Size(262, 33);
            this.ProfileL.TabIndex = 36;
            this.ProfileL.Text = "Passenger Profile";
            // 
            // Addressbox
            // 
            this.Addressbox.Enabled = false;
            this.Addressbox.Location = new System.Drawing.Point(468, 338);
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.Size = new System.Drawing.Size(222, 20);
            this.Addressbox.TabIndex = 34;
            this.Addressbox.TextChanged += new System.EventHandler(this.Addressbox_TextChanged);
            // 
            // PhNobox
            // 
            this.PhNobox.Enabled = false;
            this.PhNobox.Location = new System.Drawing.Point(468, 279);
            this.PhNobox.Name = "PhNobox";
            this.PhNobox.Size = new System.Drawing.Size(222, 20);
            this.PhNobox.TabIndex = 32;
            this.PhNobox.TextChanged += new System.EventHandler(this.PhNobox_TextChanged);
            // 
            // BackB
            // 
            this.BackB.ForeColor = System.Drawing.Color.Black;
            this.BackB.Location = new System.Drawing.Point(174, 364);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(75, 23);
            this.BackB.TabIndex = 30;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // UNbox
            // 
            this.UNbox.Enabled = false;
            this.UNbox.Location = new System.Drawing.Point(107, 253);
            this.UNbox.Name = "UNbox";
            this.UNbox.ReadOnly = true;
            this.UNbox.Size = new System.Drawing.Size(222, 20);
            this.UNbox.TabIndex = 29;
            // 
            // Emailbox
            // 
            this.Emailbox.Enabled = false;
            this.Emailbox.Location = new System.Drawing.Point(107, 299);
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.Size = new System.Drawing.Size(222, 20);
            this.Emailbox.TabIndex = 28;
            this.Emailbox.TextChanged += new System.EventHandler(this.Emailbox_TextChanged);
            // 
            // Namebox
            // 
            this.Namebox.Enabled = false;
            this.Namebox.Location = new System.Drawing.Point(107, 197);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(222, 20);
            this.Namebox.TabIndex = 27;
            this.Namebox.TextChanged += new System.EventHandler(this.Namebox_TextChanged);
            // 
            // EmailL
            // 
            this.EmailL.AutoSize = true;
            this.EmailL.Location = new System.Drawing.Point(28, 302);
            this.EmailL.Name = "EmailL";
            this.EmailL.Size = new System.Drawing.Size(73, 13);
            this.EmailL.TabIndex = 26;
            this.EmailL.Text = "Email Address";
            // 
            // AddressL
            // 
            this.AddressL.AutoSize = true;
            this.AddressL.Location = new System.Drawing.Point(375, 341);
            this.AddressL.Name = "AddressL";
            this.AddressL.Size = new System.Drawing.Size(45, 13);
            this.AddressL.TabIndex = 25;
            this.AddressL.Text = "Address";
            // 
            // PhoneL
            // 
            this.PhoneL.AutoSize = true;
            this.PhoneL.Location = new System.Drawing.Point(375, 282);
            this.PhoneL.Name = "PhoneL";
            this.PhoneL.Size = new System.Drawing.Size(55, 13);
            this.PhoneL.TabIndex = 24;
            this.PhoneL.Text = "Phone No";
            // 
            // NewPWL
            // 
            this.NewPWL.AutoSize = true;
            this.NewPWL.Location = new System.Drawing.Point(372, 192);
            this.NewPWL.Name = "NewPWL";
            this.NewPWL.Size = new System.Drawing.Size(78, 13);
            this.NewPWL.TabIndex = 23;
            this.NewPWL.Text = "New Password";
            this.NewPWL.Click += new System.EventHandler(this.NewPWL_Click);
            // 
            // UNL
            // 
            this.UNL.AutoSize = true;
            this.UNL.Location = new System.Drawing.Point(28, 256);
            this.UNL.Name = "UNL";
            this.UNL.Size = new System.Drawing.Size(60, 13);
            this.UNL.TabIndex = 22;
            this.UNL.Text = "User Name";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(28, 200);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(54, 13);
            this.NameL.TabIndex = 21;
            this.NameL.Text = "Full Name";
            // 
            // NewPWBox
            // 
            this.NewPWBox.Enabled = false;
            this.NewPWBox.Location = new System.Drawing.Point(468, 189);
            this.NewPWBox.Name = "NewPWBox";
            this.NewPWBox.PasswordChar = '*';
            this.NewPWBox.Size = new System.Drawing.Size(222, 20);
            this.NewPWBox.TabIndex = 39;
            this.NewPWBox.TextChanged += new System.EventHandler(this.NewPWBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 63);
            this.dataGridView1.TabIndex = 40;
            // 
            // EditB
            // 
            this.EditB.ForeColor = System.Drawing.Color.Black;
            this.EditB.Location = new System.Drawing.Point(93, 364);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(75, 23);
            this.EditB.TabIndex = 41;
            this.EditB.Text = "Edit";
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // confirmPWbox
            // 
            this.confirmPWbox.Enabled = false;
            this.confirmPWbox.Location = new System.Drawing.Point(468, 218);
            this.confirmPWbox.Name = "confirmPWbox";
            this.confirmPWbox.PasswordChar = '*';
            this.confirmPWbox.Size = new System.Drawing.Size(222, 20);
            this.confirmPWbox.TabIndex = 43;
            this.confirmPWbox.TextChanged += new System.EventHandler(this.confirmPWbox_TextChanged);
            // 
            // ConfirmPWL
            // 
            this.ConfirmPWL.AutoSize = true;
            this.ConfirmPWL.Location = new System.Drawing.Point(372, 221);
            this.ConfirmPWL.Name = "ConfirmPWL";
            this.ConfirmPWL.Size = new System.Drawing.Size(91, 13);
            this.ConfirmPWL.TabIndex = 42;
            this.ConfirmPWL.Text = "Confirm Password";
            // 
            // CancelB
            // 
            this.CancelB.ForeColor = System.Drawing.Color.Black;
            this.CancelB.Location = new System.Drawing.Point(255, 364);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 44;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Visible = false;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // FNSaveB
            // 
            this.FNSaveB.Enabled = false;
            this.FNSaveB.ForeColor = System.Drawing.Color.Green;
            this.FNSaveB.Location = new System.Drawing.Point(254, 219);
            this.FNSaveB.Name = "FNSaveB";
            this.FNSaveB.Size = new System.Drawing.Size(75, 23);
            this.FNSaveB.TabIndex = 45;
            this.FNSaveB.Text = "Save";
            this.FNSaveB.UseVisualStyleBackColor = true;
            this.FNSaveB.Click += new System.EventHandler(this.FNSaveB_Click);
            // 
            // EASaveB
            // 
            this.EASaveB.Enabled = false;
            this.EASaveB.ForeColor = System.Drawing.Color.Green;
            this.EASaveB.Location = new System.Drawing.Point(254, 325);
            this.EASaveB.Name = "EASaveB";
            this.EASaveB.Size = new System.Drawing.Size(75, 23);
            this.EASaveB.TabIndex = 46;
            this.EASaveB.Text = "Save";
            this.EASaveB.UseVisualStyleBackColor = true;
            this.EASaveB.Click += new System.EventHandler(this.EASaveB_Click);
            // 
            // PWSaveB
            // 
            this.PWSaveB.Enabled = false;
            this.PWSaveB.ForeColor = System.Drawing.Color.Green;
            this.PWSaveB.Location = new System.Drawing.Point(615, 245);
            this.PWSaveB.Name = "PWSaveB";
            this.PWSaveB.Size = new System.Drawing.Size(75, 23);
            this.PWSaveB.TabIndex = 47;
            this.PWSaveB.Text = "Save";
            this.PWSaveB.UseVisualStyleBackColor = true;
            this.PWSaveB.Click += new System.EventHandler(this.PWSaveB_Click);
            // 
            // PNSaveB
            // 
            this.PNSaveB.Enabled = false;
            this.PNSaveB.ForeColor = System.Drawing.Color.Green;
            this.PNSaveB.Location = new System.Drawing.Point(615, 305);
            this.PNSaveB.Name = "PNSaveB";
            this.PNSaveB.Size = new System.Drawing.Size(75, 23);
            this.PNSaveB.TabIndex = 48;
            this.PNSaveB.Text = "Save";
            this.PNSaveB.UseVisualStyleBackColor = true;
            this.PNSaveB.Click += new System.EventHandler(this.PNSaveB_Click);
            // 
            // AdrsSaveB
            // 
            this.AdrsSaveB.Enabled = false;
            this.AdrsSaveB.ForeColor = System.Drawing.Color.Green;
            this.AdrsSaveB.Location = new System.Drawing.Point(615, 364);
            this.AdrsSaveB.Name = "AdrsSaveB";
            this.AdrsSaveB.Size = new System.Drawing.Size(75, 23);
            this.AdrsSaveB.TabIndex = 49;
            this.AdrsSaveB.Text = "Save";
            this.AdrsSaveB.UseVisualStyleBackColor = true;
            this.AdrsSaveB.Click += new System.EventHandler(this.AdrsSaveB_Click);
            // 
            // PassengerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(730, 425);
            this.Controls.Add(this.AdrsSaveB);
            this.Controls.Add(this.PNSaveB);
            this.Controls.Add(this.PWSaveB);
            this.Controls.Add(this.EASaveB);
            this.Controls.Add(this.FNSaveB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.confirmPWbox);
            this.Controls.Add(this.ConfirmPWL);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewPWBox);
            this.Controls.Add(this.ProfileL);
            this.Controls.Add(this.Addressbox);
            this.Controls.Add(this.PhNobox);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.UNbox);
            this.Controls.Add(this.Emailbox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.EmailL);
            this.Controls.Add(this.AddressL);
            this.Controls.Add(this.PhoneL);
            this.Controls.Add(this.NewPWL);
            this.Controls.Add(this.UNL);
            this.Controls.Add(this.NameL);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PassengerProfile";
            this.Text = "PassengerProfile";
            this.Load += new System.EventHandler(this.PassengerProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfileL;
        private System.Windows.Forms.TextBox Addressbox;
        private System.Windows.Forms.TextBox PhNobox;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.TextBox UNbox;
        private System.Windows.Forms.TextBox Emailbox;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label EmailL;
        private System.Windows.Forms.Label AddressL;
        private System.Windows.Forms.Label PhoneL;
        private System.Windows.Forms.Label NewPWL;
        private System.Windows.Forms.Label UNL;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.TextBox NewPWBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.TextBox confirmPWbox;
        private System.Windows.Forms.Label ConfirmPWL;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button FNSaveB;
        private System.Windows.Forms.Button EASaveB;
        private System.Windows.Forms.Button PWSaveB;
        private System.Windows.Forms.Button PNSaveB;
        private System.Windows.Forms.Button AdrsSaveB;
    }
}