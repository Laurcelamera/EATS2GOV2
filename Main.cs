using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EATS2GOV2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        // Method to insert data into the sales chart
        private void PopulateSalesChart()
        {
            //Series = collection of data points on the chart
            // Clear existing series data
            chartSales.Series.Clear();
            // New series for the chart
            Series series = new Series("Top 5 Most Bought Items");
            series.ChartType = SeriesChartType.Bar;
            // Retrieve sales data from the frmSales form
            frmSales salesForm = new frmSales();
            // Load the sales data from the database
            salesForm.LoadSalesData(); 
            // Access the salesDataGrid DataGridView from the frmSales form
            DataGridView salesDataGrid = salesForm.SalesDataGrid;
            // Dictionary to store total sales per item
            Dictionary<string, decimal> itemSales = new Dictionary<string, decimal>();
            // Iterate through each row in the salesDataGrid
            foreach (DataGridViewRow row in salesDataGrid.Rows)
            {
                // Item Name is the 2nd Column
                string itemName = row.Cells[1].Value.ToString();
                // Price is the 3rd Column
                decimal price = Convert.ToDecimal(row.Cells[2].Value);
                // Quantity is the 4th Column
                decimal quantity = Convert.ToDecimal(row.Cells[3].Value);
                decimal salesAmount = price * quantity;
                // Add the sales amount to the total for the corresponding item
                if (itemSales.ContainsKey(itemName))
                {
                    itemSales[itemName] += salesAmount;
                }
                else
                {
                    itemSales[itemName] = salesAmount;
                }
            }
            // Sort the item sales in descending order and select the top 5 items
            var topItems = itemSales.OrderByDescending(x => x.Value).Take(5);
            // Add a data point to the series for each top item
            foreach (var item in topItems)
            {
                string itemName = item.Key;
                decimal salesAmount = item.Value;
                series.Points.AddXY(itemName, salesAmount);
            }
            // Add the series to the chart
            chartSales.Series.Add(series);
        }
        // Event for the form closed event
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Event for the POS button click (Will open the POS/Menu Form)
        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmMenu form4 = new frmMenu();
            form4.Show();
            this.Hide();
        }
        // Event for the Inventory button click
        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            frmInventory form3 = new frmInventory();
            form3.Show();
            this.Hide();
        }
        // Event for the Sales button click
        private void btnSales_Click_1(object sender, EventArgs e)
        {
            frmSales form5 = new frmSales();
            form5.Show();
            this.Hide();
        }
        // Event for the Sign Out button click (Return to Login)
        private void BtnSignout_Click_1(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }
        // Event for the Shutdown button click(Closes the Program)
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Event for the form load event
        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateSalesChart();
        }
    }
}
