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
    public partial class LoginPage : Form
    {
        public static string UN = "";     

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");       

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void PWbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingUp sgnpage = new SingUp();
            sgnpage.Show();
            this.Hide();
        }

        private void ForgotPWLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPWpage fgpage = new ForgetPWpage();
            fgpage.Show();
            this.Hide();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select UserName from PLogin Where UserName = '"+UNbox.Text+"'and Password = '"+PWbox.Text+"'";
            cmd.ExecuteNonQuery();            
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            UN = UNbox.Text;
            sqlcon.Close();

            if (dt.Rows.Count >= 1)
            {
                Homepage hmpage = new Homepage();
                hmpage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check User Nmae and Password");
            }

            

            
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void AdminPanelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Login adminlogin = new Admin_Login();
            adminlogin.Show();
            this.Hide();
        }

      

        
       

       
    }
}
