﻿///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley Owen, owenrm1@etsu.edu, Josh , Daniel
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description: 
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadinganimationgif_Click(object sender, EventArgs e)
        {

        }

        private void GoToSimulation_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
