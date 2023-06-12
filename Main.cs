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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void picsignOut_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmMenu form4 = new frmMenu();
            form4.Show();
            this.Hide();
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            frmInventory form3 = new frmInventory();
            form3.Show();
            this.Hide();
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            frmSales form5 = new frmSales();
            form5.Show();
            this.Hide();
        }

        private void BtnSignout_Click_1(object sender, EventArgs e)
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
