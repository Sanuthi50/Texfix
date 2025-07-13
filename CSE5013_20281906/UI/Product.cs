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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        ProductDAL pd = new ProductDAL();
        ProductBLL p = new ProductBLL();
        UserDAL user = new UserDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblQPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.price= decimal.Parse(txtPrice.Text);
            p.available_qty = decimal.Parse(txtQAvailable.Text);
            p.quoted_price = decimal.Parse(txtQPrice.Text);
            p.added_date = DateTime.Now;
            String loggedUser = Login.loggedIn;
            UserBLL userb = user.GetIDFromUsername(loggedUser);
            p.added_by = userb.id;

            bool Success = pd.Insert(p);
            if (Success == true)
            {
                MessageBox.Show("Product added successfully.");
                clear();
                int supplier = Login.loggedInID;
                DataTable dt = pd.GetProductsFromSupplierid(supplier);
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to Add the Product.");

            }
        }

        public void clear()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQAvailable.Text = string.Empty;
            txtQPrice.Text = string.Empty;
            cmbCategory.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtId.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.price = decimal.Parse(txtPrice.Text);
            p.available_qty = decimal.Parse(txtQAvailable.Text);
            p.added_date = DateTime.Now;
            String loggedUser = Login.loggedIn;
            UserBLL userb = user.GetIDFromUsername(loggedUser);
            p.added_by = userb.id;


            bool Success = pd.Update(p);
            if (Success == true)
            {
                MessageBox.Show("Product Updated Successfully.");
                clear();
                int supplier = Login.loggedInID;
                DataTable dt = pd.GetProductsFromSupplierid(supplier);
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update product");



            }
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
            txtQAvailable.Text = dgvProducts.Rows[rowIndex].Cells[5].Value.ToString();
            txtQPrice.Text = dgvProducts.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtId.Text);
            bool success = pd.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Product is successfully Deleted.");
                clear();
                int supplier = Login.loggedInID;
                DataTable dt = pd.GetProductsFromSupplierid(supplier);
                dgvProducts.DataSource = dt;


            }
            else
            {
                MessageBox.Show("Failed to delete the product.");

            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            int supplier = Login.loggedInID;
            DataTable dt = pd.GetProductsFromSupplierid(supplier);
            dgvProducts.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = pd.Search(keywords);
                dgvProducts.DataSource = dt;


            }
            else
            {
                int supplier = Login.loggedInID;
                DataTable dt = pd.GetProductsFromSupplierid(supplier);
                dgvProducts.DataSource = dt;


            }

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
