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
    public partial class TableReceipts : Form
    {
        public TableReceipts()
        {
            InitializeComponent();
        }

        private void TableReceipts_Load(object sender, EventArgs e)
        {
            List<Receipt> list = new List<Receipt>();

            dgvData.Columns["Id"].DataPropertyName = "Id";
            dgvData.Columns["WaiterId"].DataPropertyName = "WaiterId";
            dgvData.Columns["TableId"].DataPropertyName = "TableId";
            dgvData.Columns["Date"].DataPropertyName = "Date";
            dgvData.Columns["Cost"].DataPropertyName = "Cost";



            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Receipts;";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    Receipt r = new Receipt();
                    r.Id = sqlDataReader.GetInt32(0);
                    r.WaiterId = sqlDataReader.GetInt32(1);
                    r.TableId = sqlDataReader.GetInt32(2);
                    r.Date = sqlDataReader.GetDateTime(3);
                    r.Cost = sqlDataReader.GetDecimal(4);

                    list.Add(r);

                }

            }

            dgvData.DataSource = list;
        }
    }
}
