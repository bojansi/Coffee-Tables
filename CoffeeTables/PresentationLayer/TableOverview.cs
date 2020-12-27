using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TableOverview : Form
    {
        private readonly ProductBusiness productBusiness;
        private readonly ReceiptBusiness receiptBusiness;
        private readonly ReceiptItemBusiness receiptItemBusiness;
        private readonly WaiterBusiness waiterBusiness;

        public bool tableTaken = false;
        private DataGridViewRow rowClone;
        private decimal total = 0;
        private Receipt currentReceipt;
        private Receipt receipt;

        public TableOverview(int tableNumber)
        {
            InitializeComponent();

            rowClone = (DataGridViewRow)dgvTable.Rows[0].Clone();
            dgvTable.AllowUserToAddRows = false;

            this.Text = "Sto " + tableNumber;
            lbTableNumber.Text = "BROJ STOLA " + tableNumber;

            dgvProducts.AutoGenerateColumns = false;
            dgvTable.AutoGenerateColumns = false;

            dgvProducts.Columns["PId"].DataPropertyName = "Id";
            dgvProducts.Columns["PName"].DataPropertyName = "Name";
            dgvProducts.Columns["PPrice"].DataPropertyName = "Price";
            dgvProducts.Columns["PType"].DataPropertyName = "Type";

            dgvTable.Columns["TProductId"].DataPropertyName = "ProductId";
            dgvTable.Columns["TName"].DataPropertyName = "Name";
            dgvTable.Columns["TAmount"].DataPropertyName = "Amount";
            dgvTable.Columns["TQuantity"].DataPropertyName = "Quantity";

            

            this.productBusiness = new ProductBusiness();
            this.receiptBusiness = new ReceiptBusiness();
            this.receiptItemBusiness = new ReceiptItemBusiness();
            this.waiterBusiness = new WaiterBusiness();

            currentReceipt = this.receiptBusiness.getUnpaidReceiptByTableId(tableNumber);
        }
        private void TableOverview_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Main.products;

            cbWaiters.Items.Clear();
            List<Waiter> loggedWaiters = this.waiterBusiness.getLoggedWaiters();
            foreach (Waiter w in loggedWaiters) 
            {
                cbWaiters.Items.Add(w.Id + ". " + w.Name + " " + w.Surname);
            }

            if (currentReceipt == null)
            {
                receipt = new Receipt()
                {
                    TableId = Convert.ToInt32(this.Text.Split(' ')[1]),
                    WaiterId = 2002,
                    Date = DateTime.Now,
                    Total = 0
                };
                this.receiptBusiness.insertReceipt(receipt);
                currentReceipt = receipt;
                currentReceipt.Id = this.receiptBusiness.getNewReceiptId();
                DisplayTotal(0);
            }
            else
            {
                List<ReceiptItem> itemsList = this.receiptItemBusiness.getReceiptItemByReceiptId(currentReceipt.Id);
                foreach (ReceiptItem ri in itemsList)
                {
                    DataGridViewRow row = rowClone;
                    row.Height = 40;
                    row.Cells[0].Value = ri.ProductId;
                    row.Cells[1].Value = Main.products.FirstOrDefault(p => p.Id == ri.ProductId).Name;
                    row.Cells[2].Value = ri.Quantity;
                    row.Cells[3].Value = Convert.ToDecimal(ri.Amount);
                    DisplayTotal((decimal)ri.Amount);

                    dgvTable.Rows.Add(row);
                    rowClone = (DataGridViewRow)dgvTable.Rows[0].Clone();
                }
                Waiter waiter = this.waiterBusiness.getWaiterById(currentReceipt.WaiterId);
                cbWaiters.Text = waiter.Id + ". " + waiter.Name + " " + waiter.Surname;
            }

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvTable.Rows)
            {
                if (r.Cells[0].Value.Equals(dgvProducts.SelectedRows[0].Cells[0].Value))
                {
                    r.Cells[2].Value = (int) r.Cells[2].Value + 1;
                    r.Cells[3].Value = (decimal)r.Cells[3].Value + (decimal)dgvProducts.SelectedRows[0].Cells[2].Value;
                    DisplayTotal(Convert.ToDecimal(dgvProducts.SelectedRows[0].Cells[2].Value));
                    ReceiptItem riu = new ReceiptItem()
                    {
                        ReceiptId = currentReceipt.Id,
                        ProductId = Convert.ToInt32(r.Cells[0].Value),
                        Amount = Convert.ToDecimal(r.Cells[3].Value),
                        Quantity = Convert.ToInt32(r.Cells[2].Value)
                    };
                    this.receiptItemBusiness.updateReceiptItem(riu);
                    return;
                }               
            }
            DataGridViewRow row = rowClone;
            row.Height = 40;
            row.Cells[0].Value = dgvProducts.SelectedRows[0].Cells[0].Value;
            row.Cells[1].Value = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
            row.Cells[2].Value = 1;
            row.Cells[3].Value = Convert.ToDecimal(dgvProducts.SelectedRows[0].Cells[2].Value);

            currentReceipt.Date = DateTime.Now;
            DisplayTotal(Convert.ToDecimal(dgvProducts.SelectedRows[0].Cells[2].Value));

            ReceiptItem rii = new ReceiptItem()
            {
                ReceiptId = currentReceipt.Id,
                ProductId = Convert.ToInt32(row.Cells[0].Value),
                Amount = Convert.ToDecimal(row.Cells[3].Value),
                Quantity = Convert.ToInt32(row.Cells[2].Value)
            };
            this.receiptItemBusiness.insertReceiptItem(rii);

            dgvTable.Rows.Add(row);
            rowClone = (DataGridViewRow) dgvTable.Rows[0].Clone();
            dgvTable.CurrentCell.Selected = false;

        }
        private void DisplayTotal(decimal price) 
        {
            total += price;
            currentReceipt.Total = total;
            this.receiptBusiness.updateReceipt(currentReceipt);
            lbReceiptTotal.Text = "Iznos racuna : " + total + " din.";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.receiptItemBusiness.deleteReceiptItemById(currentReceipt.Id, Convert.ToInt32(dgvTable.SelectedRows[0].Cells[0].Value));
            DisplayTotal(Convert.ToDecimal(dgvTable.SelectedRows[0].Cells[3].Value) * -1);
            dgvTable.Rows.RemoveAt(dgvTable.SelectedRows[0].Index);

        }
        private void TableOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvTable.Rows.Count > 0)
            {
                tableTaken = true;
            }
            else 
            {
                tableTaken = false;
                this.receiptBusiness.deleteReceipt(currentReceipt.Id);
            }
        }
        private void cbDrinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDrinkType.Text.Equals("Sve"))
            {
                dgvProducts.DataSource = Main.products;
            }
            else
            {
                dgvProducts.DataSource = Main.products.Where(p => p.Type.Equals(cbDrinkType.Text)).ToList();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (cbWaiters.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati konobara koji izdaje racun");
            }
            else 
            {
                ReceiptOverview ro = new ReceiptOverview(currentReceipt.Id, true);
                if (ro.ShowDialog() == DialogResult.OK) 
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void cbWaiters_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentReceipt.WaiterId = Convert.ToInt32(cbWaiters.Text.Split('.')[0]);
            this.receiptBusiness.updateReceipt(currentReceipt);
        }
    }
}
