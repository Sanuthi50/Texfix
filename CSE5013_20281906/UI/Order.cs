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

namespace CSE5013_20281906.UI
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        OrderDAL od = new OrderDAL();
        OrderBLL o = new OrderBLL();
        UserDAL user = new UserDAL();
        ProductDAL pd = new ProductDAL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex;
            txtId.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            txtCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
            txtQAvailable.Text = dgvProducts.Rows[rowIndex].Cells[5].Value.ToString();
            txtQPrice.Text = dgvProducts.Rows[rowIndex].Cells[6].Value.ToString();
            txtSupplier.Text = dgvProducts.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
        }

        public void clear()
        {
            txtCategory.Text= string.Empty;
            txtDescription.Text= string.Empty;
            txtPrice.Text= string.Empty;
            txtSearch.Text= string.Empty;
            txtSupplier.Text= string.Empty;
            txtId.Text= string.Empty;
            txtName.Text= string.Empty;
            txtQAvailable.Text= string.Empty;
            txtqty.Text= string.Empty;
            txtQPrice.Text= string.Empty;
            txtTotal.Text= string.Empty;
            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            
            DataTable dt = pd.Select();
            dgvProducts.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            o.productId = int.Parse(txtId.Text);
            o.qty = decimal.Parse(txtqty.Text);
            decimal qty = decimal.Parse(txtqty.Text);
            decimal price = decimal.Parse(txtQPrice.Text);
            decimal total = price * qty;
            txtTotal.Text = total.ToString();
            o.total = decimal.Parse(txtTotal.Text);
            o.status = "ordered";
            o.supplier_id = int.Parse(txtSupplier.Text);
            o.added_date = DateTime.Now;
            String loggedUser = Login.loggedIn;
            UserBLL userb = user.GetIDFromUsername(loggedUser);
            o.order_by = userb.id;

            bool Success = od.Insert(o);
            if (Success == true)
            {
                MessageBox.Show("Order Placed successfully.");
                clear();
                DataTable dt = pd.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to order the Product.");

            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = od.Search(keywords);
                dgvProducts.DataSource = dt;

            }
            else
            {
                DataTable dt = od.Search(keywords);
                dgvProducts.DataSource = dt;


            }
        }
    }
}
