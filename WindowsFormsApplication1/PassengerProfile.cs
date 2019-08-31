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
    public partial class PassengerProfile : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");
        public PassengerProfile()
        {
            InitializeComponent();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            Homepage hmpage = new Homepage();
            hmpage.Show();
            this.Hide();
          
        }

        

        

        private void PassengerProfile_Load(object sender, EventArgs e)
        {
            UNbox.Text = LoginPage.UN;
            disp_data();
       

        }

        private void NewPWBox_TextChanged(object sender, EventArgs e)
        {
            if (NewPWBox.Text != "")
            {
                confirmPWbox.Enabled = true;
            }

            else
            {
                confirmPWbox.Enabled = false;
            }
        }

     

        private void Namebox_TextChanged(object sender, EventArgs e)
        {
            if (Namebox.Text != "")
            {
                FNSaveB.Enabled = true;
            }
            else
            {
                FNSaveB.Enabled = false;
            }
        }

        public void disp_data()
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PLogin where UserName = '" + UNbox.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            Namebox.Enabled = true;
            Emailbox.Enabled = true;
            NewPWBox.Enabled = true;
            PhNobox.Enabled = true;
            Addressbox.Enabled = true;
            CancelB.Visible = true;
        }

        private void NewPWL_Click(object sender, EventArgs e)
        {

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            Homepage hmpage = new Homepage();
            hmpage.Show();
            this.Hide();
        }

        private void PNSaveB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PLogin set PhoneNo = '" +PhNobox.Text+ "'where UserName = '" + UNbox.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            disp_data();
            MessageBox.Show("Updated Successfully");
            
        }

        private void Emailbox_TextChanged(object sender, EventArgs e)
        {
            if (Emailbox.Text != "")
            {
                EASaveB.Enabled = true;
            }
            else
            {
                EASaveB.Enabled = false;
            }
        }

        private void PhNobox_TextChanged(object sender, EventArgs e)
        {
            if (PhNobox.Text != "")
            {
                PNSaveB.Enabled = true;
            }
            else
            {
                PNSaveB.Enabled = false;
            }
        }

        private void Addressbox_TextChanged(object sender, EventArgs e)
        {
            if (Addressbox.Text != "")
            {
                AdrsSaveB.Enabled = true;
            }
            else
            {
                AdrsSaveB.Enabled = false;
            }
        }

        private void FNSaveB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PLogin set FullName = '" +Namebox.Text+ "'where UserName = '" + UNbox.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            disp_data();
            MessageBox.Show("Updated Successfully");
            
        }

        private void EASaveB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PLogin set EmailAddress = '" +Emailbox.Text+ "'where UserName = '" + UNbox.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            disp_data();
            MessageBox.Show("Updated Successfully");
            
        }

        private void AdrsSaveB_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update PLogin set Address = '" +Addressbox.Text+ "'where UserName = '" + UNbox.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            disp_data();
            MessageBox.Show("Updated Successfully");
         
        }

        private void PWSaveB_Click(object sender, EventArgs e)
        {
            if (NewPWBox.Text == confirmPWbox.Text)
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update PLogin set Password = '" + confirmPWbox.Text + "'where UserName = '" + UNbox.Text + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                disp_data();
                MessageBox.Show("Updated Successfully");
                
            }
            else
            {
                MessageBox.Show("Password don't match");
            }
        }

        private void confirmPWbox_TextChanged(object sender, EventArgs e)
        {
            if (confirmPWbox.Text != "")
            {
                PWSaveB.Enabled = true;
            }
            else
            {
                PWSaveB.Enabled = false;
            }
        }



      
    }
}
