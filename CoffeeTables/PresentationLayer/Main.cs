using BusinessLayer;
using DataLayer.Models;
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
        private readonly ProductBusiness productBusiness;
        private readonly ReceiptBusiness receiptBusiness;

        public Main()
        {
            InitializeComponent();

            this.productBusiness = new ProductBusiness();
            this.receiptBusiness = new ReceiptBusiness();

            products = this.productBusiness.getAllProduct();
        }

        private void lbTable1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TableOverview to = new TableOverview(1);
            to.ShowDialog();

            if (to.tableTaken)
                pnBackTable1.BackColor = Constants.tableTaken;
            else
                pnBackTable1.BackColor = Constants.tableAvailable;
        }

        private void lbTable2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TableOverview to = new TableOverview(2);
            to.ShowDialog();

            if (to.tableTaken)
                pnBackTable2.BackColor = Constants.tableTaken;
            else
                pnBackTable2.BackColor = Constants.tableAvailable;
        }

        private void lbTable3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TableOverview to = new TableOverview(3);
            to.ShowDialog();

            if (to.tableTaken)
                pnBackTable3.BackColor = Constants.tableTaken;
            else
                pnBackTable3.BackColor = Constants.tableAvailable;
        }

        private void lbTable4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TableOverview to = new TableOverview(4);
            to.ShowDialog();

            if (to.tableTaken)
                pnBackTable4.BackColor = Constants.tableTaken;
            else
                pnBackTable4.BackColor = Constants.tableAvailable;
        }

        private void lbTable5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TableOverview to = new TableOverview(5);
            to.ShowDialog();

            if (to.tableTaken)
                pnBackTable5.BackColor = Constants.tableTaken;
            else
                pnBackTable5.BackColor = Constants.tableAvailable;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lw = new Login('w');
            lw.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TableOverview to = new TableOverview(1);
            to.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TableOverview to = new TableOverview(2);
            to.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TableOverview to = new TableOverview(3);
            to.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            TableOverview to = new TableOverview(4);
            to.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            TableOverview to = new TableOverview(5);
            to.ShowDialog();
        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login al = new Login('a');
            if (al.ShowDialog() == DialogResult.OK)
            {
                al.Dispose();
                TableProducts tp = new TableProducts();
                tp.ShowDialog();
            }

        }

        private void konobariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login al = new Login('a');
            if (al.ShowDialog() == DialogResult.OK)
            {
                al.Dispose();
                TableWaiter tw = new TableWaiter();
                tw.ShowDialog();
            }
        }

        private void racuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login al = new Login('a');
            if (al.ShowDialog() == DialogResult.OK)
            {
                al.Dispose();
                TableReceipts tr = new TableReceipts();
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
        }
    }
}