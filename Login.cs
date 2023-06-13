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
        // Event for when the form is closed
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Event for the login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if the entered username and password are correct
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Welcome Admin!");

                // Open the main form and display it
                frmMain form2 = new frmMain();
                form2.Show();

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect. Try again.");
            }
        }
        // Event for the show password button click
        private void btnShow_Click(object sender, EventArgs e)
        {
            // If the password is hidden, show it
            if (txtPassword.PasswordChar == '•')
            {
                btnHide.BringToFront();
                // Display the password characters
                txtPassword.PasswordChar = '\0'; 
            }
        }
        // Event for the hide password button click
        private void btnHide_Click(object sender, EventArgs e)
        {
            // If the password is shown, hide it
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                // Hide the password characters
                txtPassword.PasswordChar = '•'; 
            }
        }
    }
}