using Newtonsoft.Json.Linq;
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

            // bind data table to grid view
            dataGridView1.DataSource = dataTable;
        }
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
        private void ExportFile_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// clears the data table and restores the headder 
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
            this.AcceptButton = EnterNumber;
            textBox1.Text = "Enter Dock Amount";
            textBox1.ForeColor = Color.Gray;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Dock Amount")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Gainsboro;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Dock Amount";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void EnterNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EnterNumber.PerformClick();
                e.Handled = true;
            }
        }
        public static void RecordCrate(Crate crate, Truck truck, String crateStatus)
        {

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

