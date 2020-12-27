using BusinessLayer;
using DataLayer.Models;
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
        private readonly ReceiptBusiness receiptBusiness;
        private readonly ReceiptItemBusiness receiptItemBusiness;
        private readonly WaiterBusiness waiterBusiness;
        private Receipt currentReceipt;
        private List<ReceiptItem> receiptItems;
        public ReceiptOverview(int receiptId, bool payment)
        {
            InitializeComponent();

            this.Text = "Racun " + receiptId;

            this.receiptBusiness = new ReceiptBusiness();
            this.receiptItemBusiness = new ReceiptItemBusiness();
            this.waiterBusiness = new WaiterBusiness();

            if (!payment) 
            {
                this.Height -= 50;
            }

            currentReceipt = this.receiptBusiness.getReceiptById(receiptId);
            receiptItems = this.receiptItemBusiness.getReceiptItemByReceiptId(currentReceipt.Id);
            
        }

        private void ReceiptOverview_Load(object sender, EventArgs e)
        {
            string receipt = "";
            richTextBox1.Font = new Font("Consolas", 12, FontStyle.Regular);
            foreach (string s in DataLayer.Constants.caffeInfo)
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
            Waiter waiter = this.waiterBusiness.getWaiterById(currentReceipt.WaiterId);
            receipt += "Konobar : " + waiter.Id + " - " + waiter.Name + " " + waiter.Surname + "\n";
            receipt += "-------------------------------------";
            richTextBox1.Text = receipt;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Racun placen, hvala na poverenju");
            currentReceipt.Paid = true;
            this.receiptBusiness.updateReceipt(currentReceipt);
            this.DialogResult = DialogResult.OK;
        }
    }
}
