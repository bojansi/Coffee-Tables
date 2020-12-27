using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReceiptItemRepository : IReceiptItemRepository
    {
        public List<ReceiptItem> GetAllReceiptItems()
        {
            List<ReceiptItem> listOfReceiptItems = new List<ReceiptItem>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM ReceiptItems";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ReceiptItem r = new ReceiptItem();
                    r.ReceiptId = sqlDataReader.GetInt32(0);
                    r.ProductId = sqlDataReader.GetInt32(1);
                    r.Quantity = sqlDataReader.GetInt32(2);
                    r.Amount = sqlDataReader.GetDecimal(3);

                    listOfReceiptItems.Add(r);
                }
            }

            return listOfReceiptItems;
        }


        public int InsertReceiptItem(ReceiptItem r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO ReceiptItems VALUES ('{0}',  '{1}', '{2}', '{3}')", r.ReceiptId, r.ProductId, r.Quantity, r.Amount);

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }


        public int UpdateReceiptItem(ReceiptItem r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE ReceiptItems SET Quantity = '{0}', Amount = '{1}' WHERE ReceiptId = '{2}' AND ProductId = '{3}'  ", r.Quantity, r.Amount, r.ReceiptId, r.ProductId);

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }

        }

        public int DeleteReceiptItemById(int rId, int pId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM ReceiptItems WHERE ReceiptId = '{0}' AND ProductId = '{1}' ", rId, pId);

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }

        }
    }
}
