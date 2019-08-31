namespace WindowsFormsApplication1
{
    partial class ForgetPWpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPWpage));
            this.UnL = new System.Windows.Forms.Label();
            this.PhoneNoRB = new System.Windows.Forms.RadioButton();
            this.EmailRB = new System.Windows.Forms.RadioButton();
            this.UNbox = new System.Windows.Forms.TextBox();
            this.Emailbox = new System.Windows.Forms.TextBox();
            this.SubmitB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhoneNobox = new System.Windows.Forms.TextBox();
            this.CancelB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoL = new System.Windows.Forms.Label();
            this.InfoL2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UnL
            // 
            this.UnL.AutoSize = true;
            this.UnL.Location = new System.Drawing.Point(319, 117);
            this.UnL.Name = "UnL";
            this.UnL.Size = new System.Drawing.Size(60, 13);
            this.UnL.TabIndex = 0;
            this.UnL.Text = "User Name";
            // 
            // PhoneNoRB
            // 
            this.PhoneNoRB.AutoSize = true;
            this.PhoneNoRB.Location = new System.Drawing.Point(322, 155);
            this.PhoneNoRB.Name = "PhoneNoRB";
            this.PhoneNoRB.Size = new System.Drawing.Size(73, 17);
            this.PhoneNoRB.TabIndex = 3;
            this.PhoneNoRB.Text = "Phone No";
            this.PhoneNoRB.UseVisualStyleBackColor = true;
            this.PhoneNoRB.CheckedChanged += new System.EventHandler(this.PhoneNoRB_CheckedChanged);
            // 
            // EmailRB
            // 
            this.EmailRB.AutoSize = true;
            this.EmailRB.Location = new System.Drawing.Point(322, 187);
            this.EmailRB.Name = "EmailRB";
            this.EmailRB.Size = new System.Drawing.Size(50, 17);
            this.EmailRB.TabIndex = 4;
            this.EmailRB.Text = "Email";
            this.EmailRB.UseVisualStyleBackColor = true;
            this.EmailRB.CheckedChanged += new System.EventHandler(this.EmailRB_CheckedChanged);
            // 
            // UNbox
            // 
            this.UNbox.Location = new System.Drawing.Point(401, 114);
            this.UNbox.Name = "UNbox";
            this.UNbox.Size = new System.Drawing.Size(185, 20);
            this.UNbox.TabIndex = 5;
            // 
            // Emailbox
            // 
            this.Emailbox.Enabled = false;
            this.Emailbox.Location = new System.Drawing.Point(401, 187);
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.Size = new System.Drawing.Size(185, 20);
            this.Emailbox.TabIndex = 7;
            // 
            // SubmitB
            // 
            this.SubmitB.ForeColor = System.Drawing.Color.Green;
            this.SubmitB.Location = new System.Drawing.Point(511, 232);
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.Size = new System.Drawing.Size(75, 23);
            this.SubmitB.TabIndex = 8;
            this.SubmitB.Text = "Submit";
            this.SubmitB.UseVisualStyleBackColor = true;
            this.SubmitB.Click += new System.EventHandler(this.SubmitB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PhoneNobox
            // 
            this.PhoneNobox.Enabled = false;
            this.PhoneNobox.Location = new System.Drawing.Point(401, 152);
            this.PhoneNobox.Name = "PhoneNobox";
            this.PhoneNobox.Size = new System.Drawing.Size(185, 20);
            this.PhoneNobox.TabIndex = 10;
            // 
            // CancelB
            // 
            this.CancelB.ForeColor = System.Drawing.Color.Red;
            this.CancelB.Location = new System.Drawing.Point(401, 232);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 11;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(341, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recover Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InfoL
            // 
            this.InfoL.AutoSize = true;
            this.InfoL.Location = new System.Drawing.Point(334, 62);
            this.InfoL.Name = "InfoL";
            this.InfoL.Size = new System.Drawing.Size(252, 26);
            this.InfoL.TabIndex = 13;
            this.InfoL.Text = "Enter your registered User Name and also give your \r\n\r\n";
            this.InfoL.Click += new System.EventHandler(this.InfoL_Click);
            // 
            // InfoL2
            // 
            this.InfoL2.AutoSize = true;
            this.InfoL2.Location = new System.Drawing.Point(335, 82);
            this.InfoL2.Name = "InfoL2";
            this.InfoL2.Size = new System.Drawing.Size(136, 13);
            this.InfoL2.TabIndex = 14;
            this.InfoL2.Text = "Phone No or Email Address";
            // 
            // ForgetPWpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(615, 280);
            this.Controls.Add(this.InfoL2);
            this.Controls.Add(this.InfoL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.PhoneNobox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SubmitB);
            this.Controls.Add(this.Emailbox);
            this.Controls.Add(this.UNbox);
            this.Controls.Add(this.EmailRB);
            this.Controls.Add(this.PhoneNoRB);
            this.Controls.Add(this.UnL);
            this.Name = "ForgetPWpage";
            this.Text = "ForgetPWpage";
            this.Load += new System.EventHandler(this.ForgetPWpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UnL;
        private System.Windows.Forms.RadioButton PhoneNoRB;
        private System.Windows.Forms.RadioButton EmailRB;
        private System.Windows.Forms.TextBox UNbox;
        private System.Windows.Forms.TextBox Emailbox;
        private System.Windows.Forms.Button SubmitB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PhoneNobox;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoL;
        private System.Windows.Forms.Label InfoL2;
    }
}