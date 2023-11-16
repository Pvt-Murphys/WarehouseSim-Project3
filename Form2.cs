<<<<<<< Updated upstream
﻿using Project3;
=======
﻿///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley O, owenrm1@etsu.edu, Josh, xxxx@xxx.xxx, Daniel L, lynchda@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description: Displays simulation data to the user in a table, and allows the user to run the simulation again and also export 
// To a csv file.
//
///////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json.Linq;
using Project3;
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //crate info 

            //Time increment that each crate was unloaded
            //The truck drivers name
            //The delivery company's name
            //The crate ID number
            //The crates value
            //A string indicated the one of three scenarios.

            FileStream fs = new FileStream("simulationresults.csv", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //.Text = $"{Driver.totalTrucks}: Total trucks\r\n{Driver.totalCrates}: Total crates\r\n{Driver.totalValue}: Total value earned from crates \r\n{Driver.totalCost}: totalCost in operating costs \r\n{Driver.totalRevenue}: Total overall revenue of sim.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
