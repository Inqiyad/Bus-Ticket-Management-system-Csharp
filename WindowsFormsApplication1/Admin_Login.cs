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
    public partial class Admin_Login : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");
        
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ID from AdminLogin Where ID = '" + ID.Text + "'and Password = '" + Password.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            sqlcon.Close();

            if (dt.Rows.Count >= 1)
            {
                Admin_Panel admin = new Admin_Panel();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check User Nmae and Password");
            }
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
