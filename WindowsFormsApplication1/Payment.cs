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

    public partial class Payment : Form
    {
        public static string st = "";

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public static string MerchantNo = "";

        public Payment()
        {
            InitializeComponent();
        }

        private void ContinueB_Click(object sender, EventArgs e)
        {
            if (bKashRB.Checked)
            {
               MerchantNo = "01775896996";

               sqlcon.Open();
               SqlCommand cmd = sqlcon.CreateCommand();
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "update BSTicket set TicketPrice = '" +TicketPricebox.Text+ "',BusologyFee = '" +Busologybox.Text+ "',TotalAmount = '" +TotalAmountbox.Text+ "' where Ref = '" + Homepage.reff + "'";
               cmd.ExecuteNonQuery();
               sqlcon.Close();

            Payment_Varify payVar = new Payment_Varify();
            payVar.Show();
            this.Hide();
            }

            else if (RocketRB.Checked)
            {
                MerchantNo = "015717555679";

                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update BSTicket set TicketPrice = '" + TicketPricebox.Text + "',BusologyFee = '" + Busologybox.Text + "',TotalAmount = '" + TotalAmountbox.Text + "' where Ref = '" + Homepage.reff + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                Payment_Varify payVar = new Payment_Varify();
                payVar.Show();
                this.Hide();
            }

            else if (NexusPayRB.Checked)
            {
                MerchantNo = "01206793490";

                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update BSTicket set TicketPrice = '" + TicketPricebox.Text + "',BusologyFee = '" + Busologybox.Text + "',TotalAmount = '" + TotalAmountbox.Text + "' where Ref = '" + Homepage.reff + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                Payment_Varify payVar = new Payment_Varify();
                payVar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select one payment method!!");
            }

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            Homepage hmpage = new Homepage();
            hmpage.Show();
            this.Hide();
        }

        private void bKashRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TicketPricebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (SelectBus.BusType == "AC")
            {
                TicketPricebox.Text = ACBus.TotalPrice;
                Busologybox.Text = ACBus.Fee;
                TotalAmountbox.Text = ACBus.Total;
            }

            else if (SelectBus.BusType == "Non AC")
            {
                TicketPricebox.Text = NonAcBus.TotalPrice;
                Busologybox.Text = NonAcBus.Fee;
                TotalAmountbox.Text = NonAcBus.Total;

            }

            UNbox.Text = LoginPage.UN;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            st = "";
            if (MessageBox.Show("If you go back, you have to select the seat again \nDo you want to continue", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (SelectBus.BusType == "AC")
                {
                    ACBus acB = new ACBus();
                    acB.Show();
                    this.Hide();
                }
                if (SelectBus.BusType == "Non AC")
                {
                    NonAcBus nonacB = new NonAcBus();
                    nonacB.Show();
                    this.Hide();
                }
            }

        }

      

       
    }
}
