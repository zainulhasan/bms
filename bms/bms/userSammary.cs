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
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.IO;


namespace bms
{
    public partial class userSammary : MetroForm
    {
        public userSammary()
        {
            InitializeComponent();
        }

        private void userSammary_Load(object sender, EventArgs e)
        {

            DateTime localDate = DateTime.Now;
            metroLabel4.Text = localDate.ToString();
            // TODO: This line of code loads data into the 'dbDataSet1.user' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.dbDataSet1.user);
            // TODO: This line of code loads data into the 'dbDataSet.user' table. You can move, or remove it, as needed.
           // this.userTableAdapter.Fill(this.dbDataSet.user);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



       

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }  
    }
}
