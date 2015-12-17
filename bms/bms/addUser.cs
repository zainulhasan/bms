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
using System.Data.SqlClient;


namespace bms
{
    public partial class addUser : MetroForm
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            if (error.Text != "") { error.Text = ""; }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            this.Hide();
            mf.Show();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            if (error.Text != "") { error.Text = ""; }
            string name=metroTextBox1.Text.Trim();
            string username=metroTextBox2.Text.Trim();
            string password = metroTextBox3.Text.Trim();
            string email = metroTextBox7.Text.Trim();
            string address = metroTextBox4.Text.Trim();
            string phone = metroTextBox5.Text.Trim();
            int age = Convert.ToInt32(metroTextBox6.Text.Trim());

            if (name == "" || username == "" || password == "" || email == "" || address == "" || phone == "" || age <=0)
            {
                error.Text = "All Fields are Required.";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hassa\Source\Repos\bms\bms\bms\db.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    conn.Close();
                    conn.Dispose();
                }
            }

        }
    }
}
