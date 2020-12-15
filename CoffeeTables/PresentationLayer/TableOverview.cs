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
        public bool tableTaken = false;
        private DataGridViewRow rowClone;

        public TableOverview(int brStola)
        {
            InitializeComponent();

            rowClone = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            dataGridView1.AllowUserToAddRows = false;
            this.Text = "Sto " + brStola;
            lbBrojStola.Text = "BROJ STOLA " + brStola;

            dataGridView2.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;

            dataGridView2.Columns["PName"].DataPropertyName = "Name";
            dataGridView2.Columns["PPrice"].DataPropertyName = "Price";

            dataGridView1.Columns["Product_Name"].DataPropertyName = "Name";
            dataGridView1.Columns["Product_Price"].DataPropertyName = "Price";
            dataGridView1.Columns["Product_Quantity"].DataPropertyName = "Quantity";

        }

        private void TableOverview_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = rowClone;
            row.Height = 40;
            row.Cells[0].Value = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            row.Cells[1].Value = Convert.ToDecimal(dataGridView2.SelectedRows[0].Cells[1].Value);
            row.Cells[2].Value = 1;
            dataGridView1.Rows.Add(row);
            rowClone =(DataGridViewRow) dataGridView1.Rows[0].Clone();
            dataGridView1.CurrentCell.Selected = false;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dataGridView1.CurrentCell.Selected = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[2].ReadOnly = false;
        }

        private void TableOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                tableTaken = true;
            }
            else {
                tableTaken = false;
            }
        }
    }
}
