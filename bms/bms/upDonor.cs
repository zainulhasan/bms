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
    public partial class upDonor : MetroForm
    {
        public upDonor()
        {
            InitializeComponent();
        }

        private void upDonor_Load(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hassa\Source\Repos\bms\bms\bms\db.mdf;Integrated Security=True"))
            {
                conn.Open();
                string sql = "UPDATE [donor]";
                sql += "SET name='" + name_lab.Text + "', address='" + address_lab.Text + "', phone='" + phone_lab.Text + "', email='" + email_lab.Text + "', age='" + int.Parse(age_lab.Text) + "'";
                sql += "WHERE email='" + email_lab.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Modified");
                conn.Close();
                conn.Dispose();
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
