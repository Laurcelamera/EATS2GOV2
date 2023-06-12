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
        private void PopulateSalesChart()
        {
    // Clear existing series data
    chartSales.Series.Clear();

    // Create a new series for the chart
    Series series = new Series("Top 5 Most Bought Items");
    series.ChartType = SeriesChartType.Bar;

    // Retrieve sales data from the frmSales form
    frmSales salesForm = new frmSales();
    salesForm.LoadSalesData(); // Load the sales data from the database

    // Access the dataSales DataGridView from the frmSales form
    DataGridView salesDataGrid = salesForm.SalesDataGrid;

    // Dictionary to store total sales per item
    Dictionary<string, decimal> itemSales = new Dictionary<string, decimal>();

    // Iterate through each row in the salesDataGrid
    foreach (DataGridViewRow row in salesDataGrid.Rows)
    {
        string itemName = row.Cells[1].Value.ToString(); // Assuming item name is in the second column
        decimal price = Convert.ToDecimal(row.Cells[2].Value); // Assuming price is in the third column
        decimal quantity = Convert.ToDecimal(row.Cells[3].Value); // Assuming quantity is in the fourth column

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
        private void picsignOut_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmMenu form4 = new frmMenu();
            form4.Show();
            this.Hide();
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            frmInventory form3 = new frmInventory();
            form3.Show();
            this.Hide();
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            frmSales form5 = new frmSales();
            form5.Show();
            this.Hide();
        }

        private void BtnSignout_Click_1(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateSalesChart();
        }
    }
}
