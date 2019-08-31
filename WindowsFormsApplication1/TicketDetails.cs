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
    public partial class TicketDetails : Form
    {
        public static string show = ""; 

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public TicketDetails()
        {
            InitializeComponent();
        }

        private void TicketDetails_Load(object sender, EventArgs e)
        {
            disp_ticket_data();
           
            
   

        }

        public void disp_ticket_data()
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from BSTicket Where UserName = '" +LoginPage.UN+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        private void LogoutB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void BackB_Click(object sender, EventArgs e)
        {

            Homepage hmpage = new Homepage();
            hmpage.Show();
            this.Hide();
            
        }

        private void BookAnTicB_Click(object sender, EventArgs e)
        {
            Homepage hmpage = new Homepage();
            hmpage.Show();
            this.Hide();
        }

    }
}
