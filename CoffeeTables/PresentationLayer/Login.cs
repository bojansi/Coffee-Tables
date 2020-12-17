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
        public Login(char type)
        {
            InitializeComponent();

            if (type == 'a')
            {
                lbHeading.Text = "PRIJAVA ADMIN";
            }
            else if (type == 'w')
            {
                lbHeading.Text = "PRIJAVA KONOBAR";
            }
            else {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
