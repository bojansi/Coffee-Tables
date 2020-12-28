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

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM ReceiptItems");

            while (sqlDataReader.Read())
            {
                ReceiptItem r = new ReceiptItem();
                r.ReceiptId = sqlDataReader.GetInt32(0);
                r.ProductId = sqlDataReader.GetInt32(1);
                r.Quantity = sqlDataReader.GetInt32(2);
                r.Amount = sqlDataReader.GetDecimal(3);

                listOfReceiptItems.Add(r);
            }

            DBConnection.CloseConnection();
            return listOfReceiptItems;
        }


        public int InsertReceiptItem(ReceiptItem r)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO ReceiptItems VALUES ('{0}',  '{1}', '{2}', '{3}')", r.ReceiptId, r.ProductId, r.Quantity, r.Amount));

            DBConnection.CloseConnection();
            return result;
        }


        public int UpdateReceiptItem(ReceiptItem r)
        {
            var result = DBConnection.EditData(string.Format("UPDATE ReceiptItems SET Quantity = '{0}', Amount = '{1}' WHERE ReceiptId = '{2}' AND ProductId = '{3}'  ", r.Quantity, r.Amount, r.ReceiptId, r.ProductId));

            DBConnection.CloseConnection();
            return result;

        }

        public int DeleteReceiptItemById(int rId, int pId)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM ReceiptItems WHERE ReceiptId = '{0}' AND ProductId = '{1}' ", rId, pId));

            DBConnection.CloseConnection();
            return result;

        }
    }
}
