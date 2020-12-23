using BusinessLayer;
using DataLayer.Models;
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
                lbHeading.Text = "PRIJAVA ADMIN";
                btnLogin.MouseClick += new MouseEventHandler(checkAdmin);
                
            }
            else if (type == 'w')
            {
                lbHeading.Text = "PRIJAVA KONOBAR";
                btnLogin.MouseClick += new MouseEventHandler(checkWaiter);
                
            }
            else
            {
                Application.Exit();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkAdmin(object sender, EventArgs e)
        {
            if (tbPass.Text.Trim() == "admin" && tbUser.Text.Trim() == "admin")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Pogresan username ili lozinka");
            }
        }

        private void checkWaiter(object sender, EventArgs e)
        {
            Waiter w = waiterBusiness.getWaiterByUserAndPass(tbUser.Text.Trim(), tbPass.Text.Trim());
            if (w != null && w.Logged == false)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Pogresan username ili lozinka");
            }
        }


    }
}