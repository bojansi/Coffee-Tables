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
    public class ReceiptRepository : IReceiptRepository
    {
        public List<Receipt> GetAllReceipts()
        {
            List<Receipt> listOfReceipts = new List<Receipt>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Receipts");

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

            DBConnection.CloseConnection();
            return listOfReceipts;
        }

        public int InsertReceipts(Receipt r)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Receipts VALUES ('{0}',  '{1}', '{2}', '{3}', '{4}')", r.WaiterId, r.TableId, r.Date, r.Total, r.Paid));

            DBConnection.CloseConnection();
            return result;

        }

        public int UpdateReceipt(Receipt r)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Receipts SET WaiterId = '{0}', TableId = '{1}', Date = '{2}', Total = '{3}', Paid = '{4}' WHERE Id = '{5}' ", r.WaiterId, r.TableId, r.Date, r.Total, r.Paid, r.Id));

            DBConnection.CloseConnection();
            return result;

        }

        public int DeleteReceipt(int Id)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Receipts WHERE Id='{0}'", Id));

            DBConnection.CloseConnection();
            return result;
        }

        public int GetNewReceiptId()
        {
            SqlDataReader sqlDataReader = DBConnection.GetData(string.Format("SELECT IDENT_CURRENT('Receipts')"));

            sqlDataReader.Read();
            var result = Convert.ToInt32(sqlDataReader[0]);
            DBConnection.CloseConnection();
            return result;
        }
    }
}
