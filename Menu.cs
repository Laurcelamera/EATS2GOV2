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
    }
}
