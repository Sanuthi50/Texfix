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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        UserBLL u = new UserBLL();
        UserDAL uDAL = new UserDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Getting data from UI
            u.name = txtName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.address = txtAddress.Text;
            u.contact = txtContact.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;

            //Getting username of the logged in user
            string loggedUser = Login.loggedIn;
            UserBLL user = uDAL.GetIDFromUsername(loggedUser);
             u.added_by = user.id;

            //inserting data into database
            bool success = uDAL.Insert(u);
            if (success == true)
            {
                //data succefully inserted
                MessageBox.Show("User Successfully created.");
                clear();

            }
            else
            {
                MessageBox.Show("Failed to add new user. ");

            }

            //Refreshing data grid view
            DataTable dt = uDAL.select();
            dgvUsers.DataSource = dt;





        }
        private void clear()
        {
            txtUserID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContact.Text = string.Empty;
            cmbUserType.Text = "";


        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the values from form
            u.id = Convert.ToInt32(txtUserID.Text);
            u.name = txtName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            //Getting username of the logged in user
            string loggedUser = Login.loggedIn;
            UserBLL user = uDAL.GetIDFromUsername(loggedUser);
            u.added_by = user.id;

            //updating data into database
            bool success = uDAL.Update(u);
            //if data is not updated succefully then the value of success is true or it will be false
            if (success == true)
            {
                MessageBox.Show("User/Supplier Updated Succefully.");
                clear();

            }
            else
            {
                MessageBox.Show("Failed To Update User/Supplier.");

            }
            //Refreshing data grid view
            DataTable dt = uDAL.select();
            dgvUsers.DataSource = dt;

        }

        private void User_Load(object sender, EventArgs e)
        {
            DataTable dt = uDAL.select();
            dgvUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //Getting User ID from Form
            u.id = Convert.ToInt32(txtUserID.Text);
            bool success = uDAL.Delete(u);
            if (success == true)
            {
                MessageBox.Show("User Deleted Successfully.");
                clear();

            }
            else
            {
                MessageBox.Show("Failed to Delete the User.");

            }
            //Refreshing data grid view
            DataTable dt = uDAL.select();
            dgvUsers.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = uDAL.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = uDAL.select();
                dgvUsers.DataSource = dt;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get index of particular row
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
        }
    }
}
