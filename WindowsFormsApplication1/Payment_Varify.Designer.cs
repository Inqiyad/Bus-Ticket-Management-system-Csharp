namespace WindowsFormsApplication1
{
    partial class Payment_Varify
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
            this.AmToPayL = new System.Windows.Forms.Label();
            this.MerchantNoL = new System.Windows.Forms.Label();
            this.AmPaybox = new System.Windows.Forms.TextBox();
            this.MerchantNobox = new System.Windows.Forms.TextBox();
            this.paymentvrL = new System.Windows.Forms.Label();
            this.BackB = new System.Windows.Forms.Button();
            this.LogoutB = new System.Windows.Forms.Button();
            this.UserNameL = new System.Windows.Forms.Label();
            this.UNbox = new System.Windows.Forms.TextBox();
            this.ConfirmreservationB = new System.Windows.Forms.Button();
            this.ConfirmationL = new System.Windows.Forms.Label();
            this.ReferBox = new System.Windows.Forms.TextBox();
            this.ReffL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmToPayL
            // 
            this.AmToPayL.AutoSize = true;
            this.AmToPayL.Location = new System.Drawing.Point(161, 87);
            this.AmToPayL.Name = "AmToPayL";
            this.AmToPayL.Size = new System.Drawing.Size(80, 13);
            this.AmToPayL.TabIndex = 0;
            this.AmToPayL.Text = "Amount To Pay";
            // 
            // MerchantNoL
            // 
            this.MerchantNoL.AutoSize = true;
            this.MerchantNoL.Location = new System.Drawing.Point(161, 117);
            this.MerchantNoL.Name = "MerchantNoL";
            this.MerchantNoL.Size = new System.Drawing.Size(69, 13);
            this.MerchantNoL.TabIndex = 2;
            this.MerchantNoL.Text = "Merchant No";
            // 
            // AmPaybox
            // 
            this.AmPaybox.Enabled = false;
            this.AmPaybox.Location = new System.Drawing.Point(265, 84);
            this.AmPaybox.Name = "AmPaybox";
            this.AmPaybox.ReadOnly = true;
            this.AmPaybox.Size = new System.Drawing.Size(159, 20);
            this.AmPaybox.TabIndex = 3;
            // 
            // MerchantNobox
            // 
            this.MerchantNobox.Enabled = false;
            this.MerchantNobox.Location = new System.Drawing.Point(265, 113);
            this.MerchantNobox.Name = "MerchantNobox";
            this.MerchantNobox.ReadOnly = true;
            this.MerchantNobox.Size = new System.Drawing.Size(159, 20);
            this.MerchantNobox.TabIndex = 5;
            this.MerchantNobox.TextChanged += new System.EventHandler(this.MerchantNobox_TextChanged);
            // 
            // paymentvrL
            // 
            this.paymentvrL.AutoSize = true;
            this.paymentvrL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentvrL.Location = new System.Drawing.Point(133, 25);
            this.paymentvrL.Name = "paymentvrL";
            this.paymentvrL.Size = new System.Drawing.Size(307, 29);
            this.paymentvrL.TabIndex = 8;
            this.paymentvrL.Text = "Reservation Confirmation";
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(148, 217);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(75, 36);
            this.BackB.TabIndex = 10;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // LogoutB
            // 
            this.LogoutB.Location = new System.Drawing.Point(349, 217);
            this.LogoutB.Name = "LogoutB";
            this.LogoutB.Size = new System.Drawing.Size(75, 36);
            this.LogoutB.TabIndex = 11;
            this.LogoutB.Text = "Logout";
            this.LogoutB.UseVisualStyleBackColor = true;
            this.LogoutB.Click += new System.EventHandler(this.LogoutB_Click);
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Location = new System.Drawing.Point(163, 150);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(60, 13);
            this.UserNameL.TabIndex = 12;
            this.UserNameL.Text = "User Name";
            // 
            // UNbox
            // 
            this.UNbox.Enabled = false;
            this.UNbox.Location = new System.Drawing.Point(265, 143);
            this.UNbox.Name = "UNbox";
            this.UNbox.ReadOnly = true;
            this.UNbox.Size = new System.Drawing.Size(159, 20);
            this.UNbox.TabIndex = 13;
            // 
            // ConfirmreservationB
            // 
            this.ConfirmreservationB.Location = new System.Drawing.Point(245, 217);
            this.ConfirmreservationB.Name = "ConfirmreservationB";
            this.ConfirmreservationB.Size = new System.Drawing.Size(83, 36);
            this.ConfirmreservationB.TabIndex = 14;
            this.ConfirmreservationB.Text = "Confirm Reservation";
            this.ConfirmreservationB.UseVisualStyleBackColor = true;
            this.ConfirmreservationB.Click += new System.EventHandler(this.ConfirmreservationB_Click);
            // 
            // ConfirmationL
            // 
            this.ConfirmationL.AutoSize = true;
            this.ConfirmationL.Location = new System.Drawing.Point(46, 290);
            this.ConfirmationL.Name = "ConfirmationL";
            this.ConfirmationL.Size = new System.Drawing.Size(93, 13);
            this.ConfirmationL.TabIndex = 15;
            this.ConfirmationL.Text = "Not Confirmed Yet";
            this.ConfirmationL.Visible = false;
            // 
            // ReferBox
            // 
            this.ReferBox.Enabled = false;
            this.ReferBox.Location = new System.Drawing.Point(265, 173);
            this.ReferBox.Name = "ReferBox";
            this.ReferBox.ReadOnly = true;
            this.ReferBox.Size = new System.Drawing.Size(159, 20);
            this.ReferBox.TabIndex = 17;
            // 
            // ReffL
            // 
            this.ReffL.AutoSize = true;
            this.ReffL.Location = new System.Drawing.Point(163, 180);
            this.ReffL.Name = "ReffL";
            this.ReffL.Size = new System.Drawing.Size(41, 13);
            this.ReffL.TabIndex = 16;
            this.ReffL.Text = "Ref No";
            // 
            // Payment_Varify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(571, 355);
            this.Controls.Add(this.ReferBox);
            this.Controls.Add(this.ReffL);
            this.Controls.Add(this.ConfirmationL);
            this.Controls.Add(this.ConfirmreservationB);
            this.Controls.Add(this.UNbox);
            this.Controls.Add(this.UserNameL);
            this.Controls.Add(this.LogoutB);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.paymentvrL);
            this.Controls.Add(this.MerchantNobox);
            this.Controls.Add(this.AmPaybox);
            this.Controls.Add(this.MerchantNoL);
            this.Controls.Add(this.AmToPayL);
            this.Name = "Payment_Varify";
            this.Text = "Payment_Varify";
            this.Load += new System.EventHandler(this.Payment_Varify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmToPayL;
        private System.Windows.Forms.Label MerchantNoL;
        private System.Windows.Forms.TextBox AmPaybox;
        private System.Windows.Forms.TextBox MerchantNobox;
        private System.Windows.Forms.Label paymentvrL;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Button LogoutB;
        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.TextBox UNbox;
        private System.Windows.Forms.Button ConfirmreservationB;
        private System.Windows.Forms.Label ConfirmationL;
        private System.Windows.Forms.TextBox ReferBox;
        private System.Windows.Forms.Label ReffL;
    }
}