namespace WindowsFormsApplication1
{
    partial class Admin_Panel
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteB = new System.Windows.Forms.Button();
            this.UNBox = new System.Windows.Forms.TextBox();
            this.dltUserL = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.FoundL = new System.Windows.Forms.Label();
            this.CheckB = new System.Windows.Forms.Button();
            this.TicketUNbox = new System.Windows.Forms.TextBox();
            this.CheckTicketB = new System.Windows.Forms.Button();
            this.UserTicketL = new System.Windows.Forms.Label();
            this.DeleteTickB = new System.Windows.Forms.Button();
            this.ConfirmB = new System.Windows.Forms.Button();
            this.FoundTicketL = new System.Windows.Forms.Label();
            this.CheckAgainB = new System.Windows.Forms.Button();
            this.ShowAllTicketB = new System.Windows.Forms.Button();
            this.ShowAllB = new System.Windows.Forms.Button();
            this.ConfirmL = new System.Windows.Forms.Label();
            this.confirmationBox = new System.Windows.Forms.TextBox();
            this.ReffBox = new System.Windows.Forms.TextBox();
            this.ReffL = new System.Windows.Forms.Label();
            this.SearchReffB = new System.Windows.Forms.Button();
            this.SearchReffAgainB = new System.Windows.Forms.Button();
            this.PassengerInfoL = new System.Windows.Forms.Label();
            this.TicketInfoL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // LogoutB
            // 
            this.LogoutB.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogoutB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogoutB.Location = new System.Drawing.Point(802, 365);
            this.LogoutB.Name = "LogoutB";
            this.LogoutB.Size = new System.Drawing.Size(71, 30);
            this.LogoutB.TabIndex = 1;
            this.LogoutB.Text = "Logout";
            this.LogoutB.UseVisualStyleBackColor = false;
            this.LogoutB.Click += new System.EventHandler(this.LogoutB_Click);
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.Red;
            this.ExitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitB.Location = new System.Drawing.Point(719, 365);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(77, 30);
            this.ExitB.TabIndex = 2;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 131);
            this.dataGridView1.TabIndex = 3;
            // 
            // DeleteB
            // 
            this.DeleteB.BackColor = System.Drawing.Color.Red;
            this.DeleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteB.Location = new System.Drawing.Point(802, 291);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(71, 43);
            this.DeleteB.TabIndex = 4;
            this.DeleteB.Text = "Delete";
            this.DeleteB.UseVisualStyleBackColor = false;
            this.DeleteB.Visible = false;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // UNBox
            // 
            this.UNBox.Location = new System.Drawing.Point(631, 246);
            this.UNBox.Name = "UNBox";
            this.UNBox.Size = new System.Drawing.Size(242, 20);
            this.UNBox.TabIndex = 5;
            // 
            // dltUserL
            // 
            this.dltUserL.AutoSize = true;
            this.dltUserL.Location = new System.Drawing.Point(634, 230);
            this.dltUserL.Name = "dltUserL";
            this.dltUserL.Size = new System.Drawing.Size(148, 13);
            this.dltUserL.TabIndex = 6;
            this.dltUserL.Text = "Enter a passenger user name ";
            this.dltUserL.Click += new System.EventHandler(this.dltUserL_Click);
            // 
            // searchB
            // 
            this.searchB.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchB.Location = new System.Drawing.Point(631, 291);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(82, 43);
            this.searchB.TabIndex = 7;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = false;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // FoundL
            // 
            this.FoundL.AutoSize = true;
            this.FoundL.Location = new System.Drawing.Point(643, 272);
            this.FoundL.Name = "FoundL";
            this.FoundL.Size = new System.Drawing.Size(57, 13);
            this.FoundL.TabIndex = 8;
            this.FoundL.Text = "Not Found";
            this.FoundL.Visible = false;
            // 
            // CheckB
            // 
            this.CheckB.BackColor = System.Drawing.Color.LimeGreen;
            this.CheckB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckB.Location = new System.Drawing.Point(719, 291);
            this.CheckB.Name = "CheckB";
            this.CheckB.Size = new System.Drawing.Size(77, 43);
            this.CheckB.TabIndex = 10;
            this.CheckB.Text = "Check Again";
            this.CheckB.UseVisualStyleBackColor = false;
            this.CheckB.Click += new System.EventHandler(this.CheckB_Click);
            // 
            // TicketUNbox
            // 
            this.TicketUNbox.Location = new System.Drawing.Point(33, 246);
            this.TicketUNbox.Name = "TicketUNbox";
            this.TicketUNbox.Size = new System.Drawing.Size(165, 20);
            this.TicketUNbox.TabIndex = 11;
            // 
            // CheckTicketB
            // 
            this.CheckTicketB.BackColor = System.Drawing.Color.Blue;
            this.CheckTicketB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTicketB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckTicketB.Location = new System.Drawing.Point(33, 291);
            this.CheckTicketB.Name = "CheckTicketB";
            this.CheckTicketB.Size = new System.Drawing.Size(165, 28);
            this.CheckTicketB.TabIndex = 12;
            this.CheckTicketB.Text = "Check User Ticket Details";
            this.CheckTicketB.UseVisualStyleBackColor = false;
            this.CheckTicketB.Click += new System.EventHandler(this.CheckTicketB_Click);
            // 
            // UserTicketL
            // 
            this.UserTicketL.AutoSize = true;
            this.UserTicketL.Location = new System.Drawing.Point(30, 231);
            this.UserTicketL.Name = "UserTicketL";
            this.UserTicketL.Size = new System.Drawing.Size(148, 13);
            this.UserTicketL.TabIndex = 13;
            this.UserTicketL.Text = "Enter a passenger user name ";
            // 
            // DeleteTickB
            // 
            this.DeleteTickB.BackColor = System.Drawing.Color.Red;
            this.DeleteTickB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTickB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteTickB.Location = new System.Drawing.Point(337, 291);
            this.DeleteTickB.Name = "DeleteTickB";
            this.DeleteTickB.Size = new System.Drawing.Size(77, 28);
            this.DeleteTickB.TabIndex = 14;
            this.DeleteTickB.Text = "Delete";
            this.DeleteTickB.UseVisualStyleBackColor = false;
            this.DeleteTickB.Visible = false;
            this.DeleteTickB.Click += new System.EventHandler(this.DeleteTickB_Click);
            // 
            // ConfirmB
            // 
            this.ConfirmB.BackColor = System.Drawing.Color.LimeGreen;
            this.ConfirmB.Enabled = false;
            this.ConfirmB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirmB.Location = new System.Drawing.Point(260, 291);
            this.ConfirmB.Name = "ConfirmB";
            this.ConfirmB.Size = new System.Drawing.Size(71, 28);
            this.ConfirmB.TabIndex = 15;
            this.ConfirmB.Text = "Confirm";
            this.ConfirmB.UseVisualStyleBackColor = false;
            this.ConfirmB.Click += new System.EventHandler(this.ConfirmB_Click);
            // 
            // FoundTicketL
            // 
            this.FoundTicketL.AutoSize = true;
            this.FoundTicketL.Location = new System.Drawing.Point(33, 272);
            this.FoundTicketL.Name = "FoundTicketL";
            this.FoundTicketL.Size = new System.Drawing.Size(57, 13);
            this.FoundTicketL.TabIndex = 16;
            this.FoundTicketL.Text = "Not Found";
            this.FoundTicketL.Visible = false;
            this.FoundTicketL.Click += new System.EventHandler(this.FoundTicketL_Click);
            // 
            // CheckAgainB
            // 
            this.CheckAgainB.BackColor = System.Drawing.Color.LimeGreen;
            this.CheckAgainB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAgainB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckAgainB.Location = new System.Drawing.Point(33, 329);
            this.CheckAgainB.Name = "CheckAgainB";
            this.CheckAgainB.Size = new System.Drawing.Size(165, 29);
            this.CheckAgainB.TabIndex = 17;
            this.CheckAgainB.Text = "Check Again";
            this.CheckAgainB.UseVisualStyleBackColor = false;
            this.CheckAgainB.Click += new System.EventHandler(this.CheckAgainB_Click);
            // 
            // ShowAllTicketB
            // 
            this.ShowAllTicketB.BackColor = System.Drawing.Color.LimeGreen;
            this.ShowAllTicketB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllTicketB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowAllTicketB.Location = new System.Drawing.Point(260, 330);
            this.ShowAllTicketB.Name = "ShowAllTicketB";
            this.ShowAllTicketB.Size = new System.Drawing.Size(105, 29);
            this.ShowAllTicketB.TabIndex = 18;
            this.ShowAllTicketB.Text = "Show All";
            this.ShowAllTicketB.UseVisualStyleBackColor = false;
            this.ShowAllTicketB.Click += new System.EventHandler(this.ShowAllTicketB_Click);
            // 
            // ShowAllB
            // 
            this.ShowAllB.BackColor = System.Drawing.Color.LimeGreen;
            this.ShowAllB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowAllB.Location = new System.Drawing.Point(631, 366);
            this.ShowAllB.Name = "ShowAllB";
            this.ShowAllB.Size = new System.Drawing.Size(82, 29);
            this.ShowAllB.TabIndex = 19;
            this.ShowAllB.Text = "Show All";
            this.ShowAllB.UseVisualStyleBackColor = false;
            this.ShowAllB.Click += new System.EventHandler(this.ShowAllB_Click);
            // 
            // ConfirmL
            // 
            this.ConfirmL.AutoSize = true;
            this.ConfirmL.Location = new System.Drawing.Point(265, 376);
            this.ConfirmL.Name = "ConfirmL";
            this.ConfirmL.Size = new System.Drawing.Size(99, 13);
            this.ConfirmL.TabIndex = 22;
            this.ConfirmL.Text = "Confirmation status ";
            this.ConfirmL.Click += new System.EventHandler(this.ConfirmL_Click);
            // 
            // confirmationBox
            // 
            this.confirmationBox.Location = new System.Drawing.Point(368, 375);
            this.confirmationBox.Name = "confirmationBox";
            this.confirmationBox.Size = new System.Drawing.Size(100, 20);
            this.confirmationBox.TabIndex = 23;
            // 
            // ReffBox
            // 
            this.ReffBox.Location = new System.Drawing.Point(260, 246);
            this.ReffBox.Name = "ReffBox";
            this.ReffBox.Size = new System.Drawing.Size(248, 20);
            this.ReffBox.TabIndex = 24;
            this.ReffBox.TextChanged += new System.EventHandler(this.ReffBox_TextChanged);
            // 
            // ReffL
            // 
            this.ReffL.AutoSize = true;
            this.ReffL.Location = new System.Drawing.Point(263, 230);
            this.ReffL.Name = "ReffL";
            this.ReffL.Size = new System.Drawing.Size(102, 13);
            this.ReffL.TabIndex = 25;
            this.ReffL.Text = "Enter a user Ref no ";
            // 
            // SearchReffB
            // 
            this.SearchReffB.BackColor = System.Drawing.Color.Blue;
            this.SearchReffB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchReffB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchReffB.Location = new System.Drawing.Point(420, 291);
            this.SearchReffB.Name = "SearchReffB";
            this.SearchReffB.Size = new System.Drawing.Size(88, 28);
            this.SearchReffB.TabIndex = 26;
            this.SearchReffB.Text = "Search";
            this.SearchReffB.UseVisualStyleBackColor = false;
            this.SearchReffB.Click += new System.EventHandler(this.SearchReffB_Click);
            // 
            // SearchReffAgainB
            // 
            this.SearchReffAgainB.BackColor = System.Drawing.Color.LimeGreen;
            this.SearchReffAgainB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchReffAgainB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchReffAgainB.Location = new System.Drawing.Point(391, 330);
            this.SearchReffAgainB.Name = "SearchReffAgainB";
            this.SearchReffAgainB.Size = new System.Drawing.Size(117, 28);
            this.SearchReffAgainB.TabIndex = 27;
            this.SearchReffAgainB.Text = "Search Again";
            this.SearchReffAgainB.UseVisualStyleBackColor = false;
            this.SearchReffAgainB.Click += new System.EventHandler(this.SearchReffAgainB_Click);
            // 
            // PassengerInfoL
            // 
            this.PassengerInfoL.AutoSize = true;
            this.PassengerInfoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerInfoL.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.PassengerInfoL.Location = new System.Drawing.Point(692, 204);
            this.PassengerInfoL.Name = "PassengerInfoL";
            this.PassengerInfoL.Size = new System.Drawing.Size(116, 16);
            this.PassengerInfoL.TabIndex = 28;
            this.PassengerInfoL.Text = "Passenger Info.";
            // 
            // TicketInfoL
            // 
            this.TicketInfoL.AutoSize = true;
            this.TicketInfoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketInfoL.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.TicketInfoL.Location = new System.Drawing.Point(145, 204);
            this.TicketInfoL.Name = "TicketInfoL";
            this.TicketInfoL.Size = new System.Drawing.Size(171, 16);
            this.TicketInfoL.TabIndex = 29;
            this.TicketInfoL.Text = "Passengers Ticket Info.";
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(889, 431);
            this.Controls.Add(this.TicketInfoL);
            this.Controls.Add(this.PassengerInfoL);
            this.Controls.Add(this.SearchReffAgainB);
            this.Controls.Add(this.SearchReffB);
            this.Controls.Add(this.ReffL);
            this.Controls.Add(this.ReffBox);
            this.Controls.Add(this.confirmationBox);
            this.Controls.Add(this.ConfirmL);
            this.Controls.Add(this.ShowAllB);
            this.Controls.Add(this.ShowAllTicketB);
            this.Controls.Add(this.CheckAgainB);
            this.Controls.Add(this.FoundTicketL);
            this.Controls.Add(this.ConfirmB);
            this.Controls.Add(this.DeleteTickB);
            this.Controls.Add(this.UserTicketL);
            this.Controls.Add(this.CheckTicketB);
            this.Controls.Add(this.TicketUNbox);
            this.Controls.Add(this.CheckB);
            this.Controls.Add(this.FoundL);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.dltUserL);
            this.Controls.Add(this.UNBox);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.LogoutB);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.TextBox UNBox;
        private System.Windows.Forms.Label dltUserL;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Label FoundL;
        private System.Windows.Forms.Button CheckB;
        private System.Windows.Forms.TextBox TicketUNbox;
        private System.Windows.Forms.Button CheckTicketB;
        private System.Windows.Forms.Label UserTicketL;
        private System.Windows.Forms.Button DeleteTickB;
        private System.Windows.Forms.Button ConfirmB;
        private System.Windows.Forms.Label FoundTicketL;
        private System.Windows.Forms.Button CheckAgainB;
        private System.Windows.Forms.Button ShowAllTicketB;
        private System.Windows.Forms.Button ShowAllB;
        private System.Windows.Forms.Label ConfirmL;
        private System.Windows.Forms.TextBox confirmationBox;
        private System.Windows.Forms.TextBox ReffBox;
        private System.Windows.Forms.Label ReffL;
        private System.Windows.Forms.Button SearchReffB;
        private System.Windows.Forms.Button SearchReffAgainB;
        private System.Windows.Forms.Label PassengerInfoL;
        private System.Windows.Forms.Label TicketInfoL;
    }
}