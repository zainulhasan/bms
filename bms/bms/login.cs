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
    public partial class login : MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            metroLabel4.Text = localDate.ToString();
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            if (error.Text != "")
            {
                error.Text = "";
            }
            string username;
            string password;

            username = metroTextBox1.Text.Trim();
            password = metroTextBox2.Text.Trim();

            if (username == "" || password == "")
            {
                error.Text = "All Feilds are required.";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hassa\Source\Repos\bms\bms\bms\db.mdf;Integrated Security=True"))
                {

                    conn.Open();
                    string query = "SELECT * FROM [user] WHERE username='" + username + "' AND password='" + password + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        mainForm mf = new mainForm();
                        mf.Show();
                        this.Hide();

                    }
                    else
                    {

                        error.Text = "Invalid Username/Password.";

                    }

                    conn.Close();
                    conn.Dispose();

                }
            }
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
