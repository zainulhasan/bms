﻿using System;
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
    public partial class searchBlood : MetroForm
    {
        public searchBlood()
        {
            InitializeComponent();
        }

        private void searchBlood_Load(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {

            string query = metroTextBox1.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hassa\Source\Repos\bms\bms\bms\db.mdf;Integrated Security=True"))
            {

                conn.Open();
                string sql = "SELECT * FROM [blood] WHERE bloodGroup LIKE '" + query + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                metroGrid1.DataSource = ds.Tables[0];


                conn.Close();
                conn.Dispose();

            }

        }
    }
}
