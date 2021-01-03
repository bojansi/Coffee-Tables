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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class WaiterAddUpdate : Form
    {
        private Waiter selectedWaiter;
        private readonly IWaiterBusiness waiterBusiness;
        private string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public WaiterAddUpdate(IWaiterBusiness _waiterBusiness, char type, Waiter w)
        {
            InitializeComponent();

            this.waiterBusiness = _waiterBusiness;
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
            else
            {
                Application.Exit();
            }
        }
        private void insertWaiter(object sender, EventArgs e)
        {
            if (CheckTextBox() && Regex.Match(tbEmail.Text, emailRegex).Success)
            {
                if (tbPhoneNumber.Text.Trim().Length > 8 && Int32.TryParse(tbPhoneNumber.Text, out int x))
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

                    if (this.waiterBusiness.InsertWaiter(w))
                    {
                        MessageBox.Show("Uspesno unet konobar u bazu podataka", "Uspeh");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Greska pri unosu konobara u bazu podataka", "Greska");
                    }
                }
                else
                {
                    MessageBox.Show("Pogresan format unetog telefonskog broja");
                }
            }
        }
        private void updateWaiter(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                if (tbPhoneNumber.Text.Trim().Length > 8 && Int32.TryParse(tbPhoneNumber.Text, out int x))
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

                    if (this.waiterBusiness.UpdateWaiter(w))
                    {
                        MessageBox.Show("Uspesno izmenjen konobar u bazi podataka", "Uspeh");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Greska pri izmeni konobara u bazi podataka", "Greska");
                    }
                }
                else
                {
                    MessageBox.Show("Pogresan format unetog telefonskog broja");
                }
            }
        }
        private bool CheckTextBox()
        {
            List<TextBox> tb = this.Controls.OfType<TextBox>().Where(c => String.IsNullOrEmpty(c.Text)).OrderBy(c => c.TabIndex).ToList();
            List<TextBox> tbFull = this.Controls.OfType<TextBox>().Where(c => !String.IsNullOrEmpty(c.Text)).ToList();
            foreach (TextBox t in tbFull)
            {
                t.BackColor = Color.FromArgb(196, 196, 196);
            }
            if (tb.Count != 0)
            {
                tb[0].Focus();
                foreach (TextBox t in tb)
                {
                    t.BackColor = Color.FromArgb(255, 128, 128);
                }
                MessageBox.Show("Popunite sva polja", "Greska");
                return false;
            }
            if (!Regex.Match(tbEmail.Text, emailRegex).Success)
            {
                tbEmail.BackColor = Color.FromArgb(255, 128, 128);
                MessageBox.Show("Pogresan format unetog email-a", "Greska");
                return false;
            }
            return true;
        }
    }
}
