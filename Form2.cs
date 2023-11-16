﻿using Newtonsoft.Json.Linq;
using Project3;
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
    public partial class Form2 : Form
    {
        private DataTable dataTable;
        public Form2()
        {
            InitializeComponent();
            InitializeDataTable();
        }

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

            //AddDataRow(
            //    warehouse.totalCrates.ToString(),
            //    warehouse.totalValue.ToString(),
            //    warehouse.totalCost.ToString(),
            //    warehouse.totalRevenue.ToString(),
            //    warehouse.averageCrateVal.ToString(),
            //    warehouse.averageTruckVal.ToString(),
            //    warehouse.longestLine.ToString());

            // bind data table to grid view
            dataGridView1.DataSource = dataTable;
        }
        private void AddDataRow(string totalCrates, string totalValue, string totalCost, string totalRevenue, string averageCrateValue, string averageTruckValue, string longestLine)
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
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            dataGridView1.Refresh();
        }
        private bool IsAnInteger(string value)
        {
            int number;
            return int.TryParse(value, out number);
        }
        private void EnterNumber_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;

            if (IsAnInteger(userInput))
            {
                int number = int.Parse(userInput);
                if (number > 0)
                {
                    Warehouse warehouse = new Warehouse(number);
                    warehouse.Run();
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
        }
        private void ExportFile_Click(object sender, EventArgs e)
        {

        }

        public static void RecordCrate(Crate crate, Truck truck, String crateStatus)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

