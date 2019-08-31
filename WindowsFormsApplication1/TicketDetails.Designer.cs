namespace WindowsFormsApplication1
{
    partial class TicketDetails
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
            this.TicketDEtL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LogoutB = new System.Windows.Forms.Button();
            this.BackB = new System.Windows.Forms.Button();
            this.BookAnTicB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketDEtL
            // 
            this.TicketDEtL.AutoSize = true;
            this.TicketDEtL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketDEtL.Location = new System.Drawing.Point(327, 20);
            this.TicketDEtL.Name = "TicketDEtL";
            this.TicketDEtL.Size = new System.Drawing.Size(173, 29);
            this.TicketDEtL.TabIndex = 0;
            this.TicketDEtL.Text = "Ticket Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 173);
            this.dataGridView1.TabIndex = 4;
            // 
            // LogoutB
            // 
            this.LogoutB.Location = new System.Drawing.Point(729, 298);
            this.LogoutB.Name = "LogoutB";
            this.LogoutB.Size = new System.Drawing.Size(75, 23);
            this.LogoutB.TabIndex = 5;
            this.LogoutB.Text = "Logout";
            this.LogoutB.UseVisualStyleBackColor = true;
            this.LogoutB.Click += new System.EventHandler(this.LogoutB_Click);
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(556, 298);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(133, 23);
            this.BackB.TabIndex = 6;
            this.BackB.Text = "Back to Home Page";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // BookAnTicB
            // 
            this.BookAnTicB.Location = new System.Drawing.Point(393, 298);
            this.BookAnTicB.Name = "BookAnTicB";
            this.BookAnTicB.Size = new System.Drawing.Size(122, 23);
            this.BookAnTicB.TabIndex = 10;
            this.BookAnTicB.Text = "Book Another Ticket";
            this.BookAnTicB.UseVisualStyleBackColor = true;
            this.BookAnTicB.Click += new System.EventHandler(this.BookAnTicB_Click);
            // 
            // TicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(852, 404);
            this.Controls.Add(this.BookAnTicB);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.LogoutB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TicketDEtL);
            this.Name = "TicketDetails";
            this.Text = "TicketDetails";
            this.Load += new System.EventHandler(this.TicketDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicketDEtL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogoutB;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Button BookAnTicB;
    }
}