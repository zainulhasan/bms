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
    public partial class donorSummary : MetroForm
    {
        public donorSummary()
        {
            InitializeComponent();
        }

        private void donorSummary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet3.donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter1.Fill(this.dbDataSet3.donor);
            // TODO: This line of code loads data into the 'dbDataSet2.donor' table. You can move, or remove it, as needed.
            //this.donorTableAdapter.Fill(this.dbDataSet2.donor);

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            this.Show();
            mf.Show();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
