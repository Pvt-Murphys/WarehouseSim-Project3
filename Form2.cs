
///////////////////////////////////////////////////////////////////////////////
//
// Author: Riley O, owenrm1@etsu.edu, Josh, xxxx@xxx.xxx, Daniel L, lynchda@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 3
// Description: Displays simulation data to the user in a table, and allows the user to run the simulation again and also export 
// to a csv file.
//
///////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json.Linq;
using Project3;
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
        public int filepathnumber = 0;

        private DataTable dataTable;

        /// <summary>
        /// Initializes the form
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        /// <summary>
        /// Initalizes the Data tabel with the headers added via datatabe.columns.add
        /// </summary>
        private void InitializeDataTable()
        {
            // create data table columns
            dataTable = new DataTable();
            dataTable.Columns.Add("Total Crates", typeof(string));
            dataTable.Columns.Add("Total Value", typeof(string));
            dataTable.Columns.Add("Total Cost", typeof(string));
            dataTable.Columns.Add("Total Revenue", typeof(string));
            dataTable.Columns.Add("Average Crate Value", typeof(string));
            dataTable.Columns.Add("Average truck Value", typeof(string));
            dataTable.Columns.Add("Longest Line", typeof(string));

            // bind data table to grid view
            dataGridView1.DataSource = dataTable;
        }

        /// <summary>
        /// adds a row to the data table with the values passed in
        /// </summary>
        /// <param name="totalCrates"></param>
        /// <param name="totalValue"></param>
        /// <param name="totalCost"></param>
        /// <param name="totalRevenue"></param>
        /// <param name="averageCrateValue"></param>
        /// <param name="averageTruckValue"></param>
        /// <param name="longestLine"></param>
        public void AddDataRow(string totalCrates, string totalValue, string totalCost, string totalRevenue, string averageCrateValue, string averageTruckValue, string longestLine)
        {
            // Add a new row to the DataTable
            DataRow row = dataTable.NewRow();
            row["Total Crates"] = totalCrates;
            row["Total Value"] = totalValue;
            row["Total Cost"] = totalCost;
            row["Total Revenue"] = totalRevenue;
            row["Average Crate Value"] = averageCrateValue;
            row["Average Truck Value"] = averageTruckValue;
            row["Longest Line"] = longestLine;

            // Add the row to the DataTable
            dataTable.Rows.Add(row);
            dataGridView1.Refresh();
        }

        /// <summary>
        /// refreshes the data table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }
        /// <summary>
        /// checks if the string passed in is an integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsAnInteger(string value)
        {
            int number;
            return int.TryParse(value, out number);
        }

        /// <summary>
        /// allows user to enter a number number of docks and runs the simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterNumber_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;

            if (IsAnInteger(userInput))
            {
                int number = int.Parse(userInput);
                if (number > 0)
                {
                    Warehouse warehouse = new Warehouse(number);
                    warehouse.Run(this);
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Please enter a number greater than 0");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
            System.GC.Collect();
        }

        /// <summary>
        /// clears the data table and restores the header.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearTable_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            dataGridView1.Refresh();
        }

        /// <summary>
        /// loads the form and sets the enter button to the enter number button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            this.AcceptButton = EnterNumber;
            textBox1.Text = "Enter Dock Amount";
            textBox1.ForeColor = Color.Gray;
        }
        /// <summary>
        /// removes the default text in the text box when the user clicks on it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Dock Amount")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Gainsboro;
            }
        }
        /// <summary>
        /// places the default text back in the text box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Dock Amount";
                textBox1.ForeColor = Color.Gray;
            }
        }
        /// <summary>
        /// lets user hit the enter key to the run simulation button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EnterNumber.PerformClick();
                e.Handled = true;
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

