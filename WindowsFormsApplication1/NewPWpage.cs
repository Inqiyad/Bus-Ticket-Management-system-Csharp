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
    public partial class NewPWpage : Form
    {
        
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public NewPWpage()
        {
            InitializeComponent();
        }

        private void ConfirmPwB_Click(object sender, EventArgs e)
        {
            if (NewPWBox.Text != "" && NewPWBox.Text == ConfirmPWBox.Text)
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update PLogin set Password = '" +ConfirmPWBox.Text+ "'where UserName = '" +UNbox.Text+ "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Password Updated Successfully!!");
                LoginPage lgpage = new LoginPage();
                lgpage.Show();
                this.Hide();
            }
            else if (NewPWBox.Text == "")
            {
                MessageBox.Show("Please enter a new Password");
            }
            else if (NewPWBox.Text != ConfirmPWBox.Text)
            {
                MessageBox.Show("Password don't match");
            }


            
            
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you go back, you have to re-submit your form");
            BackB.Visible = false;
            GoBackB.Visible = true;
        }

        private void GoBackB_Click(object sender, EventArgs e)
        {
            ForgetPWpage forgotPW = new ForgetPWpage();
            forgotPW.Show();
            this.Hide();
        }

        private void NewPWBox_TextChanged(object sender, EventArgs e)
        {
            if (NewPWBox.Text != "")
            {
                ConfirmPWBox.Enabled = true;
            }
            else
            {
                ConfirmPWBox.Enabled = false;
               
            }

        }

        private void NewPWpage_Load(object sender, EventArgs e)
        {
            UNbox.Text = ForgetPWpage.UN;
        }

        

        

       
    }
}
