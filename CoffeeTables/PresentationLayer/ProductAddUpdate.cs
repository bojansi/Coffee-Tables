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
    public partial class ProductAddUpdate : Form
    {
        private Product selectedProduct;
        private readonly ProductBusiness productBusiness;
        public ProductAddUpdate(char type, Product p)
        {
            InitializeComponent();

            this.productBusiness = new ProductBusiness();
            this.selectedProduct = p;

            if (type == 'i')
            {
                btnProductInsertUpdate.BackColor = Constants.buttonAdd;
                btnProductInsertUpdate.FlatAppearance.BorderColor = Constants.buttonAdd;
                btnProductInsertUpdate.Text = "Dodaj";
                this.Text = "Dodaj Artikal";
                btnProductInsertUpdate.Click += new EventHandler(insertProduct);
            }
            else if (type == 'u')
            {
                btnProductInsertUpdate.BackColor = Constants.buttonUpdate;
                btnProductInsertUpdate.FlatAppearance.BorderColor = Constants.buttonUpdate;
                btnProductInsertUpdate.Text = "Izmeni";
                this.Text = "Izmeni Artikal";
                btnProductInsertUpdate.Click += new EventHandler(updateProduct);

                tbName.Text = selectedProduct.Name;
                tbPrice.Text = selectedProduct.Price + " din.";
                switch (selectedProduct.Type)
                {
                    case "Topli napici":
                        rbHotBeverage.Checked = true;
                        break;
                    case "Vode":
                        rbWater.Checked = true;
                        break;
                    case "Zestoka pica":
                        rbStrongDrink.Checked = true;
                        break;
                    case "Piva":
                        rbBeer.Checked = true;
                        break;
                    case "Sokovi":
                        rbJuice.Checked = true;
                        break;
                    case "Energetska pica":
                        rbEnergyDrink.Checked = true;
                        break;
                }
            }
            else
            {
                Application.Exit();
            }
        }
        private void insertProduct(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                string price = tbPrice.Text;
                var charsToRemove = new string[] { "d", "i", "n", ".", "a", "r" };
                foreach (var c in charsToRemove)
                    price = price.Replace(c, string.Empty);

                Product p = new Product()
                {
                    Name = tbName.Text,
                    Price = Convert.ToDecimal(price),
                    Type = panelRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text
                };

                if (this.productBusiness.insertProduct(p))
                {
                    MessageBox.Show("Uspesno unet artikal u bazu podataka");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Greska pri unosu artikla u bazu podataka");
                }
            }
        }
        private void updateProduct(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                string price = tbPrice.Text;
                var charsToRemove = new string[] { "d", "i", "n", ".", "a", "r"};
                foreach (var c in charsToRemove)
                    price = price.Replace(c, string.Empty);

                Product p = new Product()
                {
                    Id = selectedProduct.Id,
                    Name = tbName.Text,
                    Price = Convert.ToDecimal(price),
                    Type = panelRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text
                };

                if (this.productBusiness.updateProduct(p))
                {
                    MessageBox.Show("Uspesno izmenjen artikal u bazi podataka");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Greska pri izmeni artikla u bazi podataka");
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
