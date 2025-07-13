using CSE5013_20281906.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE5013_20281906
{
    public partial class SupplierDashboard : Form
    {
        public SupplierDashboard()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            products.Show();
        }

        private void SupplierDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void SupplierDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = Login.loggedIn;
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.Show();
        }
    }
}
