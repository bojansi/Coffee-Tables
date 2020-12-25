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
    public partial class WaiterAddUpdate : Form
    {
        private Waiter selectedWaiter;
        private readonly WaiterBusiness waiterBusiness;
        public WaiterAddUpdate(char type, Waiter w)
        {
            InitializeComponent();

            this.waiterBusiness = new WaiterBusiness();
            this.selectedWaiter = w;

            if (type == 'i')
            {
                btnWaiterInsertUpdate.BackColor = Constants.buttonAdd;
                btnWaiterInsertUpdate.FlatAppearance.BorderColor = Constants.buttonAdd;
                btnWaiterInsertUpdate.Text = "Dodaj";
                this.Text = "Dodaj Konobara";
                btnWaiterInsertUpdate.Click += new EventHandler(insertWaiter);
            }
            else if (type == 'u')
            {
                btnWaiterInsertUpdate.BackColor = Constants.buttonUpdate;
                btnWaiterInsertUpdate.FlatAppearance.BorderColor = Constants.buttonUpdate;
                btnWaiterInsertUpdate.Text = "Izmeni";
                this.Text = "Izmeni Konobara";
                btnWaiterInsertUpdate.Click += new EventHandler(updateWaiter);

                tbName.Text = selectedWaiter.Name;
                tbSurname.Text = selectedWaiter.Surname;
                tbAddress.Text = selectedWaiter.Address;
                tbEmail.Text = selectedWaiter.Email;
                tbPhoneNumber.Text = selectedWaiter.PhoneNumber;
                tbUser.Text = selectedWaiter.Username;
                tbPass.Text = selectedWaiter.Password;
            }
            else {
                Application.Exit();
            }
        }
        private void insertWaiter(object sender, EventArgs e) 
        {
            if (CheckTextBox())
            {
                Waiter w = new Waiter()
                {
                    Name = tbName.Text,
                    Surname = tbSurname.Text,
                    Address = tbAddress.Text,
                    Email = tbEmail.Text,
                    PhoneNumber = tbPhoneNumber.Text,
                    Username = tbUser.Text,
                    Password = tbPass.Text
                };

                if (this.waiterBusiness.insertWaiter(w))
                {
                    MessageBox.Show("Uspesno unet konobar u bazu podataka");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Greska pri unosu konobara u bazu podataka");
                }
            }
        }
        private void updateWaiter(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                Waiter w = new Waiter()
                {
                    Id = selectedWaiter.Id,
                    Name = tbName.Text,
                    Surname = tbSurname.Text,
                    Address = tbAddress.Text,
                    Email = tbEmail.Text,
                    PhoneNumber = tbPhoneNumber.Text,
                    Username = tbUser.Text,
                    Password = tbPass.Text
                };

                if (this.waiterBusiness.updateWaiter(w))
                {
                    MessageBox.Show("Uspesno izmenjen konobar u bazi podataka");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Greska pri izmeni konobara u bazi podataka");
                }
            }
        }
        private bool CheckTextBox()
        {
            TextBox tb = this.Controls.OfType<TextBox>().FirstOrDefault(c => c.Text.Length == 0);
            if (tb != null)
            {
                tb.Focus();
                MessageBox.Show("Popunite sva polja");
                return false;
            }
            return true;
        }
    }
}
