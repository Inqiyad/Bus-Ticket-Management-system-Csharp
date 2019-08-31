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
    
     
    public partial class SingUp : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public SingUp()
        {
            InitializeComponent();
        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }

        private void CreateB_Click(object sender, EventArgs e)
        {
               if (Namebox.Text != "" && UNbox.Text != "" && Emailbox.Text != "" && PWbox.Text != "" && PhNobox.Text != "" && Addressbox.Text != "")
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into PLogin(FullName,UserName,EmailAddress,Password,PhoneNo,Address) VALUES ('" + Namebox.Text + "','" + UNbox.Text + "','" + Emailbox.Text + "','" + PWbox.Text + "','" + PhNobox.Text + "','" + Addressbox.Text + "')";                 
                    cmd.ExecuteNonQuery();

                    sqlcon.Close();

                    LoginPage lgpage = new LoginPage();
                    lgpage.Show();
                    this.Hide();
                    MessageBox.Show("Account Created Successfully");
                }             
 
               else
                {
                    MessageBox.Show("Please fil all info");
                }

            
            

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckAvailableB_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PLogin Where UserName = '" + UNbox.Text + "'";
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);

            int i = ds.Tables[0].Rows.Count;
                 
            sqlcon.Close();
            if (i > 0 && UNbox.Text != "")
            {
                CheckL.Text = "Not Available";
                CheckL.Visible = true;
                ds.Clear();
            }
            else if (i <= 0 && UNbox.Text != "")
            {
                CheckL.Text = "Available";
                CheckL.Visible = true;

                Namebox.Enabled = true;
                Emailbox.Enabled = true;
                PWbox.Enabled = true;
                PhNobox.Enabled = true;
                Addressbox.Enabled = true;
                CreateB.Visible = true;

            }
            else
            {
                CheckL.Text = "Enter a user name";
                CheckL.Visible = true;
            }
                 
            

            
        }

        private void CheckL_Click(object sender, EventArgs e)
        {

        }

       

       

     

      

       
    }
}
