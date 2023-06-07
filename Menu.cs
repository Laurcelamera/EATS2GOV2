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

        private void btnToMain2_Click(object sender, EventArgs e)
        {
            frmMain form2 = new frmMain();
            form2.Show();
            this.Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory form3 = new frmInventory();
            form3.Show();
            this.Hide();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu form4 = new frmMenu();
            form4.Show();
            this.Hide();
        }
      
        private void picsignOut_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            frmSales form5 = new frmSales();
            form5.Show();
            this.Hide();
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            frmInventory form3 = new frmInventory();
            form3.Show();
            this.Hide();
        }

        private void picShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picsignOut_Click_1(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }
    }
}
