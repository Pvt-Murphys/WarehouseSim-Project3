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

            AddDataRow(
                Warehouse.totalCrates.ToString(),
                Warehouse.totalValue.ToString(),
                Warehouse.totalCost.ToString(),
                Warehouse.totalRevenue.ToString(),
                Warehouse.averageCrateVal.ToString(),
                Warehouse.averageTruckVal.ToString(),
                Warehouse.longestLine.ToString());

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
            Warehouse.Run();
            dataGridView1.Refresh();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
