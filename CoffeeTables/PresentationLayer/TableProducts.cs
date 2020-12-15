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
        public TableProducts()
        {
            InitializeComponent();
            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["PName"].DataPropertyName = "Name";
            dgvData.Columns["Price"].DataPropertyName = "Price";
            dgvData.Columns["Type"].DataPropertyName = "Type";
        }

        private void TableProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
