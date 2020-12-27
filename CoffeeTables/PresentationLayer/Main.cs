using BusinessLayer;
using Shared;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Main : Form
    {
        public static List<Product> products = new List<Product>();
        public static List<Waiter> waiters = new List<Waiter>();
        private readonly IProductBusiness productBusiness;
        private readonly IReceiptBusiness receiptBusiness;
        private readonly IWaiterBusiness waiterBusiness;
        private readonly IReceiptItemBusiness receiptItemBusiness;

        public Main(IProductBusiness _productBusiness, IReceiptBusiness _receiptBusiness, IWaiterBusiness _waiterBusiness, IReceiptItemBusiness _receiptItemBusiness)
        {
            InitializeComponent();

            this.productBusiness = _productBusiness;
            this.receiptBusiness = _receiptBusiness;
            this.waiterBusiness = _waiterBusiness;
            this.receiptItemBusiness = _receiptItemBusiness;

            products = this.productBusiness.getAllProduct();
            waiters = this.waiterBusiness.getLoggedWaiters();

            dgvLoggedWaiters.AutoGenerateColumns = false;
            dgvLoggedWaiters.Columns["WId"].DataPropertyName = "Id";
            dgvLoggedWaiters.Columns["WName"].DataPropertyName = "Name";
            dgvLoggedWaiters.Columns["WSurname"].DataPropertyName = "Surname";
        }

        private void lbTable1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenTable(1);
        }
        private void lbTable2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenTable(2);
        }
        private void lbTable3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenTable(3);
        }
        private void lbTable4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenTable(4);
        }
        private void lbTable5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenTable(5);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void prijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lw = new Login(this.waiterBusiness, 'w');
            if (lw.ShowDialog() == DialogResult.OK) 
            {
                waiters = this.waiterBusiness.getLoggedWaiters();
                dgvLoggedWaiters.DataSource = waiters;
                if (dgvLoggedWaiters.Rows.Count > 0)
                {
                    dgvLoggedWaiters.CurrentCell.Selected = false;
                }
            }            
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenTable(1);
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenTable(2);
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenTable(3);
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenTable(4);
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenTable(5);
        }
        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login al = new Login(this.waiterBusiness, 'a');
            if (al.ShowDialog() == DialogResult.OK)
            {
                al.Dispose();
                TableProducts tp = new TableProducts(this.productBusiness);
                tp.ShowDialog();
            }
        }
        private void konobariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login al = new Login(this.waiterBusiness, 'a');
            if (al.ShowDialog() == DialogResult.OK)
            {
                al.Dispose();
                TableWaiter tw = new TableWaiter(this.waiterBusiness);
                tw.ShowDialog();
            }
        }
        private void racuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login al = new Login(this.waiterBusiness,'a');
            if (al.ShowDialog() == DialogResult.OK)
            {
                al.Dispose();
                TableReceipts tr = new TableReceipts(this.receiptBusiness, this.receiptItemBusiness, this.waiterBusiness);
                tr.ShowDialog();
            }
        }
        private void CheckTables() 
        {
            if (this.receiptBusiness.getUnpaidReceiptByTableId(1) != null)
                pnBackTable1.BackColor = Constants.tableTaken;
            else
                pnBackTable1.BackColor = Constants.tableAvailable;

            if (this.receiptBusiness.getUnpaidReceiptByTableId(2) != null)
                pnBackTable2.BackColor = Constants.tableTaken;
            else
                pnBackTable2.BackColor = Constants.tableAvailable;

            if (this.receiptBusiness.getUnpaidReceiptByTableId(3) != null)
                pnBackTable3.BackColor = Constants.tableTaken;
            else
                pnBackTable3.BackColor = Constants.tableAvailable;

            if (this.receiptBusiness.getUnpaidReceiptByTableId(4) != null)
                pnBackTable4.BackColor = Constants.tableTaken;
            else
                pnBackTable4.BackColor = Constants.tableAvailable;

            if (this.receiptBusiness.getUnpaidReceiptByTableId(5) != null)
                pnBackTable5.BackColor = Constants.tableTaken;
            else
                pnBackTable5.BackColor = Constants.tableAvailable;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            CheckTables();
            timer1.Start();
            List<Receipt> receipts = this.receiptBusiness.getReceiptByTodayDate(DateTime.Now);
            decimal daily = 0;
            foreach (Receipt r in receipts)
            {
                daily += r.Total;
            }
            lbDailyIncome.Text = "Danasnja zarada : " + daily + " din.";
            dgvLoggedWaiters.DataSource = waiters;
            if (dgvLoggedWaiters.Rows.Count > 0)
            {
                dgvLoggedWaiters.CurrentCell.Selected = false;
            }
        }
        private void OpenTable(int id) 
        {
            TableOverview to = new TableOverview(this.productBusiness, this.receiptBusiness, this.receiptItemBusiness, this.waiterBusiness, id);
            to.ShowDialog();
            List<Receipt> receipts = this.receiptBusiness.getReceiptByTodayDate(DateTime.Now);
            decimal daily = 0;
            foreach (Receipt r in receipts) 
            {
                daily += r.Total;
            }
            lbDailyIncome.Text = daily + " din.";
            CheckTables();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = Convert.ToString(DateTime.Now);            
        }
        private void dgvLoggedWaiters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) 
            {
                Waiter waiter = waiters.FirstOrDefault(w => w.Id == Convert.ToInt32(dgvLoggedWaiters.Rows[e.RowIndex].Cells[0].Value));
                waiter.Logged = false;
                this.waiterBusiness.updateWaiter(waiter);

                waiters = this.waiterBusiness.getLoggedWaiters();
                dgvLoggedWaiters.DataSource = waiters;
                if (dgvLoggedWaiters.Rows.Count > 0) 
                {
                    dgvLoggedWaiters.CurrentCell.Selected = false;
                }
            }
        }
    }
}