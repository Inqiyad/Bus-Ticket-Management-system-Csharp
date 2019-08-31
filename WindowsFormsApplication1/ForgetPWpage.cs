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
    public partial class ForgetPWpage : Form
    {
        public static string UN = "";
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public ForgetPWpage()
        {
            InitializeComponent();
        }

        private void ForgetPWpage_Load(object sender, EventArgs e)
        {

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PLogin Where UserName = '" + UNbox.Text + "' and PhoneNo = '"+PhoneNobox.Text+"' or EmailAddress = '"+Emailbox.Text+"'";
            cmd.ExecuteNonQuery();
          
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            UN = UNbox.Text;
            sqlcon.Close();
            if (dt.Rows.Count >= 1 && (PhoneNobox.Text != "" || Emailbox.Text != ""))
            
            {
                NewPWpage newPWpage = new NewPWpage();
                newPWpage.Show();
                this.Hide();
            
            }
           
            else
            {
                MessageBox.Show("Info don't match");
            }
           
        }

        private void PhoneNoRB_CheckedChanged(object sender, EventArgs e)
        {
            PhoneNobox.Enabled = true;
            PhoneNobox.Visible = true;
            Emailbox.Visible = false;
            Emailbox.Enabled = false;

        }

        private void EmailRB_CheckedChanged(object sender, EventArgs e)
        {
            Emailbox.Visible = true;
            Emailbox.Enabled = true;
            PhoneNobox.Enabled = false;
            PhoneNobox.Visible = false;
        }

        private void InfoL_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
