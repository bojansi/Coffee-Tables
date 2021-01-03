using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
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
        private readonly IReceiptBusiness receiptBusiness;
        private readonly IReceiptItemBusiness receiptItemBusiness; 
        private readonly IWaiterBusiness waiterBusiness;
        private readonly ITableBusiness tableBusiness;
        public TableReceipts(IReceiptBusiness _receiptBusiness, IReceiptItemBusiness _receiptItemBusienss, IWaiterBusiness _waiterBusiness, ITableBusiness _tableBusiness)
        {
            InitializeComponent();

            this.receiptBusiness = _receiptBusiness;
            this.receiptItemBusiness = _receiptItemBusienss;
            this.waiterBusiness = _waiterBusiness;
            this.tableBusiness = _tableBusiness;

            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["WaiterId"].DataPropertyName = "WaiterId";
            dgvData.Columns["TableId"].DataPropertyName = "TableId";
            dgvData.Columns["Date"].DataPropertyName = "Date";
            dgvData.Columns["HiddenTotal"].DataPropertyName = "Total";
            dgvData.Columns["Paid"].DataPropertyName = "Paid";
        }
        private void RefreshData() 
        {
            List<Receipt> receipts = this.receiptBusiness.GetAllReceipts();
            dgvData.DataSource = receipts;

            foreach (DataGridViewRow r in dgvData.Rows) 
                r.Cells["StringTotal"].Value = Convert.ToString(r.Cells["HiddenTotal"].Value + " din.");

        }
        private void TableReceipts_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ReceiptOverview ro = new ReceiptOverview(this.receiptBusiness, this.receiptItemBusiness, this.waiterBusiness,this.tableBusiness, Convert.ToInt32(dgvData.SelectedRows[0].Cells["Id"].Value), false);
            ro.ShowDialog();
        }
    }
}
