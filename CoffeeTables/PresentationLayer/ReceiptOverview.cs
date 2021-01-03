using BusinessLayer;
using Shared;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ReceiptOverview : Form
    {
        private readonly IReceiptBusiness receiptBusiness;
        private readonly IReceiptItemBusiness receiptItemBusiness;
        private readonly IWaiterBusiness waiterBusiness;
        private readonly ITableBusiness tableBusiness;
        private Receipt currentReceipt;
        private List<ReceiptItem> receiptItems;
        public ReceiptOverview(IReceiptBusiness _receiptBusiness, IReceiptItemBusiness _receiptItemBusiness, IWaiterBusiness _waiterBusiness, ITableBusiness _tableBusiness, int receiptId, bool payment)
        {
            InitializeComponent();

            this.Text = "Racun " + receiptId;

            this.receiptBusiness = _receiptBusiness;
            this.receiptItemBusiness = _receiptItemBusiness;
            this.waiterBusiness = _waiterBusiness;
            this.tableBusiness = _tableBusiness;

            if (!payment) 
            {
                this.Height -= 50;
            }

            currentReceipt = this.receiptBusiness.GetReceiptById(receiptId);
            receiptItems = this.receiptItemBusiness.GetReceiptItemByReceiptId(currentReceipt.Id);
            
        }

        private void ReceiptOverview_Load(object sender, EventArgs e)
        {
            string receipt = "";
            richTextBox1.Font = new Font("Consolas", 12, FontStyle.Regular);
            foreach (string s in Constants.caffeInfo)
            {
                receipt += s + "\n";
            }
            receipt += "-------------------------------------\n\n";
            receipt += "\t\t FISKALNI RACUN\n\n";
            receipt += "\t  " + String.Format("{0:d/M/yyyy}",currentReceipt.Date) + "    " + String.Format("{0:HH:mm:ss}", currentReceipt.Date) + "\n";
            receipt += "-------------------------------------\n\n";

            foreach (ReceiptItem ri in receiptItems)
            {
                Product product = Main.products.FirstOrDefault(p => p.Id == ri.ProductId);
                receipt += product.Name + "\n";
                receipt += "\t\t   " + ri.Quantity + " x " + product.Price + "\t\t" + ri.Amount + "din.\n";
            }
            receipt += "-------------------------------------\n\n";
            receipt += "\tTotal : \t\t\t" + currentReceipt.Total + "din.\n";
            receipt += "-------------------------------------\n\n";
            Waiter waiter = this.waiterBusiness.GetWaiterById(currentReceipt.WaiterId);
            receipt += "Konobar : " + waiter.Id + " - " + waiter.Name + " " + waiter.Surname + "\n";
            receipt += "-------------------------------------";
            richTextBox1.Text = receipt;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Racun placen, hvala na poverenju");
            currentReceipt.Paid = true;
            currentReceipt.Date = DateTime.Now;
            this.receiptBusiness.UpdateReceipt(currentReceipt);
            Table t = this.tableBusiness.GetTableById(currentReceipt.TableId);
            t.Taken = false;
            this.tableBusiness.UpdateTable(t);
            this.DialogResult = DialogResult.OK;
        }
    }
}
