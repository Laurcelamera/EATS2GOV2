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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Event for Dashboard Button(Will open the Main Form)
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
        //Event for Food Button(Will open the Food Form)
        private void btnFood_Click(object sender, EventArgs e)
        {
            frmFood food = new frmFood();
            food.Show();
            this.Hide();
        }
        //Event for Drinks/Beverages Button(Will open the Beverages Form)
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            frmBeverages Drinks = new frmBeverages();
            Drinks.Show();
            this.Hide();
        }
        //Event for Dessert Button(Will open the Dessert Form)
        private void DESSERT_Click(object sender, EventArgs e)
        {
            frmDessert Dessert = new frmDessert();
            Dessert.Show();
            this.Hide();
        }
        //Event for Sign out button(Return to Login Form)
        private void BtnSignout_Click_1(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }
        //Event for the Shutdown button(Closes the program)
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
