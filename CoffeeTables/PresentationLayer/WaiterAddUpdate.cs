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
        public WaiterAddUpdate(char type)
        {
            InitializeComponent();

            if (type == 'a')
            {
                btnWaiterAddUpdate.BackColor = Color.FromArgb(99, 205, 99);
                btnWaiterAddUpdate.Text = "Dodaj";
                this.Text = "Dodaj Konobara";
            }
            else if (type == 'u')
            {
                btnWaiterAddUpdate.BackColor = Color.FromArgb(29, 160, 255);
                btnWaiterAddUpdate.Text = "Izmeni";
                this.Text = "Izmeni Konobara";
            }
            else {
                Application.Exit();
            }
        }

        private void WaiterAddUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
