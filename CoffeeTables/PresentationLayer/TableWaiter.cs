using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TableWaiter : Form
    {
        public TableWaiter()
        {
            InitializeComponent();
        }

        private void TableWaiter_Load(object sender, EventArgs e)
        {

            List<Waiter> list = new List<Waiter>();

            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["WName"].DataPropertyName = "Name";
            dgvData.Columns["Surname"].DataPropertyName = "Surname";
            dgvData.Columns["Email"].DataPropertyName = "Email";
            dgvData.Columns["Address"].DataPropertyName = "Address";
            dgvData.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
            dgvData.Columns["Username"].DataPropertyName = "Username";
            dgvData.Columns["Password"].DataPropertyName = "Password";



            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Waiters;";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();


                while (sqlDataReader.Read())
                {

                    Waiter w = new Waiter();
                    w.Id = sqlDataReader.GetInt32(0);
                    w.Name = sqlDataReader.GetString(1);
                    w.Surname = sqlDataReader.GetString(2);
                    w.Email = sqlDataReader.GetString(3);
                    w.Address = sqlDataReader.GetString(4);
                    w.PhoneNumber = sqlDataReader.GetString(5);
                    w.Username = sqlDataReader.GetString(6);
                    w.Password = sqlDataReader.GetString(7);

                    list.Add(w);

                }

            }
            dgvData.DataSource = list;
        }
    }
}
