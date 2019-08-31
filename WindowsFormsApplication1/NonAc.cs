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
    public partial class NonAcBus : Form
    {
        public static string PP = "";
        public static string DP = "";

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-6V9PP9R;Initial Catalog=Project;Integrated Security=True");

        public static string seatList = "";

        int count = 0;
        int TP = 0;
        int fee = 0;
        int price = 0;
        public static string TotalPrice = "";
        public static string Fee = "";
        public static string Total = "";


        public NonAcBus()
        {
            InitializeComponent();
        }

        private void SNonAc_Load(object sender, EventArgs e)
        {
            PP = Homepage.Pickup;
            DP = Homepage.desti;
            seatList = Payment.st;

            if ((PP == "Bogra" || PP == "Barisal" || PP == "Rajshahi" || PP == "Dhaka" || PP == "Rangpur") && (DP == "Bogra" || DP == "Barisal" || DP == "Rajshahi" || DP == "Dhaka" || DP == "Rangpur"))
            {
                SpriceBox.Text = "500";
                price = 500;
            }
            else if ((PP == "Bogra" || PP == "Barisal" || PP == "Rajshahi" || PP == "Dhaka" || PP == "Rangpur") && (DP == "Feni" || DP == "Chittagong" || DP == "Dinajpur" || DP == "Khulna"))
            {
                SpriceBox.Text = "750";
                price = 750;
            }
            else if ((PP == "Feni" || PP == "Chittagong" || PP == "Dinajpur" || PP == "Khulna") && (DP == "Feni" || DP == "Chittagong" || DP == "Dinajpur" || DP == "Khulna"))
            {
                SpriceBox.Text = "600";
                price = 600;
            }
            else if ((PP == "Feni" || PP == "Chittagong" || PP == "Dinajpur" || PP == "Khulna") && (DP == "Bogra" || DP == "Barisal" || DP == "Rajshahi" || DP == "Dhaka" || DP == "Rangpur"))
            {
                SpriceBox.Text = "750";
                price = 750;
            }
            
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If you go back, you have to re-submit the forms \nDo you want to continue", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SelectBus sltbus = new SelectBus();
                sltbus.Show();
                this.Hide();
            }
        }

        private void NextB_Click(object sender, EventArgs e)
        {
            TotalPrice = (count * price).ToString();
            Fee = (count * 40).ToString();
            TP = (count * price);
            fee = (count * 40);
            Total = (TP + fee).ToString();


            if (SeatBox.Text == "")
            {
                MessageBox.Show("Select at least one seat");
            }

            else if (SeatBox.Text != "")
            {



                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update BSTicket set SeatNo = '" + SeatBox.Text + "' where Ref = '" + Homepage.reff + "'";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                Payment pay = new Payment();
                pay.Show();
                this.Hide();
            }
        }

        private void SA1B_Click(object sender, EventArgs e)
        {
            SA1B.BackColor = Color.Green;
            count++;

            SA1B.Enabled = false;
            seatList += "A1,";
            SeatBox.Text = seatList;
        }

        private void SB1B_Click(object sender, EventArgs e)
        {
            SB1B.BackColor = Color.Green;
            count++;

            SB1B.Enabled = false;
            seatList += "B1,";
            SeatBox.Text = seatList;
        }

        private void SC1B_Click(object sender, EventArgs e)
        {
            SC1B.BackColor = Color.Green;
            count++;

            SC1B.Enabled = false;
            seatList += "C1,";
            SeatBox.Text = seatList;
        }

        private void SD1B_Click(object sender, EventArgs e)
        {
            SD1B.BackColor = Color.Green;
            count++;

            SD1B.Enabled = false;
            seatList += "D1,";
            SeatBox.Text = seatList;
        }

        private void SE1B_Click(object sender, EventArgs e)
        {
            SE1B.BackColor = Color.Green;
            count++;

            SE1B.Enabled = false;
            seatList += "E1,";
            SeatBox.Text = seatList;
        }

        private void SF1B_Click(object sender, EventArgs e)
        {
            SF1B.BackColor = Color.Green;
            count++;

            SF1B.Enabled = false;
            seatList += "F1,";
            SeatBox.Text = seatList;
        }

        private void SG1B_Click(object sender, EventArgs e)
        {
            SG1B.BackColor = Color.Green;
            count++;

            SG1B.Enabled = false;
            seatList += "G1,";
            SeatBox.Text = seatList;
        }

        private void SH1B_Click(object sender, EventArgs e)
        {
            SH1B.BackColor = Color.Green;
            count++;

            SH1B.Enabled = false;
            seatList += "H1,";
            SeatBox.Text = seatList;
        }

        private void SI1B_Click(object sender, EventArgs e)
        {
            SI1B.BackColor = Color.Green;
            count++;

            SI1B.Enabled = false;
            seatList += "I1,";
            SeatBox.Text = seatList;
        }

        private void SJ1B_Click(object sender, EventArgs e)
        {
            SJ1B.BackColor = Color.Green;
            count++;

            SJ1B.Enabled = false;
            seatList += "J1,";
            SeatBox.Text = seatList;
        }

        private void SA2B_Click(object sender, EventArgs e)
        {
            SA2B.BackColor = Color.Green;
            count++;

            SA2B.Enabled = false;
            seatList += "A2,";
            SeatBox.Text = seatList;
        }

        private void SB2B_Click(object sender, EventArgs e)
        {
            SB2B.BackColor = Color.Green;
            count++;

            SB2B.Enabled = false;
            seatList += "B2,";
            SeatBox.Text = seatList;
        }

        private void SC2B_Click(object sender, EventArgs e)
        {
            SC2B.BackColor = Color.Green;
            count++;

            SC2B.Enabled = false;
            seatList += "C2,";
            SeatBox.Text = seatList;
        }

        private void SD2B_Click(object sender, EventArgs e)
        {
            SD2B.BackColor = Color.Green;
            count++;

            SD2B.Enabled = false;
            seatList += "D2,";
            SeatBox.Text = seatList;
        }

        private void SE2B_Click(object sender, EventArgs e)
        {
            SE2B.BackColor = Color.Green;
            count++;

            SE2B.Enabled = false;
            seatList += "E2,";
            SeatBox.Text = seatList;
        }

        private void SF2B_Click(object sender, EventArgs e)
        {
            SF2B.BackColor = Color.Green;
            count++;

            SF2B.Enabled = false;
            seatList += "F2,";
            SeatBox.Text = seatList;
        }

        private void SG2B_Click(object sender, EventArgs e)
        {
            SG2B.BackColor = Color.Green;
            count++;

            SG2B.Enabled = false;
            seatList += "G2,";
            SeatBox.Text = seatList;
        }

        private void SH2B_Click(object sender, EventArgs e)
        {
            SH2B.BackColor = Color.Green;
            count++;

            SH2B.Enabled = false;
            seatList += "H2,";
            SeatBox.Text = seatList;
        }

        private void SI2B_Click(object sender, EventArgs e)
        {
            SI2B.BackColor = Color.Green;
            count++;

            SI2B.Enabled = false;
            seatList += "I2,";
            SeatBox.Text = seatList;
        }

        private void SJ2B_Click(object sender, EventArgs e)
        {
            SJ2B.BackColor = Color.Green;
            count++;

            SJ2B.Enabled = false;
            seatList += "J2,";
            SeatBox.Text = seatList;
        }

        private void SA3B_Click(object sender, EventArgs e)
        {
            SA3B.BackColor = Color.Green;
            count++;

            SA3B.Enabled = false;
            seatList += "A3,";
            SeatBox.Text = seatList;
        }

        private void SB3B_Click(object sender, EventArgs e)
        {
            SB3B.BackColor = Color.Green;
            count++;

            SB3B.Enabled = false;
            seatList += "B3,";
            SeatBox.Text = seatList;
        }

        private void SC3B_Click(object sender, EventArgs e)
        {
            SC3B.BackColor = Color.Green;
            count++;

            SC3B.Enabled = false;
            seatList += "C3,";
            SeatBox.Text = seatList;
        }

        private void SD3B_Click(object sender, EventArgs e)
        {
            SD3B.BackColor = Color.Green;
            count++;

            SD3B.Enabled = false;
            seatList += "D3,";
            SeatBox.Text = seatList;
        }

        private void SE3B_Click(object sender, EventArgs e)
        {
            SE3B.BackColor = Color.Green;
            count++;

            SE3B.Enabled = false;
            seatList += "E3,";
            SeatBox.Text = seatList;
        }

        private void SF3B_Click(object sender, EventArgs e)
        {
            SF3B.BackColor = Color.Green;
            count++;

            SF3B.Enabled = false;
            seatList += "F3,";
            SeatBox.Text = seatList;
        }

        private void SG3B_Click(object sender, EventArgs e)
        {
            SG3B.BackColor = Color.Green;
            count++;

            SG3B.Enabled = false;
            seatList += "G3,";
            SeatBox.Text = seatList;
        }

        private void SH3B_Click(object sender, EventArgs e)
        {
            SH3B.BackColor = Color.Green;
            count++;

            SH3B.Enabled = false;
            seatList += "H3,";
            SeatBox.Text = seatList;
        }

        private void SI3B_Click(object sender, EventArgs e)
        {
            SI3B.BackColor = Color.Green;
            count++;

            SI3B.Enabled = false;
            seatList += "I3,";
            SeatBox.Text = seatList;
        }

        private void SJ3B_Click(object sender, EventArgs e)
        {
            SJ3B.BackColor = Color.Green;
            count++;

            SJ3B.Enabled = false;
            seatList += "J3,";
            SeatBox.Text = seatList;
        }

        private void SA4B_Click(object sender, EventArgs e)
        {
            SA4B.BackColor = Color.Green;
            count++;

            SA4B.Enabled = false;
            seatList += "A4,";
            SeatBox.Text = seatList;
        }

        private void SB4B_Click(object sender, EventArgs e)
        {
            SB4B.BackColor = Color.Green;
            count++;

            SB4B.Enabled = false;
            seatList += "B4,";
            SeatBox.Text = seatList;
        }

        private void SC4B_Click(object sender, EventArgs e)
        {
            SC4B.BackColor = Color.Green;
            count++;

            SC4B.Enabled = false;
            seatList += "C4,";
            SeatBox.Text = seatList;
        }

        private void SD4B_Click(object sender, EventArgs e)
        {
            SD4B.BackColor = Color.Green;
            count++;

            SD4B.Enabled = false;
            seatList += "D4,";
            SeatBox.Text = seatList;
        }

        private void SE4B_Click(object sender, EventArgs e)
        {
            SE4B.BackColor = Color.Green;
            count++;

            SE4B.Enabled = false;
            seatList += "E4,";
            SeatBox.Text = seatList;
        }

        private void SF4B_Click(object sender, EventArgs e)
        {
            SF4B.BackColor = Color.Green;
            count++;

            SF4B.Enabled = false;
            seatList += "F4,";
            SeatBox.Text = seatList;
        }

        private void SG4B_Click(object sender, EventArgs e)
        {
            SG4B.BackColor = Color.Green;
            count++;

            SG4B.Enabled = false;
            seatList += "G4,";
            SeatBox.Text = seatList;
        }

        private void SH4B_Click(object sender, EventArgs e)
        {
            SH4B.BackColor = Color.Green;
            count++;

            SH4B.Enabled = false;
            seatList += "H4,";
            SeatBox.Text = seatList;
        }

        private void SI4B_Click(object sender, EventArgs e)
        {
            SI4B.BackColor = Color.Green;
            count++;

            SI4B.Enabled = false;
            seatList += "I4,";
            SeatBox.Text = seatList;
            

        }

        private void SJ4B_Click(object sender, EventArgs e)
        {
            SJ4B.BackColor = Color.Green;
            count++;

            SJ4B.Enabled = false;
            seatList += "J4,";
            SeatBox.Text = seatList;
        }

        private void SelectAgainB_Click(object sender, EventArgs e)
        {
            seatList = "";
            SeatBox.Text = seatList;

            count = 0;

            SA1B.Enabled = true;
            SA1B.BackColor = Color.Gainsboro;

            SA2B.Enabled = true;
            SA2B.BackColor = Color.Gainsboro;

            SA3B.Enabled = true;
            SA3B.BackColor = Color.Gainsboro;

            SA4B.Enabled = true;
            SA4B.BackColor = Color.Gainsboro;

            SB1B.Enabled = true;
            SB1B.BackColor = Color.Gainsboro;

            SB2B.Enabled = true;
            SB2B.BackColor = Color.Gainsboro;

            SB3B.Enabled = true;
            SB3B.BackColor = Color.Gainsboro;

            SB4B.Enabled = true;
            SB4B.BackColor = Color.Gainsboro;

            SC1B.Enabled = true;
            SC1B.BackColor = Color.Gainsboro;

            SC2B.Enabled = true;
            SC2B.BackColor = Color.Gainsboro;

            SC3B.Enabled = true;
            SC3B.BackColor = Color.Gainsboro;

            SC4B.Enabled = true;
            SC4B.BackColor = Color.Gainsboro;

            SD1B.Enabled = true;
            SD1B.BackColor = Color.Gainsboro;

            SD2B.Enabled = true;
            SD2B.BackColor = Color.Gainsboro;

            SD3B.Enabled = true;
            SD3B.BackColor = Color.Gainsboro;

            SD4B.Enabled = true;
            SD4B.BackColor = Color.Gainsboro;

            SE1B.Enabled = true;
            SE1B.BackColor = Color.Gainsboro;

            SE2B.Enabled = true;
            SE2B.BackColor = Color.Gainsboro;

            SE3B.Enabled = true;
            SE3B.BackColor = Color.Gainsboro;

            SE4B.Enabled = true;
            SE4B.BackColor = Color.Gainsboro;

            SF1B.Enabled = true;
            SF1B.BackColor = Color.Gainsboro;

            SF2B.Enabled = true;
            SF2B.BackColor = Color.Gainsboro;

            SF3B.Enabled = true;
            SF3B.BackColor = Color.Gainsboro;

            SF4B.Enabled = true;
            SF4B.BackColor = Color.Gainsboro;

            SG1B.Enabled = true;
            SG1B.BackColor = Color.Gainsboro;

            SG2B.Enabled = true;
            SG2B.BackColor = Color.Gainsboro;

            SG3B.Enabled = true;
            SG3B.BackColor = Color.Gainsboro;

            SG4B.Enabled = true;
            SG4B.BackColor = Color.Gainsboro;

            SH1B.Enabled = true;
            SH1B.BackColor = Color.Gainsboro;

            SH2B.Enabled = true;
            SH2B.BackColor = Color.Gainsboro;

            SH3B.Enabled = true;
            SH3B.BackColor = Color.Gainsboro;

            SH4B.Enabled = true;
            SH4B.BackColor = Color.Gainsboro;

            SI1B.Enabled = true;
            SI1B.BackColor = Color.Gainsboro;

            SI2B.Enabled = true;
            SI2B.BackColor = Color.Gainsboro;

            SI3B.Enabled = true;
            SI3B.BackColor = Color.Gainsboro;

            SI4B.Enabled = true;
            SI4B.BackColor = Color.Gainsboro;

            SJ1B.Enabled = true;
            SJ1B.BackColor = Color.Gainsboro;

            SJ2B.Enabled = true;
            SJ2B.BackColor = Color.Gainsboro;

            SJ3B.Enabled = true;
            SJ3B.BackColor = Color.Gainsboro;

            SJ4B.Enabled = true;
            SJ4B.BackColor = Color.Gainsboro;
        }
    }
}
