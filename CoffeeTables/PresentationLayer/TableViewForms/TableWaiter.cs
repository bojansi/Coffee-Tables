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
    public partial class TableWaiter : Form
    {
        private readonly IWaiterBusiness waiterBusiness;
        public TableWaiter(IWaiterBusiness _waiterBusiness)
        {
            InitializeComponent();

            this.waiterBusiness = _waiterBusiness;

            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["WName"].DataPropertyName = "Name";
            dgvData.Columns["Surname"].DataPropertyName = "Surname";
            dgvData.Columns["Email"].DataPropertyName = "Email";
            dgvData.Columns["Address"].DataPropertyName = "Address";
            dgvData.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
            dgvData.Columns["Username"].DataPropertyName = "Username";
            dgvData.Columns["Password"].DataPropertyName = "Password";
            dgvData.Columns["Logged"].DataPropertyName = "Logged";
        }
        private void RefreshData() 
        {
            List<Waiter> waiters = this.waiterBusiness.GetAllWaiters();
            dgvData.DataSource = waiters;
        }
        private void TableWaiter_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            WaiterAddUpdate wa = new WaiterAddUpdate(waiterBusiness, 'i', null);
            if (wa.ShowDialog() == DialogResult.OK) 
            {
                RefreshData();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Waiter w = this.waiterBusiness.GetWaiterById((int)dgvData.SelectedRows[0].Cells["Id"].Value);
            if (w != null)
            {
                WaiterAddUpdate wu = new WaiterAddUpdate(waiterBusiness,'u', w);
                if (wu.ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentCell.Selected == true)
            {
                DialogResult dialog = MessageBox.Show("Da li ste sigurni da zelite da izbrisete ovog konobara?", "Potvrda brisanja konobara", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (this.waiterBusiness.DeleteWaiter((int)dgvData.SelectedRows[0].Cells["Id"].Value))
                    {
                        MessageBox.Show("Uspesno izbrisan konobar iz baze podataka", "Uspeh");
                        RefreshData();
                    }
                }
            }
        }
    }
}
