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
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }
        OrderDAL od = new OrderDAL();
        OrderBLL o = new OrderBLL();


        private void btnSave_Click(object sender, EventArgs e)
        {

            o.id = int.Parse(txtId.Text);
            o.status = cmbStatus.Text;
            o.added_date = DateTime.Now;



            bool Success = od.Update(o);
            if (Success == true)
            {
                MessageBox.Show("The order updated successfully.");
                clear();

                int user = Login.loggedInID;
                DataTable dt = od.GetOrdersByUseer(user);
                dgvOrders.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed to save the order");


            }

        }
        public void clear()
        {
            txtId.Text = string.Empty;
            cmbStatus.Text = string.Empty;
            txtOrderedBy.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtSupplier.Text = string.Empty;
            txtqty.Text = string.Empty;
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            int user = Login.loggedInID;
            DataTable dt = od.GetOrdersByUseer(user);
            dgvOrders.DataSource = dt;

        }

        private void dgvOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvOrders.Rows[rowIndex].Cells[0].Value.ToString();
            txtProductId.Text = dgvOrders.Rows[rowIndex].Cells[1].Value.ToString();
            txtOrderedBy.Text = dgvOrders.Rows[rowIndex].Cells[2].Value.ToString();
            txtSupplier.Text = dgvOrders.Rows[rowIndex].Cells[3].Value.ToString();
            cmbStatus.Text = dgvOrders.Rows[rowIndex].Cells[5].Value.ToString();
            txtqty.Text = dgvOrders.Rows[rowIndex].Cells[6].Value.ToString();
            txtTotal.Text = dgvOrders.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = od.Search(keywords);
                dgvOrders.DataSource = dt;

            }
            else
            {
                int supplier = Login.loggedInID;
                DataTable dt = od.GetOrdersForSupplierid(supplier);
                dgvOrders.DataSource = dt;


            }
        }
    }
    
}
