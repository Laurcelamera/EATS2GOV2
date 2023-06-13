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
    public partial class frmInventory : Form
    {
        MySqlConnection conn = new MySqlConnection(
        "datasource=localhost;" +
        "port=3306;" +
        "database=eats2go;" +
        "username=root;" +
        "password='';");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public frmInventory()
        {
            InitializeComponent();
        }
        // Method to load inventory data from the database and insert data into the data grid view
        private void LoadInventory()
        {
            dataIngredients.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT ID, itemName, itemType, itemCost, itemQuantity, itemExpiry, itemReceivedDate, itemSupplier FROM inventory;", conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                // Add the retrieved data to the dataIngredients DataGridView
                dataIngredients.Rows.Add(rdr.GetString(0), rdr.GetString(1),
                    rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7));
                // Retrieve item information from the reader
                string itemName = rdr.GetString(1);
                string itemType = rdr.GetString(2);
                string itemQuantity = rdr.GetString(4);
                int quantityThreshold = 10; // Set the threshold for low inventory quantity
                if (int.Parse(itemQuantity) < quantityThreshold)
                {
                    string message = "Item Name: " + itemName + "\n";
                    message += "Item Type: " + itemType + "\n";
                    message += "Current Quantity: " + itemQuantity + "\n";
                    message += "Please reorder supplies for this item.";
                    MessageBox.Show(message, "Low Inventory Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            conn.Close();
        }
        // Method to load the menu data from the database and insert data into the data grid view
        private void LoadMenu()
        {
            dataMenu.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT ID, ItemName, itemType, itemPrice, itemQuantity FROM MENU;", conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataMenu.Rows.Add(rdr.GetString(0), rdr.GetString(1),
                    rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
                string itemName = rdr.GetString(1);
                string itemType = rdr.GetString(2);
                string itemQuantity = rdr.GetString(4);

                int quantityThreshold = 12; // Set the threshold for low inventory quantity
                if (int.Parse(itemQuantity) < quantityThreshold)
                {
                    string message = "Item Name: " + itemName + "\n";
                    message += "Item Type: " + itemType + "\n";
                    message += "Current Quantity: " + itemQuantity + "\n";
                    message += "Please reorder supplies for this item.";

                    MessageBox.Show(message, "Low Inventory Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            conn.Close();
        }
        // Load Form
        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadInventory();
            LoadMenu();
        }
        // Event for the "To Main" button (Go back to Dashboard)
        private void btnToMain_Click(object sender, EventArgs e)
        {
            frmMain form2 = new frmMain();
            form2.Show();
            this.Hide();
        }
        // Method to clear all input fields
        private void ClearAll()
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtItemType.Clear();
            txtItemPrice.Clear();
            txtItemQuantity.Clear();
            txtItemExp.Clear();
            txtItemRecDate.Clear();
            txtItemSup.Clear();
            txtItemID2.Clear();
            txtItemName2.Clear();
            txtItemType2.Clear();
            txtItemPrice2.Clear();
            txtItemQuantity2.Clear();
        }
        // Event handler for the "Add" button (Insert data in the Inventory)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("INSERT INTO INVENTORY(itemName, itemType, itemCost, itemQuantity, itemExpiry, itemReceivedDate, itemSupplier) " +
                "VALUES('" + txtItemName.Text + "','" + txtItemType.Text + "','" + txtItemPrice.Text + "','" + txtItemQuantity.Text + "', '" + txtItemExp.Text +
                "', '" + txtItemRecDate.Text + "', '" + txtItemSup.Text + "');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Added Successfully!", "Success");
            LoadInventory();
            ClearAll();
        }
        // Inventory data grid view selection changed event
        private void dataInventory_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataIngredients.SelectedRows.Count > 0)
            {
                txtItemID.Text = dataIngredients.SelectedRows[0].Cells[0].Value.ToString();
                txtItemName.Text = dataIngredients.SelectedRows[0].Cells[1].Value.ToString();
                txtItemType.Text = dataIngredients.SelectedRows[0].Cells[2].Value.ToString();
                txtItemPrice.Text = dataIngredients.SelectedRows[0].Cells[3].Value.ToString();
                txtItemQuantity.Text = dataIngredients.SelectedRows[0].Cells[4].Value.ToString();
                txtItemExp.Text = dataIngredients.SelectedRows[0].Cells[5].Value.ToString();
                txtItemRecDate.Text = dataIngredients.SelectedRows[0].Cells[6].Value.ToString();
                txtItemSup.Text = dataIngredients.SelectedRows[0].Cells[7].Value.ToString();
            }
        }
        // Event for the "Save" button (Update Item on Inventory)
        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("UPDATE INVENTORY SET " +
                "itemName = '" + txtItemName.Text + "', " +
                "itemType = '" + txtItemType.Text + "', " +
                "itemCost = '" + txtItemPrice.Text + "', " +
                "itemQuantity = '" + txtItemQuantity.Text + "', " +
                "itemExpiry = '" + txtItemExp.Text + "', " +
                "itemReceivedDate = '" + txtItemRecDate.Text + "', " +
                "itemSupplier = '" + txtItemSup.Text + "' " +
                "WHERE ID = '" + txtItemID.Text + "';", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Updated Successfully!", "Success");
            LoadInventory();
            ClearAll();
        }
        // Event for the "Delete" button (Delete Item in the Inventory)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataIngredients.SelectedRows.Count > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE FROM INVENTORY WHERE ID = '" + txtItemID.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Item Deleted Successfully", "Deleted");
                LoadInventory();
                ClearAll();
            }
        }
        // Event for the "Add" (Inserts item into the menu)
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("INSERT INTO Menu(ItemName, itemType, itemPrice, itemQuantity) " +
            "VALUES('" + txtItemName2.Text + "','" + txtItemType2.Text + "','" + txtItemPrice2.Text + "','" + txtItemQuantity2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Added Successfully!", "Success");
            LoadMenu();
            ClearAll();
        }
        // Menu data grid view selection changed event
        private void dataMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataMenu.SelectedRows.Count > 0)
            {
                txtItemID2.Text = dataMenu.SelectedRows[0].Cells[0].Value.ToString();
                txtItemName2.Text = dataMenu.SelectedRows[0].Cells[1].Value.ToString();
                txtItemType2.Text = dataMenu.SelectedRows[0].Cells[2].Value.ToString();
                txtItemPrice2.Text = dataMenu.SelectedRows[0].Cells[3].Value.ToString();
                txtItemQuantity2.Text = dataMenu.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
        // Event  for the "Save" button (Updates the record on Menu)
        private void btnSave2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("UPDATE MENU SET " +
                "ItemName = '" + txtItemName2.Text + "', " +
                "itemType = '" + txtItemType2.Text + "', " +
                "itemPrice = '" + txtItemPrice2.Text + "', " +
                "itemQuantity = '" + txtItemQuantity2.Text + "' " +
                "WHERE ID = '" + txtItemID2.Text + "';", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Updated Successfully!", "Success");
            LoadMenu();
            ClearAll();
        }
        // Event for the "Delete" button (Deletes the record on Menu)
        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (dataMenu.SelectedRows.Count > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE FROM MENU WHERE ID = '" + txtItemID2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Item Deleted Successfully", "Deleted");
                LoadMenu();
                ClearAll();
            }
            //Close Form
        }
        private void frmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}