using CSE5013_20281906.BusinessLogicLayer;
using CSE5013_20281906.DataAccessLayer;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        LoginBLL l = new LoginBLL();
        LoginDAL data = new LoginDAL();

        public static string loggedIn;
        public static int loggedInID;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.id = int.Parse(txtID.Text.Trim());

            
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            bool success = data.loginCheck(l);
            if (success == true)
            {
                MessageBox.Show("Login Successful.");
                loggedIn = l.username;
                loggedInID = l.id;
                //opening respective forms based on user type 
                switch (l.user_type)
                {
                    case "User":
                        {
                            UserDashboard user = new UserDashboard();
                            user.Show();
                            this.Hide();

                        }
                        break;

                    case "Supplier":
                        {
                            SupplierDashboard sup = new SupplierDashboard();
                            sup.Show();
                            this.Hide();

                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid User Type");
                        }
                        break;
                }

            }
            else
            {
                MessageBox.Show("Login Failed");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
