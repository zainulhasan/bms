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
    public partial class bloodsummary : MetroForm
    {
        public bloodsummary()
        {
            InitializeComponent();
        }

        private void bloodsummary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet5.blood' table. You can move, or remove it, as needed.
            this.bloodTableAdapter1.Fill(this.dbDataSet5.blood);
            // TODO: This line of code loads data into the 'dbDataSet4.blood' table. You can move, or remove it, as needed.
            //this.bloodTableAdapter.Fill(this.dbDataSet4.blood);

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            this.Hide();
            mf.Show();
        }
    }
}
