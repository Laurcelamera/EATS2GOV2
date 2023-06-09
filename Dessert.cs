using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EATS2GOV2
{
    public partial class frmDessert : Form
    {
        public frmDessert()
        {
            InitializeComponent();
        }
        private double halohaloPrice = 69.00;
        private double carSundaePrice = 35.00;
        private double strawSundaePrice = 70;
        private double chCakePrice = 80;
        private double bluPiePrice = 110;
        private double bTartPrice = 59.00;
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
            AddItemToReceipt("EATS2GO Pita Wraps", quantity, bTartPrice, bTartTotalPrice);

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
            totalOrderPrice += chCakePrice;

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
        }
        private void btnFood_Click(object sender, EventArgs e)
        {
            frmFood food = new frmFood();
            food.Show();
            this.Hide();
        }
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            frmBeverages Drinks = new frmBeverages();
            Drinks.Show();
            this.Hide();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
        private void frmDessert_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
