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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProduct products = new ViewProduct();
            products.Show();
        }

        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void UserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = Login.loggedIn;
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();  
            order.Show();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement();
            orderManagement.Show();
        }
    }
}
