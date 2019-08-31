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
    public partial class Homepage : Form
    {

        public static string reff = "";

        public static string Pickup = "";
        public static string desti = "";
        

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public Homepage()
        {
            InitializeComponent();
        }

        private void Hmpage_Click(object sender, EventArgs e)
        {

        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void searchB_Click(object sender, EventArgs e)
        {
            if (FromCMbox.Text == ToCMbox.Text)
            {
                MessageBox.Show("Pick up point & destination point can not be same");
            }

            else if (dateTimePicker1.Value <= DateTime.Today)
            {
                MessageBox.Show("You can only reserve ticket from tomorrow");
            }

            else if ((FromCMbox.Text == "Bogra" || FromCMbox.Text == "Rajshahi" || FromCMbox.Text == "Dhaka" || FromCMbox.Text == "Feni" ||FromCMbox.Text == "Rangpur" || FromCMbox.Text == "Chittagong" || FromCMbox.Text == "Dinajpur" || FromCMbox.Text == "Khulna" || FromCMbox.Text == "Barisal") && (ToCMbox.Text == "Bogra" || ToCMbox.Text == "Rajshahi" || ToCMbox.Text == "Dhaka" || ToCMbox.Text == "Feni" || ToCMbox.Text == "Rangpur" || ToCMbox.Text == "Chittagong" || ToCMbox.Text == "Dinajpur" || ToCMbox.Text == "Khulna" || ToCMbox.Text == "Barisal") && (dateTimePicker1.Value>DateTime.Today))
            {
               sqlcon.Open();
               SqlCommand cmd = sqlcon.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "insert into BSTicket(Ref,UserName,PickUpPoint,Destination,Date) VALUES ('" + RefBx.Text + "','" + UNbox.Text + "','" + FromCMbox.Text + "','" + ToCMbox.Text + "','" +dateTimePicker1.Text+ "')";
                 cmd.ExecuteNonQuery();

                reff= RefBx.Text;
                Pickup = FromCMbox.Text;
                desti = ToCMbox.Text;
                sqlcon.Close();

                SelectBus sltbus = new SelectBus();
                sltbus.Show();
                this.Hide();
            }
      
            else
            {
                MessageBox.Show("Select them all");
            }  
        
            
        }

        private void LogoutB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void FromCMbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ProfileLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PLogin Where UserName = '" +LoginPage.UN+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            
            sqlcon.Close();


            PassengerProfile passenserPro = new PassengerProfile();
            passenserPro.Show();
            this.Hide();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            UNbox.Text = LoginPage.UN;
            
        }

        private void CheckTicktB_Click(object sender, EventArgs e)
        {
            
            TicketDetails tktcpage = new TicketDetails();
            tktcpage.Show();
            this.Hide();
        }

        private void CheckAVB_Click(object sender, EventArgs e)
        {
            
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from BSTicket Where Ref = '" + RefBx.Text + "'";
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);

                int i = ds.Tables[0].Rows.Count;

                sqlcon.Close();
                if (i > 0 && RefBx.Text != "")
                {
                    AvailabilityL.Text = "Not Available";
                    AvailabilityL.Visible = true;
                    ds.Clear();
                }
                else if (i <= 0 && RefBx.Text != "")
                {
                    AvailabilityL.Text = "Available";
                    AvailabilityL.Visible = true;
                    RefBx.Enabled = false;

                    FromCMbox.Enabled = true;
                    ToCMbox.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    searchB.Enabled = true;



                }
                else
                {
                    AvailabilityL.Text = "Enter a ref no";
                    AvailabilityL.Visible = true;
                    MessageBox.Show("Enter a ref no");
                    
                }

            
            
            
        }

        private void RefBx_TextChanged(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(RefBx.Text, "^[a-zA-Z0-9 ]"))
            {
                MessageBox.Show("Enter ref no [like a,b,1,2,a1,b6,1*....]");
            }


        
        }
       

        

       

      

       

      

       
    }
}
