﻿using System;
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

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            addUser ad = new addUser();
            this.Hide();
            ad.Show();
        }

        
        
    }
}