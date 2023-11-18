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
        /// 
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsAnInteger(string value)
        {
            int number;
            return int.TryParse(value, out number);
        }

        /// <summary>
        /// 
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
        /// Takes the user to the excel file that was created for crate info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportFile_Click(object sender, EventArgs e)
        {
             
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

