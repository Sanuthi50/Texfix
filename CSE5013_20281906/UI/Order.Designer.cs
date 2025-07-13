namespace CSE5013_20281906.UI
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtQPrice = new System.Windows.Forms.TextBox();
            this.txtQAvailable = new System.Windows.Forms.TextBox();
            this.lblQAvailable = new System.Windows.Forms.Label();
            this.lblQPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(793, 126);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 23);
            this.lblSearch.TabIndex = 95;
            this.lblSearch.Text = "Search : ";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Controls.Add(this.lblTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1465, 65);
            this.panelTop.TabIndex = 78;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1402, 19);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(622, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(115, 40);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Order";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(942, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(482, 30);
            this.txtSearch.TabIndex = 90;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(747, 167);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(696, 479);
            this.dgvProducts.TabIndex = 89;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.txtSupplier);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.lblqty);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.txtQPrice);
            this.panel1.Controls.Add(this.txtQAvailable);
            this.panel1.Controls.Add(this.lblQAvailable);
            this.panel1.Controls.Add(this.lblQPrice);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblProductId);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 682);
            this.panel1.TabIndex = 96;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(79, 443);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(95, 23);
            this.lblSupplier.TabIndex = 121;
            this.lblSupplier.Text = "Supplier id:";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(235, 443);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(359, 22);
            this.txtSupplier.TabIndex = 122;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOrder.Location = new System.Drawing.Point(138, 589);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(300, 54);
            this.btnOrder.TabIndex = 120;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 119;
            this.label1.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(235, 538);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(359, 22);
            this.txtTotal.TabIndex = 118;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(236, 488);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(358, 22);
            this.txtqty.TabIndex = 117;
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(79, 488);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(86, 23);
            this.lblqty.TabIndex = 116;
            this.lblqty.Text = "Quantity: ";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(236, 107);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(358, 22);
            this.txtCategory.TabIndex = 115;
            // 
            // txtQPrice
            // 
            this.txtQPrice.Location = new System.Drawing.Point(235, 394);
            this.txtQPrice.Name = "txtQPrice";
            this.txtQPrice.ReadOnly = true;
            this.txtQPrice.Size = new System.Drawing.Size(360, 22);
            this.txtQPrice.TabIndex = 114;
            // 
            // txtQAvailable
            // 
            this.txtQAvailable.Location = new System.Drawing.Point(236, 346);
            this.txtQAvailable.Name = "txtQAvailable";
            this.txtQAvailable.ReadOnly = true;
            this.txtQAvailable.Size = new System.Drawing.Size(359, 22);
            this.txtQAvailable.TabIndex = 113;
            // 
            // lblQAvailable
            // 
            this.lblQAvailable.AutoSize = true;
            this.lblQAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAvailable.Location = new System.Drawing.Point(79, 344);
            this.lblQAvailable.Name = "lblQAvailable";
            this.lblQAvailable.Size = new System.Drawing.Size(155, 23);
            this.lblQAvailable.TabIndex = 112;
            this.lblQAvailable.Text = "Quantity Available:";
            // 
            // lblQPrice
            // 
            this.lblQPrice.AutoSize = true;
            this.lblQPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQPrice.Location = new System.Drawing.Point(81, 394);
            this.lblQPrice.Name = "lblQPrice";
            this.lblQPrice.Size = new System.Drawing.Size(119, 23);
            this.lblQPrice.TabIndex = 111;
            this.lblQPrice.Text = "Quoted price: ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(235, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(359, 117);
            this.txtDescription.TabIndex = 110;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(79, 22);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(94, 23);
            this.lblProductId.TabIndex = 102;
            this.lblProductId.Text = "Product Id:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(81, 157);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 103;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(81, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 23);
            this.lblName.TabIndex = 105;
            this.lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(81, 300);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 23);
            this.lblPrice.TabIndex = 106;
            this.lblPrice.Text = "Price:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(236, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(358, 22);
            this.txtId.TabIndex = 107;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(236, 300);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(359, 22);
            this.txtPrice.TabIndex = 109;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(80, 105);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 23);
            this.lblCategory.TabIndex = 104;
            this.lblCategory.Text = "Category:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(236, 63);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(359, 22);
            this.txtName.TabIndex = 108;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtQPrice;
        private System.Windows.Forms.TextBox txtQAvailable;
        private System.Windows.Forms.Label lblQAvailable;
        private System.Windows.Forms.Label lblQPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtName;
    }
}