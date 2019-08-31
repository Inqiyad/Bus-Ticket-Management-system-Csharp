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
    public partial class SelectBus : Form
    {
        

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public static string BusType = "";

        public SelectBus()
        {
            InitializeComponent();
        }

        private void BusNmbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If you go back you have to re-submit all the info. \nDo you want to continue", "Go Back", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Homepage hmpage = new Homepage();
                hmpage.Show();
                this.Hide();
            }
        }

   

        private void NextB_Click(object sender, EventArgs e)
        {
            if (BusNmCMbox.Text == "" || BusTypeCMbox.Text == "" || TravelTimeCMbox.Text == "")
            {
                MessageBox.Show("Select Them All");
            }


            else if (BusTypeCMbox.Text == "AC")
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update BSTicket set BusName = '" + BusNmCMbox.Text + "',BusType = '" + BusTypeCMbox.Text + "', TravelingTime = '"+TravelTimeCMbox.Text+"' where Ref = '" +Homepage.reff+ "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                BusType = "AC";
                
                ACBus acBus = new ACBus();
                acBus.Show();
                this.Hide();
            }
            else if (BusTypeCMbox.Text == "Non AC")
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update BSTicket set BusName = '" + BusNmCMbox.Text + "',BusType = '" + BusTypeCMbox.Text + "',TravelingTime = '" + TravelTimeCMbox.Text + "' where Ref = '" + Homepage.reff + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                BusType = "Non AC";
                
                NonAcBus nonacBus = new NonAcBus();
                nonacBus.Show();
                this.Hide();
            }
        }

        private void SelectBus_Load(object sender, EventArgs e)
        {
            
        }

        private void BusTypeCMbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TravelTmL_Click(object sender, EventArgs e)
        {

        }

    
     

       
    }
}
