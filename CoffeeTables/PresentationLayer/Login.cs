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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        private readonly IWaiterBusiness waiterBusiness;

        public Login(IWaiterBusiness _waiterBusiness, char type)
        {
            InitializeComponent();

            this.waiterBusiness = _waiterBusiness;

            if (type == 'a')
            {
                this.Text = "Prijava admina";
                lbHeading.Text = "PRIJAVA ADMIN";
                btnLogin.Click += new EventHandler(checkAdmin);
            }
            else if (type == 'w')
            {
                this.Text = "Prijava konobara";
                lbHeading.Text = "PRIJAVA KONOBAR";
                btnLogin.Click += new EventHandler(checkWaiter);
            }
            else
            {
                Application.Exit();
            }
            this.AcceptButton = btnLogin;
        }
        private void checkAdmin(object sender, EventArgs e)
        {
            if (tbUser.Text.Trim().Length != 0 && tbPass.Text.Length != 0)
            {
                if (tbUser.Text.Trim() == Constants.adminUsername && tbPass.Text == Constants.adminPassword)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Pogresan username ili lozinka");
                    tbUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Popunite sva potrebna polja");
                if (tbUser.Text.Trim().Length == 0)
                    tbUser.Focus();
                else
                    tbPass.Focus();
            }
        }

        private void checkWaiter(object sender, EventArgs e)
        {
            if (tbUser.Text.Trim().Length != 0 && tbPass.Text.Length != 0)
            {
                Waiter w = waiterBusiness.getWaiterByUserAndPass(tbUser.Text.Trim(), tbPass.Text.Trim());
                if (w != null && w.Logged == false)
                {
                    w.Logged = true;
                    this.waiterBusiness.updateWaiter(w);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Pogresan username ili lozinka");
                    tbUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Popunite sva potrebna polja");
                if (tbUser.Text.Trim().Length == 0)
                    tbUser.Focus();
                else
                    tbPass.Focus();
            }
        }


    }
}