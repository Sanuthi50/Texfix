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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
        }
        ProductDAL pd = new ProductDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = pd.ArrangeASC();
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
                DataTable dt = pd.Select();
                dgvProducts.DataSource = dt;

            }

        }

        private void btnhigh_Click(object sender, EventArgs e)
        {
            DataTable dt = pd.ArrangeDESC();
            dgvProducts.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {

            DataTable dt = pd.Select();
            dgvProducts.DataSource = dt;

        }
    }
}
