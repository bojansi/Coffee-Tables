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
    public partial class ProductAddUpdate : Form
    {
        private Product selectedProduct;
        private readonly IProductBusiness productBusiness;
        public ProductAddUpdate(IProductBusiness _productBusiness, char type, Product p)
        {
            InitializeComponent();

            this.productBusiness = _productBusiness;
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
            if (CheckTextBoxAndRadioButton())
            {
                string price = tbPrice.Text;
                var charsToRemove = new string[] { "d", "i", "n", ".", "a", "r" };
                foreach (var c in charsToRemove)
                    price = price.Replace(c, string.Empty);

                if (Decimal.TryParse(price, out decimal checkedPrice))
                {
                    Product p = new Product()
                    {
                        Name = tbName.Text,
                        Price = Convert.ToDecimal(checkedPrice),
                        Type = panelRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text
                    };

                    if (this.productBusiness.InsertProduct(p))
                    {
                        MessageBox.Show("Uspesno unet artikal u bazu podataka", "Uspeh");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Greska pri unosu artikla u bazu podataka", "Greska");
                    }
                }
                else 
                {
                    tbPrice.BackColor = Color.FromArgb(255, 128, 128);
                    MessageBox.Show("Pogresno unet format cene artikla","Greska");
                }
            }
        }
        private void updateProduct(object sender, EventArgs e)
        {
            if (CheckTextBoxAndRadioButton())
            {
                string price = tbPrice.Text;
                var charsToRemove = new string[] { "d", "i", "n", ".", "a", "r"};
                foreach (var c in charsToRemove)
                    price = price.Replace(c, string.Empty);

                decimal checkedPrice;
                if (Decimal.TryParse(price, out checkedPrice))
                {
                    Product p = new Product()
                    {
                        Id = selectedProduct.Id,
                        Name = tbName.Text,
                        Price = Convert.ToDecimal(price),
                        Type = panelRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text
                    };

                    if (this.productBusiness.UpdateProduct(p))
                    {
                        MessageBox.Show("Uspesno izmenjen artikal u bazi podataka", "Uspeh");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Greska pri izmeni artikla u bazi podataka", "Greska");
                    }
                }
                else
                {
                    tbPrice.BackColor = Color.FromArgb(255, 128, 128);
                    MessageBox.Show("Pogresno unet format cene artikla", "Greska");
                }
            }
        }
        private bool CheckTextBoxAndRadioButton()
        {
            List<TextBox> tb = this.Controls.OfType<TextBox>().Where(c => String.IsNullOrEmpty(c.Text)).OrderBy(c => c.TabIndex).ToList();
            List<TextBox> tbFull = this.Controls.OfType<TextBox>().Where(c => (!String.IsNullOrEmpty(c.Text))).ToList();
            RadioButton rbChecked = panelRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked == true);
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
            else if (rbChecked == null) 
            {
                MessageBox.Show("Popunite vrstu pica", "Greska");
                return false;
            }            
            return true;
        }
    }
}
