using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace bms
{
    public partial class mainForm : MetroForm
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('f')[0];
            metroLabel2.Text = date;
            day_lab.Text = date;
            int d = (int)System.DateTime.Now.DayOfWeek;
            if (d == 0)
            {
                day_lab.Text = "Sunday";
            }
            else if (d == 1)
            {
                day_lab.Text = "Monday";
            }else if(d==2){
                day_lab.Text = "Tuesday";
            }
            else if (d == 3)
            {
                day_lab.Text="Wednesday";

            }else if(d==4){

                day_lab.Text = "Thursday";
            }
            else if (d == 5)
            {
                day_lab.Text = "Friday";
            }
            else
            {
                day_lab.Text = "Satureday";
            }
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            userSummary us = new userSummary();
            this.Hide();
            us.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            donorSummary ds = new donorSummary();
            this.Hide();
            ds.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            searchDonor ad = new searchDonor();
            this.Hide();
            ad.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            addUser ad = new addUser();
            this.Hide();
            ad.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            addDonor ad = new addDonor();
            this.Hide();
            ad.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            bloodsummary bs = new bloodsummary();
            this.Hide();
            bs.Show();
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            searchBlood sr = new searchBlood();
            this.Hide();
            sr.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            upUser up = new upUser();
            this.Hide();
            up.Show();
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            upDonor ap = new upDonor();
            this.Hide();
            ap.Show();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            findUser fn = new findUser();
            this.Hide();
            fn.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            addBlood ad = new addBlood();
            this.Hide();
            ad.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        
        
    }
}
