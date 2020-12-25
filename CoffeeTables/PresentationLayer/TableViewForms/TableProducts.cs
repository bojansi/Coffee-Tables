using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TableProducts : Form
    {
        private readonly ProductBusiness productBusiness;
        public TableProducts()
        {
            InitializeComponent();

            this.productBusiness = new ProductBusiness();

            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["PName"].DataPropertyName = "Name";
            dgvData.Columns["Price"].DataPropertyName = "Price";
            dgvData.Columns["Type"].DataPropertyName = "Type";
        }
        private void RefreshData()
        {
            List<Product> products = this.productBusiness.getAllProduct();
            dgvData.DataSource = products;
        }
        private void TableProducts_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductAddUpdate wa = new ProductAddUpdate('i', null);
            if (wa.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product p = this.productBusiness.getProductById((int)dgvData.SelectedRows[0].Cells["Id"].Value);
            if (p != null)
            {
                ProductAddUpdate wu = new ProductAddUpdate('u', p);
                if (wu.ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.productBusiness.deleteProduct((int)dgvData.SelectedRows[0].Cells["Id"].Value))
            {
                MessageBox.Show("Uspesno izbrisan artikal iz baze podataka");
                RefreshData();
            }
        }
    }
}
