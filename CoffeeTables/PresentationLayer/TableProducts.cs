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
    public partial class TableProducts : Form
    {
        public TableProducts()
        {
            InitializeComponent();
        }

        private void TableProducts_Load(object sender, EventArgs e)
        {
            List<Product> list = new List<Product>();

            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["PName"].DataPropertyName = "Name";
            dgvData.Columns["Price"].DataPropertyName = "Price";
            dgvData.Columns["Type"].DataPropertyName = "Type";

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Products;";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();


                while (sqlDataReader.Read())
                {

                    Product p = new Product();
                    p.Id = sqlDataReader.GetInt32(0);
                    p.Name = sqlDataReader.GetString(1);
                    p.Price = sqlDataReader.GetDecimal(2);
                    p.Type = sqlDataReader.GetString(3);
                    list.Add(p);

                }

            }

            dgvData.DataSource = list;
        }
    }
}
