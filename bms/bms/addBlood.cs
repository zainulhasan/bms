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
    public partial class addBlood : MetroForm
    {
        public addBlood()
        {
            InitializeComponent();
        }

        private void addBlood_Load(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            string name = user_lab.Text;
            string donorname = donor_lab.Text;
            string phone = phone_lab.Text;
            string email = email_lab.Text;
            int age = int.Parse(age_lab.Text);
            string bloodtype = blood_lab.Text;
            string address = address_lab.Text;
            string date = date_lab.Text;

            if (error.Text != "") { error.Text = ""; }

            if (name == "" || bloodtype == "" || date == "" || email == "" || address == "" || phone == "" || age <= 0)
            {
                error.Text = "All Fields are Required.";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hassa\Source\Repos\bms\bms\bms\db.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string sql = "INSERT INTO [blood] (userName,address,donorName,phone,email,age,bloodGroup,date) VALUES('" + name + "','" + address + "','" + donorname + "','" + phone + "','" + email + "','" + age + "','" + bloodtype + "','"+date+"')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    MessageBox.Show(sql);
                    cmd.ExecuteNonQuery();
                    mainForm mf = new mainForm();
                    this.Hide();
                    mf.Show();
                    MessageBox.Show("New Donor Added.");
                    conn.Close();
                    conn.Dispose();
                }
            }




        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            this.Hide();
             mf.Show();
        }
    }
}
