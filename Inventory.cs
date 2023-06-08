﻿using System;
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
        private void LoadInventory()
        {
            dataInventory.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT ID, itemName, itemType, itemCost, itemQuantity, itemExpiry, itemReceivedDate, itemSupplier FROM inventory;", conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataInventory.Rows.Add(rdr.GetString(0), rdr.GetString(1),
                    rdr.GetString(2), rdr.GetString(3), rdr.GetString(4),rdr.GetString(5), rdr.GetString(6), rdr.GetString(7));
            }
            conn.Close();
        }
       
        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void btnToMain_Click(object sender, EventArgs e)
        {
            frmMain form2 = new frmMain();
            form2.Show();
            this.Hide();
        }

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
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("INSERT INTO INVENTORY(itemName, itemType, itemCost, itemQuantity, itemExpiry, itemReceivedDate, itemSupplier) " +
                "VALUES('" + txtItemName.Text + "','" + txtItemType.Text + "','" + txtItemPrice.Text + "','" + txtItemQuantity.Text + "', '"+txtItemExp.Text+
                "', '"+txtItemRecDate.Text+"', '"+txtItemSup.Text+"');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Added Successfully!, Success");
            LoadInventory();
            ClearAll();
        }

        private void dataInventory_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataInventory.SelectedRows.Count > 0)
            {
                txtItemID.Text = dataInventory.SelectedRows[0].Cells[0].Value.ToString();
                txtItemName.Text = dataInventory.SelectedRows[0].Cells[1].Value.ToString();
                txtItemType.Text = dataInventory.SelectedRows[0].Cells[2].Value.ToString();
                txtItemPrice.Text = dataInventory.SelectedRows[0].Cells[3].Value.ToString();
                txtItemQuantity.Text = dataInventory.SelectedRows[0].Cells[4].Value.ToString();
                txtItemExp.Text = dataInventory.SelectedRows[0].Cells[5].Value.ToString();
                txtItemRecDate.Text = dataInventory.SelectedRows[0].Cells[6].Value.ToString();
                txtItemSup.Text = dataInventory.SelectedRows[0].Cells[7].Value.ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("UPDATE INVENTORY SET " +
                "itemName = '" + txtItemName.Text + "', " +
                "itemType = '" + txtItemType.Text + "', " +
                "itemCost = '" + txtItemPrice.Text + "', " +
                "itemQuantity = '" + txtItemQuantity.Text + "', " +
                "itemExpiry = '"+txtItemExp.Text+"', " +
                "itemReceivedDate = '"+txtItemRecDate.Text+"', " +
                "itemSupplier = '"+txtItemSup.Text+"' " +
                "WHERE ID = '" + txtItemID.Text + "';", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Updated Successfully!", "Success");
            LoadInventory();
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataInventory.SelectedRows.Count > 0)
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
        private void frmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
