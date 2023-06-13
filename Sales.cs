using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System.IO;
namespace EATS2GOV2
{
    public partial class frmSales : Form
    { 
        MySqlConnection conn = new MySqlConnection();
        public string connectionString = 
            "datasource=localhost;"+
            "port=3306;"+
            "database=eats2go;"+
            "username=root;"+
            "password='';";
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public frmSales()
        {
            InitializeComponent();
        }
        public DataGridView SalesDataGrid
        {// Property to access the dataSales DataGridView control
            get { return dataSales; }
        }
        // Loads the sales data from the database and inserts data into the the DataGridView 
        public void LoadSalesData()
        {
             conn = new MySqlConnection(connectionString);
            {
                dataSales.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM sales;", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // Add the sales data to the DataGridView dataSales
                    dataSales.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
                }
                conn.Close();
            }
        }
        // Retrieves sales data based on the specified date range and updates the DataGridView
        public void GetSalesData(DateTime fromDate, DateTime toDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                cmd = new MySqlCommand("SELECT * FROM sales WHERE transaction_date >= @fromDate AND transaction_date <= DATE_ADD(@toDate, INTERVAL 1 DAY)", conn);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable salesData = new DataTable();
                adapter.Fill(salesData);
                dataSales.Rows.Clear();
                //Iterates over the rows of the salesData DataTable.
                decimal totalSales = 0;
                foreach (DataRow row in salesData.Rows)
                {
                    // Add the sales data to the DataGridView
                    dataSales.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                    // Calculate the total sales
                    decimal price, quantity;
                    if (decimal.TryParse(row[2].ToString(), out price) && decimal.TryParse(row[3].ToString(), out quantity))
                    {
                        totalSales += price * quantity;
                    }
                }
                // Display the total sales in the textbox
                txtTotalSales.Text = totalSales.ToString("₱0.00");
            }
        }
        // Method to calculate the total sales of all time from the database
        private decimal CalculateTotalSalesAllTime()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT SUM(price * quantity) FROM sales";
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value && decimal.TryParse(result.ToString(), out decimal totalSales))
                {
                    return totalSales;
                }
                else { 
                return 0;
                    }
            }
        }
        //Load Form
        private void frmSales_Load_1(object sender, EventArgs e)
        {
            // Calculate and display the total sales of all time
            decimal totalSalesAllTime = CalculateTotalSalesAllTime();
            txtTotalSales.Text = totalSalesAllTime.ToString("₱0.00");
            LoadSalesData();
        }
        // Navigate back to the main form
        private void btnToMain_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            Hide();
        }
        // Retrieves sales data based on the selected date range and updates the DataGridView
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimeFrom.Value;
            DateTime toDate = dateTimeTo.Value;
            GetSalesData(fromDate, toDate);
        }
        private void frmSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Create a new Excel package
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Create a new worksheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("SalesData");
                // Write the headers
                for (int i = 0; i < dataSales.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataSales.Columns[i].HeaderText;
                }
                // Write the sales data
                for (int row = 0; row < dataSales.Rows.Count; row++)
                {
                    for (int col = 0; col < dataSales.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataSales.Rows[row].Cells[col].Value;
                    }
                }
                // Auto-fit columns
                worksheet.Cells.AutoFitColumns();
                // Calculate the total sales
                decimal totalSales = 0;
                foreach (DataGridViewRow row in dataSales.Rows)
                {
                    decimal price, quantity;
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out price) && decimal.TryParse(row.Cells[3].Value.ToString(), out quantity))
                    {
                        totalSales += price * quantity;
                    }
                }
                // Write the total sales
                worksheet.Cells[dataSales.Rows.Count + 2, dataSales.Columns.Count - 1].Value = "Total Sales:";
                worksheet.Cells[dataSales.Rows.Count + 2, dataSales.Columns.Count].Value = totalSales;
                // Save the Excel package to a file on disk
                string filePath = "C:\\Users\\Acer\\Desktop\\School\\EATS2GO V2\\SalesData.xlsx";
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }
            MessageBox.Show("Data exported successfully!", "Export Complete");
        }
    }
}