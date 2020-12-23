using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReceiptRepository
    {
        public List<Receipt> GetAllReceipts()
        {
            List<Receipt> listOfReceipts = new List<Receipt>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Receipts";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Receipt r = new Receipt();
                    r.Id = sqlDataReader.GetInt32(0);
                    r.WaiterId = sqlDataReader.GetInt32(1);
                    r.TableId = sqlDataReader.GetInt32(2);
                    r.Date = sqlDataReader.GetDateTime(3);
                    r.Total = sqlDataReader.GetDecimal(4);
                    r.Paid = sqlDataReader.GetBoolean(5);
                    listOfReceipts.Add(r);
                }
            }

            return listOfReceipts;
        }

        public int InsertReceipts(Receipt r) 
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Receipts VALUES ('{0}',  '{1}', '{2}', '{3}', '{4}')", r.WaiterId, r.TableId, r.Date, r.Total, r.Paid );

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }


    }
}
