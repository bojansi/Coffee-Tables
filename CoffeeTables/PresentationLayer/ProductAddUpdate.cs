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
        public ProductAddUpdate(char type)
        {
            InitializeComponent();

            if (type == 'a')
            {
                btnProductAddUpdate.BackColor = Color.FromArgb(99, 205, 99);
                btnProductAddUpdate.Text = "Dodaj";
                this.Text = "Dodaj Artikal";
            }
            else if (type == 'u')
            {
                btnProductAddUpdate.BackColor = Color.FromArgb(29, 160, 255);
                btnProductAddUpdate.Text = "Izmeni";
                this.Text = "Izmeni Artikal";
            }
            else
            {
                Application.Exit();
            }
        }

        private void ProductAddUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
