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
    public partial class TableWaiter : Form
    {
        public TableWaiter()
        {
            InitializeComponent();
        }

        private void TableWaiter_Load(object sender, EventArgs e)
        {
            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["WName"].DataPropertyName = "Name";
            dgvData.Columns["Surname"].DataPropertyName = "Surname";
            dgvData.Columns["Email"].DataPropertyName = "Email";
            dgvData.Columns["Address"].DataPropertyName = "Address";
            dgvData.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
            dgvData.Columns["Username"].DataPropertyName = "Username";
            dgvData.Columns["Password"].DataPropertyName = "Password";

        }
    }
}
