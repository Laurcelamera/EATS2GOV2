using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EATS2GOV2
{
    public partial class frmBeverages : Form
    {
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        public string connectionString =
            "datasource=localhost;" +
            "port=3306;" +
            "database=eats2go;" +
            "username=root;" +
            "password='';";
        private MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
                return null;
            }
        }
        public frmBeverages()
        {
            InitializeComponent();
        }

        private double bukoPrice = 25.00;
        private double cranPrice = 60.00;
        private double lemonPrice = 60.00;
        private double orangePrice = 50.00;
        private double icedteaPrice = 40.00;
        private double waterPrice = 15.00;
        private double bukoTotalPrice;
        private double cranTotalPrice;
        private double lemonTotalPrice;
        private double orangeTotalPrice;
        private double icedteaTotalPrice;
        private double waterTotalPrice;
        private double totalOrderPrice = 0;

        private string headerText = "\t\tEATS2GO FOODS" + Environment.NewLine;
        private string lineOfAsterisks = "\t************************************************" + Environment.NewLine;

        private void frmBeverages_Load(object sender, EventArgs e)
        {
            txtReceipt.ReadOnly = true;
            txtReceipt.ScrollBars = RichTextBoxScrollBars.Both;
            txtReceipt.AppendText(headerText);
            txtReceipt.AppendText(lineOfAsterisks);
        }
        private void AddItemToReceipt(string item, int quantity, double unitPrice, double totalPrice)
        {
            txtReceipt.AppendText(Environment.NewLine);
            txtReceipt.AppendText($"Item: {item}{Environment.NewLine}");
            txtReceipt.AppendText($"Quantity: {quantity}{Environment.NewLine}");
            txtReceipt.AppendText($"Unit Price: ₱{unitPrice}{Environment.NewLine}");
            txtReceipt.AppendText($"Total Price: ₱{totalPrice}{Environment.NewLine}");
        }
        private double CalculateTotalOrderPrice()
        {
            double totalOrderPrice = 0;

            int bukoQuantity = Convert.ToInt32(numBJ.Value);
            double bukoTotalPrice = bukoPrice * bukoQuantity;
            totalOrderPrice += bukoTotalPrice;

            int cranQuantity = Convert.ToInt32(numCJ.Value);
            double cranTotalPrice = cranPrice * cranQuantity;
            totalOrderPrice += cranTotalPrice;

            int lemonQuantity = Convert.ToInt32(numLemonade.Value);
            double lemonTotalPrice = lemonPrice * lemonQuantity;
            totalOrderPrice += lemonTotalPrice;

            int orangeQuantity = Convert.ToInt32(numOJ.Value);
            double orangeTotalPrice = orangePrice * orangeQuantity;
            totalOrderPrice += orangeTotalPrice;

            int icedteaQuantity = Convert.ToInt32(numIT.Value);
            double icedteaTotalPrice = icedteaPrice * icedteaQuantity;
            totalOrderPrice += icedteaTotalPrice;

            int waterQuantity = Convert.ToInt32(numWater.Value);
            double waterTotalPrice = waterPrice * waterQuantity;
            totalOrderPrice += waterTotalPrice;

            return totalOrderPrice;
        }
        private void InsertItemToDatabase(string item, int quantity, double price)
        {
            // Insert into the database
            using (MySqlConnection connection = GetConnection())
            {

                string query = "INSERT INTO sales (item_name, price, quantity, transaction_date) VALUES (@itemName, @price, @quantity, @transactionDate)";
                MySqlCommand command = new MySqlCommand(query, connection);
                if (quantity > 0)
                {
                    command.Parameters.AddWithValue("@itemName", item);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void btnBJ_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numBJ.Value);
            bukoTotalPrice = bukoPrice * quantity;
            totalOrderPrice = bukoTotalPrice;
            AddItemToReceipt("BUKO JUICE", quantity, bukoPrice, bukoTotalPrice);
        }

        private void btnCJ_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numCJ.Value);
            cranTotalPrice = cranPrice * quantity;
            totalOrderPrice = cranTotalPrice;
            AddItemToReceipt("CRANBERRY JUICE", quantity, cranPrice, cranTotalPrice);
        }

        private void btnLemon_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numLemonade.Value);
            lemonTotalPrice = lemonPrice * quantity;
            totalOrderPrice = lemonTotalPrice;
            AddItemToReceipt("LEMONADE", quantity, lemonPrice, lemonTotalPrice);
        }

        private void btnOJ_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numOJ.Value);
            orangeTotalPrice = orangePrice * quantity;
            totalOrderPrice = orangeTotalPrice;
            AddItemToReceipt("ORANGE JUICE", quantity, orangePrice, orangeTotalPrice);
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numIT.Value);
            icedteaTotalPrice = icedteaPrice * quantity;
            totalOrderPrice = icedteaTotalPrice;
            AddItemToReceipt("ICED TEA", quantity, icedteaPrice, icedteaTotalPrice);
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numWater.Value);
            waterTotalPrice = waterPrice * quantity;
            totalOrderPrice = waterTotalPrice;
            AddItemToReceipt("WATER", quantity, waterPrice, waterTotalPrice);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceipt.Clear();
            txtReceipt.AppendText(headerText);
            txtReceipt.AppendText(lineOfAsterisks);

            // Clear numeric up-down controls
            numBJ.Value = 0;
            numCJ.Value = 0;
            numLemonade.Value = 0;
            numOJ.Value = 0;
            numIT.Value = 0;
            numWater.Value = 0;
            txtCash.Clear();
            totalOrderPrice = 0;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double totalOrderPrice = CalculateTotalOrderPrice();
            txtReceipt.AppendText(Environment.NewLine);
            txtReceipt.AppendText("Total Order Price: ₱" + totalOrderPrice + Environment.NewLine);
            txtReceipt.AppendText(lineOfAsterisks);
        }

        private void btnCompleteOrder_Click_1(object sender, EventArgs e)
        {
            double totalOrderPrice = CalculateTotalOrderPrice();
            txtReceipt.AppendText(Environment.NewLine);
            txtReceipt.AppendText("Total Order Price: ₱" + totalOrderPrice.ToString("0.00") + Environment.NewLine);
            double cashInput;
            if (!double.TryParse(txtCash.Text, out cashInput))
            {
                MessageBox.Show("Invalid cash input. Please enter a valid amount.");
                return;
            }

            double change = cashInput - totalOrderPrice;

            txtReceipt.AppendText("Cash Input: ₱" + cashInput.ToString("0.00") + Environment.NewLine);
            if (change >= 0)
            {
                txtReceipt.AppendText("Change: ₱" + change.ToString("0.00") + Environment.NewLine);
            }
            else
            {
                txtReceipt.AppendText("Insufficient cash. Please provide more funds." + Environment.NewLine);
            }
            txtReceipt.AppendText(lineOfAsterisks);
            InsertItemToDatabase("BUKO JUICE", Convert.ToInt32(numBJ.Value), bukoPrice);
            InsertItemToDatabase("CRANBERRY JUICE", Convert.ToInt32(numCJ.Value), cranPrice);
            InsertItemToDatabase("LEMONADE", Convert.ToInt32(numLemonade.Value), lemonPrice);
            InsertItemToDatabase("ORANGE JUICE", Convert.ToInt32(numOJ.Value), orangePrice);
            InsertItemToDatabase("ICED TEA", Convert.ToInt32(numIT.Value), icedteaPrice);
            InsertItemToDatabase("WATER", Convert.ToInt32(numWater.Value), waterPrice);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            frmFood food = new frmFood();
            food.Show();
            this.Hide();
        }
        private void DESSERT_Click(object sender, EventArgs e)
        {
            frmDessert Dessert = new frmDessert();
            Dessert.Show();
            this.Hide();
        }
        private void frmBeverages_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define the content and layout of the printed receipt
            Font font = txtReceipt.Font;
            Brush brush = new SolidBrush(txtReceipt.ForeColor);
            float lineHeight = font.GetHeight(e.Graphics);
            float currentY = 0;

            string receiptContent = txtReceipt.Text;

            // Print each line of the receipt
            string[] lines = receiptContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, font, brush, 0, currentY);
                currentY += lineHeight;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Adjust paper size
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", txtReceipt.Width, txtReceipt.Height);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void BtnSignout_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
