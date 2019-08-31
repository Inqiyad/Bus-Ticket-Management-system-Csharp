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
    public partial class Admin_Panel : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void LogoutB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void disp_data()
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select FullName,UserName,EmailAddress,PhoneNo,Address from PLogin";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from PLogin where UserName = '" +UNBox.Text+ "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            disp_data();
            MessageBox.Show("Record Deleted Successfully");
            DeleteB.Visible = false;
            FoundL.Text = "Deleted";
            FoundL.ForeColor = Color.Red;
            
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PLogin Where UserName = '" +UNBox.Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            sqlcon.Close();

            if (dt.Rows.Count >= 1)
            {
                FoundL.Text= "Found";
                FoundL.Visible = true;
                FoundL.ForeColor = Color.Blue;
                DeleteB.Visible = true;
                UNBox.Enabled = false;
               
            }
            else
            {
                FoundL.Text = "Not Found";
                FoundL.Visible = true;
                FoundL.ForeColor = Color.Red;
                DeleteB.Visible = false;
                UNBox.Enabled = false;
            }

            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CheckB_Click(object sender, EventArgs e)
        {
            UNBox.Enabled = true;
            FoundL.Visible = false;
            DeleteB.Visible = false;
            UNBox.Text = "";
        }

        private void DeleteTickB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from BSTicket where Ref = '" +ReffBox.Text+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            disp_ticket_data();
            MessageBox.Show("Record Deleted Successfully");
            DeleteTickB.Visible = false;
            confirmationBox.Text = "";
            ConfirmB.Enabled = false;
        }

        public void disp_ticket_data()
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from BSTicket";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        private void CheckTicketB_Click(object sender, EventArgs e)
        {
           
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from BSTicket Where UserName = '" +TicketUNbox.Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            sqlcon.Close();

            if (dt.Rows.Count >= 1)
            {
                FoundTicketL.Text = "Found";
                FoundTicketL.Visible = true;
                FoundTicketL.ForeColor = Color.Blue;          

            }
            else
            {
                FoundTicketL.Text = "Not Found";
                FoundTicketL.Visible = true;
                FoundTicketL.ForeColor = Color.Red;
                    

            }

        
        }

        private void FoundTicketL_Click(object sender, EventArgs e)
        {

        }

        private void CheckAgainB_Click(object sender, EventArgs e)
        {
            TicketUNbox.Enabled = true;
            FoundTicketL.Visible = false;
            TicketUNbox.Text = "";
        }

        private void ShowAllTicketB_Click(object sender, EventArgs e)
        {
            disp_ticket_data();
            confirmationBox.Text = "";
        }

        private void ShowAllB_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void ConfirmB_Click(object sender, EventArgs e)
        {
            confirmationBox.Text = "Confirmed";
            DeleteB.Visible = false;

            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update BSTicket set TicketStatus = '" +confirmationBox.Text+"' where Ref = '" +ReffBox.Text+ "'";
            cmd.ExecuteNonQuery();
      
            sqlcon.Close();
            disp_ticket_data();
        }

        private void ConfirmL_Click(object sender, EventArgs e)
        {
        
        }

        private void dltUserL_Click(object sender, EventArgs e)
        {

        }

        private void SearchReffB_Click(object sender, EventArgs e)
        {
            confirmationBox.Text = "";
            ConfirmB.Enabled = true;
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from BSTicket Where Ref = '"+ReffBox.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            sqlcon.Close();

            if (dt.Rows.Count >= 1)
            {
                DeleteTickB.Visible = true;
                ReffBox.Enabled = false;
                ConfirmB.Enabled = true;
                MessageBox.Show("Found");

            }
            else
            {
                DeleteTickB.Visible = false;
                ReffBox.Enabled = false;
                ConfirmB.Enabled = false;
                MessageBox.Show("Not Found");
                    

            }
        }

        private void SearchReffAgainB_Click(object sender, EventArgs e)
        {
            ReffBox.Enabled = true;
            DeleteTickB.Visible = false;
            ReffBox.Text = "";
            confirmationBox.Text = "";
        }

        private void ReffBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        

       

    }
}
