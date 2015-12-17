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
using MetroFramework.Forms;
namespace bms
{
    public partial class addDonor : MetroForm
    {
        public addDonor()
        {
            InitializeComponent();
        }

        private void addDonor_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            if (error.Text != "") { error.Text = ""; }
            string name = metroTextBox1.Text.Trim();
            string bloodtype = metroTextBox2.Text.Trim();
            string phone = metroTextBox3.Text.Trim();
            string email = metroTextBox7.Text.Trim();
            string address = metroTextBox4.Text.Trim();
            string city = metroTextBox5.Text.Trim();
            int age = Convert.ToInt32(metroTextBox6.Text.Trim());

            if (name == "" || bloodtype == "" || city == "" || email == "" || address == "" || phone == "" || age <= 0)
            {
                error.Text = "All Fields are Required.";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hassa\Source\Repos\bms\bms\bms\db.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string sql = "INSERT INTO [donor] (name,address,city,phone,email,age,bloodGroup) VALUES('" + name + "','" + address + "','" + city + "','" + phone + "','" + email + "','" + age + "','" + bloodtype + "')";
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
    }
}
