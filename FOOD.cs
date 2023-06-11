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

namespace EATS2GOV2
{
    public partial class frmFood : Form
    {
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

        private double pitaPrice = 69.00;
        private double sandPrice = 35.00;
        private double tacoPrice = 70;
        private double eggdropPrice = 80;
        private double pestoPrice = 110;
        private double corndogPrice = 59.00;
        private double pitaTotalPrice;
        private double sandTotalPrice;
        private double tacoTotalPrice;
        private double eggdropTotalPrice;
        private double pestoTotalPrice;
        private double corndogTotalPrice;
        private double totalOrderPrice = 0;

        private string headerText = "\t\tEATS2GO FOODS" + Environment.NewLine;
        private string lineOfAsterisks = "\t************************************************" + Environment.NewLine;
        private void frmFood_Load(object sender, EventArgs e)
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
        private void btnPita_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numPita.Value);
            pitaTotalPrice = pitaPrice * quantity;
            totalOrderPrice = pitaTotalPrice;
            AddItemToReceipt("EATS2GO Pita Wraps", quantity, pitaPrice, pitaTotalPrice);
        }
        private void btnSand_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numSand.Value);
            sandTotalPrice = sandPrice * quantity;
            totalOrderPrice = sandTotalPrice;
            AddItemToReceipt("EATS2GO Sandwich", quantity, sandPrice, sandTotalPrice);
        }
        private void btnTaco_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numTaco.Value);
            tacoTotalPrice = tacoPrice * quantity;
            totalOrderPrice = tacoTotalPrice;
            AddItemToReceipt("EATS2GO TACO", quantity, tacoPrice, tacoTotalPrice);
        }
        private void btnEgg_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numEgg.Value);
            eggdropTotalPrice = eggdropPrice * quantity;
            totalOrderPrice = eggdropTotalPrice;
            AddItemToReceipt("EGG DROP SANDWICH", quantity, eggdropPrice, eggdropTotalPrice);
        }
        private void btnPesto_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numPesto.Value);
            pestoTotalPrice = pestoPrice * quantity;
            totalOrderPrice = pestoTotalPrice;
            AddItemToReceipt("EATS2GO CHICKEN PESTO", quantity, pestoPrice, pestoTotalPrice);
        }
        private void btnCornD_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numCornd.Value);
            corndogTotalPrice = corndogPrice * quantity;
            totalOrderPrice = corndogTotalPrice;
            AddItemToReceipt("CORN DOG", quantity, corndogPrice, corndogTotalPrice);
        }
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
            // Insert individual items into the database
            InsertItemToDatabase("EATS2GO Pita Wraps", Convert.ToInt32(numPita.Value), pitaPrice);
            InsertItemToDatabase("EATS2GO Sandwich", Convert.ToInt32(numSand.Value), sandPrice);
            InsertItemToDatabase("EATS2GO TACO", Convert.ToInt32(numTaco.Value), tacoPrice);
            InsertItemToDatabase("EGG DROP SANDWICH", Convert.ToInt32(numEgg.Value), eggdropPrice);
            InsertItemToDatabase("EATS2GO CHICKEN PESTO", Convert.ToInt32(numPesto.Value), pestoPrice);
            InsertItemToDatabase("CORN DOG", Convert.ToInt32(numCornd.Value), corndogPrice);

            frmSales salesForm = new frmSales();
            salesForm.Show();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double totalOrderPrice = CalculateTotalOrderPrice();
            txtReceipt.AppendText(Environment.NewLine);
            txtReceipt.AppendText("Total Order Price: ₱" + totalOrderPrice + Environment.NewLine);
            txtReceipt.AppendText(lineOfAsterisks);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceipt.Clear();
            txtReceipt.AppendText(headerText);
            txtReceipt.AppendText(lineOfAsterisks);
            totalOrderPrice = 0;
        }

        public frmFood()
        {
            InitializeComponent();
        }
        private void frmFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            frmBeverages Drinks = new frmBeverages();
            Drinks.Show();
            this.Hide();
        }
        private void DESSERT_Click(object sender, EventArgs e)
        {
            frmDessert Dessert = new frmDessert();
            Dessert.Show();
            this.Hide();
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
    }
}
