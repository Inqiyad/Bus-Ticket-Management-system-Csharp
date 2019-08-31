using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Payment_Varify : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");
       
        public Payment_Varify()
        {
            InitializeComponent();
        }

        private void Payment_Varify_Load(object sender, EventArgs e)
        {
            MerchantNobox.Text = Payment.MerchantNo;
            UNbox.Text = LoginPage.UN;
            ReferBox.Text = Homepage.reff;

            if (SelectBus.BusType == "AC")
            {
                AmPaybox.Text = ACBus.Total;
            }

            else if (SelectBus.BusType == "Non AC")
            {

                AmPaybox.Text = NonAcBus.Total;

            }

            
           
        }


        private void BackB_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void MerchantNobox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoutB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void ConfirmreservationB_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("After confirmation, you can not make any changes.\n Do you want to continue", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update BSTicket set TicketStatus = '" +ConfirmationL.Text+ "' where Ref = '" +Homepage.reff+ "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                TicketDetails tktpage = new TicketDetails();
                tktpage.Show();
                this.Hide();

            }
    
        }

       
    }
}
