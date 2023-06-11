using Org.BouncyCastle.Asn1.X509;
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
using Org.BouncyCastle.Asn1.X500;

namespace EATS2GOV2
{
    public partial class frmSales : Form
    {
        MySqlCommand cmd;
        MySqlDataReader rdr;
        MySqlConnection conn = new MySqlConnection();
      public string connectionString = "datasource=localhost;port=3306;database=eats2go;username=root;password='';";
        private decimal totalSales = 0;
        public frmSales()
        {
            InitializeComponent();
        }

        private void LoadSalesData()
        {

            conn = new MySqlConnection(connectionString);
            {
                dataSales.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM sales;", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataSales.Rows.Add(rdr.GetString(0), rdr.GetString(1),
                        rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
                }
                conn.Close();
            }
        }
        private void GetSalesData(DateTime fromDate, DateTime toDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM sales WHERE transaction_date >= @fromDate AND transaction_date <= @toDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable salesData = new DataTable();
                adapter.Fill(salesData);
                dataSales.Rows.Clear();

                decimal totalSales = 0; // Calculate the total sales

                foreach (DataRow row in salesData.Rows)
                {
                    dataSales.Rows.Add(row[0], row[1], row[2], row[3], row[4]);

                    // Calculate the total sales
                    decimal price, quantity;
                    if (decimal.TryParse(row[2].ToString(), out price) && decimal.TryParse(row[3].ToString(), out quantity))
                    {
                        totalSales += price * quantity;
                    }
                }

                // Display the total sales in the textbox
                txtTotalSales.Text = totalSales.ToString("0.00");
            }
        }

        private void frmSales_Load_1(object sender, EventArgs e)
        {
            LoadSalesData();
        }


        private void btnToMain_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

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
    }
}