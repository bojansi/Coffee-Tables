using BusinessLayer;
using DataLayer.Models;
using DataLayer;
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
        private readonly WaiterBusiness waiterBusiness;

        public Login(char type)
        {
            InitializeComponent();

            this.waiterBusiness = new WaiterBusiness();

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
                if (tbUser.Text.Trim() == DataLayer.Constants.adminUsername && tbPass.Text == DataLayer.Constants.adminPassword)
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