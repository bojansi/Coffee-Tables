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
    public partial class TableReceipts : Form
    {
        private readonly ReceiptBusiness receiptusiness;
        public TableReceipts()
        {
            InitializeComponent();

            this.receiptusiness = new ReceiptBusiness();

            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["WaiterId"].DataPropertyName = "WaiterId";
            dgvData.Columns["TableId"].DataPropertyName = "TableId";
            dgvData.Columns["Date"].DataPropertyName = "Date";
            dgvData.Columns["Total"].DataPropertyName = "Total";
            dgvData.Columns["Paid"].DataPropertyName = "Paid";
        }

        private void TableReceipts_Load(object sender, EventArgs e)
        {
            List<Receipt> receipts = this.receiptusiness.getAllReceipts();

            dgvData.DataSource = receipts;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ReceiptOverview ro = new ReceiptOverview(Convert.ToInt32(dgvData.SelectedRows[0].Cells[0].Value), false);
            ro.ShowDialog();
        }
    }
}
