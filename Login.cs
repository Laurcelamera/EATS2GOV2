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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Welcome!");
                frmMain form2 = new frmMain();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect. Try again.");
            }
        }
    }
}
