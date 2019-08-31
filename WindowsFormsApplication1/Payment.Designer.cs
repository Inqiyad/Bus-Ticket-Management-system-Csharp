namespace WindowsFormsApplication1
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.PayOpL = new System.Windows.Forms.Label();
            this.TotalAmountbox = new System.Windows.Forms.TextBox();
            this.TotalAmountL = new System.Windows.Forms.Label();
            this.ContinueB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaymentL = new System.Windows.Forms.Label();
            this.bKashRB = new System.Windows.Forms.RadioButton();
            this.NexusPayRB = new System.Windows.Forms.RadioButton();
            this.RocketRB = new System.Windows.Forms.RadioButton();
            this.TicketPriceL = new System.Windows.Forms.Label();
            this.BusologyFeeL = new System.Windows.Forms.Label();
            this.Busologybox = new System.Windows.Forms.TextBox();
            this.TicketPricebox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.UNbox = new System.Windows.Forms.TextBox();
            this.UserNnL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PayOpL
            // 
            this.PayOpL.AutoSize = true;
            this.PayOpL.Location = new System.Drawing.Point(263, 218);
            this.PayOpL.Name = "PayOpL";
            this.PayOpL.Size = new System.Drawing.Size(88, 13);
            this.PayOpL.TabIndex = 0;
            this.PayOpL.Text = "Payment Option :";
            // 
            // TotalAmountbox
            // 
            this.TotalAmountbox.Enabled = false;
            this.TotalAmountbox.Location = new System.Drawing.Point(354, 140);
            this.TotalAmountbox.Name = "TotalAmountbox";
            this.TotalAmountbox.ReadOnly = true;
            this.TotalAmountbox.Size = new System.Drawing.Size(175, 20);
            this.TotalAmountbox.TabIndex = 2;
            // 
            // TotalAmountL
            // 
            this.TotalAmountL.AutoSize = true;
            this.TotalAmountL.Location = new System.Drawing.Point(263, 143);
            this.TotalAmountL.Name = "TotalAmountL";
            this.TotalAmountL.Size = new System.Drawing.Size(70, 13);
            this.TotalAmountL.TabIndex = 3;
            this.TotalAmountL.Text = "Total Amount";
            // 
            // ContinueB
            // 
            this.ContinueB.Location = new System.Drawing.Point(454, 293);
            this.ContinueB.Name = "ContinueB";
            this.ContinueB.Size = new System.Drawing.Size(75, 23);
            this.ContinueB.TabIndex = 4;
            this.ContinueB.Text = "Continue";
            this.ContinueB.UseVisualStyleBackColor = true;
            this.ContinueB.Click += new System.EventHandler(this.ContinueB_Click);
            // 
            // CancelB
            // 
            this.CancelB.Location = new System.Drawing.Point(373, 293);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 5;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentL
            // 
            this.PaymentL.AutoSize = true;
            this.PaymentL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentL.Location = new System.Drawing.Point(351, 26);
            this.PaymentL.Name = "PaymentL";
            this.PaymentL.Size = new System.Drawing.Size(113, 29);
            this.PaymentL.TabIndex = 7;
            this.PaymentL.Text = "Payment";
            // 
            // bKashRB
            // 
            this.bKashRB.AutoSize = true;
            this.bKashRB.Location = new System.Drawing.Point(330, 246);
            this.bKashRB.Name = "bKashRB";
            this.bKashRB.Size = new System.Drawing.Size(55, 17);
            this.bKashRB.TabIndex = 9;
            this.bKashRB.TabStop = true;
            this.bKashRB.Text = "bKash";
            this.bKashRB.UseVisualStyleBackColor = true;
            this.bKashRB.CheckedChanged += new System.EventHandler(this.bKashRB_CheckedChanged);
            // 
            // NexusPayRB
            // 
            this.NexusPayRB.AutoSize = true;
            this.NexusPayRB.Location = new System.Drawing.Point(456, 244);
            this.NexusPayRB.Name = "NexusPayRB";
            this.NexusPayRB.Size = new System.Drawing.Size(73, 17);
            this.NexusPayRB.TabIndex = 11;
            this.NexusPayRB.TabStop = true;
            this.NexusPayRB.Text = "NexusPay";
            this.NexusPayRB.UseVisualStyleBackColor = true;
            // 
            // RocketRB
            // 
            this.RocketRB.AutoSize = true;
            this.RocketRB.Location = new System.Drawing.Point(391, 246);
            this.RocketRB.Name = "RocketRB";
            this.RocketRB.Size = new System.Drawing.Size(60, 17);
            this.RocketRB.TabIndex = 12;
            this.RocketRB.TabStop = true;
            this.RocketRB.Text = "Rocket";
            this.RocketRB.UseVisualStyleBackColor = true;
            // 
            // TicketPriceL
            // 
            this.TicketPriceL.AutoSize = true;
            this.TicketPriceL.Location = new System.Drawing.Point(263, 91);
            this.TicketPriceL.Name = "TicketPriceL";
            this.TicketPriceL.Size = new System.Drawing.Size(64, 13);
            this.TicketPriceL.TabIndex = 13;
            this.TicketPriceL.Text = "Ticket Price";
            // 
            // BusologyFeeL
            // 
            this.BusologyFeeL.AutoSize = true;
            this.BusologyFeeL.Location = new System.Drawing.Point(263, 115);
            this.BusologyFeeL.Name = "BusologyFeeL";
            this.BusologyFeeL.Size = new System.Drawing.Size(71, 13);
            this.BusologyFeeL.TabIndex = 14;
            this.BusologyFeeL.Text = "Busology Fee";
            // 
            // Busologybox
            // 
            this.Busologybox.Enabled = false;
            this.Busologybox.Location = new System.Drawing.Point(354, 114);
            this.Busologybox.Name = "Busologybox";
            this.Busologybox.ReadOnly = true;
            this.Busologybox.Size = new System.Drawing.Size(175, 20);
            this.Busologybox.TabIndex = 15;
            // 
            // TicketPricebox
            // 
            this.TicketPricebox.Enabled = false;
            this.TicketPricebox.Location = new System.Drawing.Point(354, 88);
            this.TicketPricebox.Name = "TicketPricebox";
            this.TicketPricebox.ReadOnly = true;
            this.TicketPricebox.Size = new System.Drawing.Size(175, 20);
            this.TicketPricebox.TabIndex = 16;
            this.TicketPricebox.TextChanged += new System.EventHandler(this.TicketPricebox_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(292, 293);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // UNbox
            // 
            this.UNbox.Enabled = false;
            this.UNbox.Location = new System.Drawing.Point(354, 166);
            this.UNbox.Name = "UNbox";
            this.UNbox.ReadOnly = true;
            this.UNbox.Size = new System.Drawing.Size(175, 20);
            this.UNbox.TabIndex = 18;
            // 
            // UserNnL
            // 
            this.UserNnL.AutoSize = true;
            this.UserNnL.Location = new System.Drawing.Point(263, 169);
            this.UserNnL.Name = "UserNnL";
            this.UserNnL.Size = new System.Drawing.Size(60, 13);
            this.UserNnL.TabIndex = 19;
            this.UserNnL.Text = "User Name";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(571, 348);
            this.Controls.Add(this.UserNnL);
            this.Controls.Add(this.UNbox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.TicketPricebox);
            this.Controls.Add(this.Busologybox);
            this.Controls.Add(this.BusologyFeeL);
            this.Controls.Add(this.TicketPriceL);
            this.Controls.Add(this.RocketRB);
            this.Controls.Add(this.NexusPayRB);
            this.Controls.Add(this.bKashRB);
            this.Controls.Add(this.PaymentL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.ContinueB);
            this.Controls.Add(this.TotalAmountL);
            this.Controls.Add(this.TotalAmountbox);
            this.Controls.Add(this.PayOpL);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PayOpL;
        private System.Windows.Forms.TextBox TotalAmountbox;
        private System.Windows.Forms.Label TotalAmountL;
        private System.Windows.Forms.Button ContinueB;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PaymentL;
        private System.Windows.Forms.RadioButton bKashRB;
        private System.Windows.Forms.RadioButton NexusPayRB;
        private System.Windows.Forms.RadioButton RocketRB;
        private System.Windows.Forms.Label TicketPriceL;
        private System.Windows.Forms.Label BusologyFeeL;
        private System.Windows.Forms.TextBox Busologybox;
        private System.Windows.Forms.TextBox TicketPricebox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox UNbox;
        private System.Windows.Forms.Label UserNnL;
    }
}