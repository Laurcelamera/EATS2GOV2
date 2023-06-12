﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace EATS2GOV2
{
    public partial class frmDessert : Form
    {
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        public string connectionString =
            "datasource=localhost;" +
            "port=3306;" +
            "database=eats2go;" +
            "username=root;" +
            "password='';";
        MySqlCommand cmd;
        MySqlDataReader rdr;
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
        public frmDessert()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
        }
        private double halohaloPrice =150.00;
        private double carSundaePrice = 40.00;
        private double strawSundaePrice = 40.00;
        private double chCakePrice = 65.00;
        private double bluPiePrice = 65.00;
        private double bTartPrice = 30.00;
        private double halohaloTotalPrice;
        private double carSundaeTotalPrice;
        private double strawSundaeTotalPrice;
        private double chCakeTotalPrice;
        private double bluPieTotalPrice;
        private double bTartTotalPrice;
        private double totalOrderPrice = 0;

        private string headerText = "\t\tEATS2GO FOODS" + Environment.NewLine;
        private string lineOfAsterisks = "\t************************************************" + Environment.NewLine;

        private void frmDessert_Load(object sender, EventArgs e)
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

        private void btnHalo_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numHalo.Value);
            halohaloTotalPrice = halohaloPrice * quantity;
            totalOrderPrice = halohaloTotalPrice;
            AddItemToReceipt("HALO-HALO", quantity, halohaloPrice, halohaloTotalPrice);
        }

        private void btnCaSundae_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numCaSundae.Value);
            carSundaeTotalPrice = carSundaePrice * quantity;
            totalOrderPrice = carSundaeTotalPrice;
            AddItemToReceipt("CARAMEL SUNDAE", quantity, carSundaePrice, carSundaeTotalPrice);
        }

        private void btnStSundae_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numStSundae.Value);
            strawSundaeTotalPrice = strawSundaePrice * quantity;
            totalOrderPrice = strawSundaeTotalPrice;
            AddItemToReceipt("STRAWBERRY SUNDAE", quantity, strawSundaePrice, strawSundaeTotalPrice);

        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numChCake.Value);
            chCakeTotalPrice = chCakePrice * quantity;
            totalOrderPrice = chCakeTotalPrice;
            AddItemToReceipt("CHEESE CAKE", quantity, chCakePrice, chCakeTotalPrice);
        }

        private void btnBpie_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numBlPie.Value);
            bluPieTotalPrice = bluPiePrice * quantity;
            totalOrderPrice = bluPieTotalPrice;
            AddItemToReceipt("BLUEBERRY PIE", quantity, bluPiePrice, bluPieTotalPrice);
        }

        private void btnBtarts_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numBtarts.Value);
            bTartTotalPrice = bTartPrice * quantity;
            totalOrderPrice = bTartTotalPrice;
            AddItemToReceipt("BUTTER TARTS", quantity, bTartPrice, bTartTotalPrice);

        }
        private double CalculateTotalOrderPrice()
        {
            double totalOrderPrice = 0;

            int halohaloQuantity = Convert.ToInt32(numHalo.Value);
            double halohaloTotalPrice = halohaloPrice * halohaloQuantity;
            totalOrderPrice += halohaloTotalPrice;

            int carSundaeQuantity = Convert.ToInt32(numCaSundae.Value);
            double carSundaeTotalPrice = carSundaePrice * carSundaeQuantity;
            totalOrderPrice += carSundaeTotalPrice;

            int strawSundaeQuantity = Convert.ToInt32(numStSundae.Value);
            double strawSundaeTotalPrice = strawSundaePrice * strawSundaeQuantity;
            totalOrderPrice += strawSundaeTotalPrice;

            int chCakeQuantity = Convert.ToInt32(numChCake.Value);
            double chCakeTotalPrice = chCakePrice * chCakeQuantity;
            totalOrderPrice += chCakeTotalPrice;

            int bluePieQuantity = Convert.ToInt32(numBlPie.Value);
            double bluePieTotalPrice = bluPiePrice * bluePieQuantity;
            totalOrderPrice += bluePieTotalPrice;

            int bTartQuantity = Convert.ToInt32(numBtarts.Value);
            double bTartTotalPrice = bTartPrice * bTartQuantity;
            totalOrderPrice += bTartTotalPrice;

            return totalOrderPrice;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceipt.Clear();
            txtReceipt.AppendText(headerText);
            txtReceipt.AppendText(lineOfAsterisks);

            // Clear numeric up-down controls
            numHalo.Value = 0;
            numCaSundae.Value = 0;
            numStSundae.Value = 0;
            numChCake.Value = 0;
            numBlPie.Value = 0;
            numBtarts.Value = 0;
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

        private void btnCompleteOrder_Click(object sender, EventArgs e)
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
            InsertItemToDatabase("HALO-HALO", Convert.ToInt32(numHalo.Value), halohaloPrice);
            InsertItemToDatabase("CARAMEL SUNDAE", Convert.ToInt32(numCaSundae.Value), carSundaePrice);
            InsertItemToDatabase("STRAWBERRY SUNDAE", Convert.ToInt32(numStSundae.Value), strawSundaePrice);
            InsertItemToDatabase("CHEESE CAKE", Convert.ToInt32(numChCake.Value), chCakePrice);
            InsertItemToDatabase("BLUEBERRY PIE", Convert.ToInt32(numBlPie.Value), bluPiePrice);
            InsertItemToDatabase("BUTTER TARTS", Convert.ToInt32(numBtarts.Value), bTartPrice);
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
        private void btnFood_Click_1(object sender, EventArgs e)
        {
            frmFood food = new frmFood();
            food.Show();
            this.Hide();
        }

        private void btnDrinks_Click_1(object sender, EventArgs e)
        {
            frmBeverages Drinks = new frmBeverages();
            Drinks.Show();
            this.Hide();
        }

        private void DESSERT_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void frmDessert_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
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
