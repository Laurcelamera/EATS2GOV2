using MySql.Data.MySqlClient;
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
using System.Drawing.Printing;

namespace EATS2GOV2
{

    public partial class frmFood : Form
    {
        // Declare PrintDocument and PrintPreviewDialog variables
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        public frmFood()
        {
            InitializeComponent();
            // Initialize PrintDocument and PrintPreviewDialog
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
        }
        public string connectionString = 
            "datasource=localhost;" +
            "port=3306;" +
            "database=eats2go;" +
            "username=root;" +
            "password='';";
        // Method to establish connection with the database
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
        // Price for all food
        private double pitaPrice = 69.00;
        private double sandPrice = 35.00;
        private double tacoPrice = 70;
        private double eggdropPrice = 80;
        private double pestoPrice = 110;
        private double corndogPrice = 59.00;
        //Total prices for each beverage
        private double pitaTotalPrice;
        private double sandTotalPrice;
        private double tacoTotalPrice;
        private double eggdropTotalPrice;
        private double pestoTotalPrice;
        private double corndogTotalPrice;
        private double totalOrderPrice = 0;
        // Header and line separator for the receipt
        private string headerText = "\t\tEATS2GO FOODS" + Environment.NewLine;
        private string lineOfAsterisks = "\t************************************************" + Environment.NewLine;
        //Load Form
        private void frmFood_Load(object sender, EventArgs e)
        {
            // Properties for the receipt textbox
            txtReceipt.ScrollBars = RichTextBoxScrollBars.Both;
            txtReceipt.AppendText(headerText);
            txtReceipt.AppendText(lineOfAsterisks);
        }
        // Event for each food item button on the Menu (Order)
        private void btnPita_Click_1(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numPita.Value);
            pitaTotalPrice = pitaPrice * quantity;
            totalOrderPrice = pitaTotalPrice;
            AddItemToReceipt("EATS2GO Pita Wraps", quantity, pitaPrice, pitaTotalPrice);
        }
        private void btnSand_Click_1(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numSand.Value);
            sandTotalPrice = sandPrice * quantity;
            totalOrderPrice = sandTotalPrice;
            AddItemToReceipt("EATS2GO Sandwich", quantity, sandPrice, sandTotalPrice);
        }
        private void btnTaco_Click_1(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numTaco.Value);
            tacoTotalPrice = tacoPrice * quantity;
            totalOrderPrice = tacoTotalPrice;
            AddItemToReceipt("EATS2GO TACO", quantity, tacoPrice, tacoTotalPrice);
        }
        private void btnEgg_Click_1(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numEgg.Value);
            eggdropTotalPrice = eggdropPrice * quantity;
            totalOrderPrice = eggdropTotalPrice;
            AddItemToReceipt("EGG DROP SANDWICH", quantity, eggdropPrice, eggdropTotalPrice);
        }
        private void btnPesto_Click_1(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numPesto.Value);
            pestoTotalPrice = pestoPrice * quantity;
            totalOrderPrice = pestoTotalPrice;
            AddItemToReceipt("EATS2GO CHICKEN PESTO", quantity, pestoPrice, pestoTotalPrice);
        }
        private void btnCornd_Click_1(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numCornd.Value);
            corndogTotalPrice = corndogPrice * quantity;
            totalOrderPrice = corndogTotalPrice;
            AddItemToReceipt("CORN DOG", quantity, corndogPrice, corndogTotalPrice);
        }
        // Method to add an item to the receipt(receipt textbox)
        private void AddItemToReceipt(string item, int quantity, double unitPrice, double totalPrice)
        {
            txtReceipt.AppendText(Environment.NewLine);
            txtReceipt.AppendText($"Item: {item}{Environment.NewLine}");
            txtReceipt.AppendText($"Quantity: {quantity}{Environment.NewLine}");
            txtReceipt.AppendText($"Unit Price: ₱{unitPrice}{Environment.NewLine}");
            txtReceipt.AppendText($"Total Price: ₱{totalPrice}{Environment.NewLine}");
        }
        // Method to calculate the total order price
        private double CalculateTotalOrderPrice()
        {
            double totalOrderPrice = 0;
            int pitaQuantity = Convert.ToInt32(numPita.Value);
            double pitaTotalPrice = pitaPrice * pitaQuantity;
            totalOrderPrice += pitaTotalPrice;
            int sandQuantity = Convert.ToInt32(numSand.Value);
            double sandTotalPrice = sandPrice * sandQuantity;
            totalOrderPrice += sandTotalPrice;
            int tacoQuantity = Convert.ToInt32(numTaco.Value);
            double tacoTotalPrice = tacoPrice * tacoQuantity;
            totalOrderPrice += tacoTotalPrice;
            int eggQuantity = Convert.ToInt32(numEgg.Value);
            double eggTotalPrice = eggdropPrice * eggQuantity;
            totalOrderPrice += eggTotalPrice;
            int pestoQuantity = Convert.ToInt32(numPesto.Value);
            double pestoTotalPrice = pestoPrice * pestoQuantity;
            totalOrderPrice += pestoTotalPrice;
            int corndogQuantity = Convert.ToInt32(numCornd.Value);
            double corndogTotalPrice = corndogPrice * corndogQuantity;
            totalOrderPrice += corndogTotalPrice;
            return totalOrderPrice;
        }
        // Method to insert an item into the database
        private void InsertItemToDatabase(string item, int quantity, double price)
        {
            // Insert into the database
            using (MySqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO sales (item_name, price, quantity, transaction_date)" +
                    " VALUES (@itemName, @price, @quantity, @transactionDate)";
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
        //Event for Clear Button
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //Clear TextBox
            txtReceipt.Clear();
            txtReceipt.AppendText(headerText);
            txtReceipt.AppendText(lineOfAsterisks);
            // Clear numeric up-down controls
            numPita.Value = 0;
            numSand.Value = 0;
            numTaco.Value = 0;
            numEgg.Value = 0;
            numPesto.Value = 0;
            numCornd.Value = 0;
            txtCash.Clear();
            totalOrderPrice = 0;
        }
        //Event for Total button(Display TOTAL)
        private void btnTotal_Click_1(object sender, EventArgs e)
        {
            double totalOrderPrice = CalculateTotalOrderPrice();
            txtReceipt.AppendText(Environment.NewLine);
            txtReceipt.AppendText("Total Order Price: ₱" + totalOrderPrice + Environment.NewLine);
            txtReceipt.AppendText(lineOfAsterisks);
        }
        //Event for the Complete Order button
        private void btnCompleteOrder_Click_1(object sender, EventArgs e)
        {
            double totalOrderPrice = CalculateTotalOrderPrice();
            txtReceipt.AppendText(Environment.NewLine);
            txtReceipt.AppendText("Total Order Price: ₱" + totalOrderPrice.ToString("₱0.00") + Environment.NewLine);
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
                // Insert individual items into the database
                InsertItemToDatabase("EATS2GO Pita Wraps", Convert.ToInt32(numPita.Value), pitaPrice);
                InsertItemToDatabase("EATS2GO Sandwich", Convert.ToInt32(numSand.Value), sandPrice);
                InsertItemToDatabase("EATS2GO TACO", Convert.ToInt32(numTaco.Value), tacoPrice);
                InsertItemToDatabase("EGG DROP SANDWICH", Convert.ToInt32(numEgg.Value), eggdropPrice);
                InsertItemToDatabase("EATS2GO CHICKEN PESTO", Convert.ToInt32(numPesto.Value), pestoPrice);
                InsertItemToDatabase("CORN DOG", Convert.ToInt32(numCornd.Value), corndogPrice);
            }
            else
            {
                MessageBox.Show("Insufficient cash. Please provide more funds.");
                txtReceipt.AppendText("Insufficient cash. Please provide more funds." + Environment.NewLine);
            }
            txtReceipt.AppendText(lineOfAsterisks);
        }
        // Event for printing the receipt
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
        //Event for Printing Receipt
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
        //Navigate to BEverages form
        private void btnDrinks_Click_1(object sender, EventArgs e)
        {
            frmBeverages Drinks = new frmBeverages();
            Drinks.Show();
            this.Hide();
        }
        //Navigate to Desserts form
        private void DESSERT_Click_1(object sender, EventArgs e)
        {
            frmDessert Dessert = new frmDessert();
            Dessert.Show();
            this.Hide();
        }
        //Navigate to Dashboard/Main form
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
        //Return to Login
        private void BtnSignout_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }
        //Close form
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
