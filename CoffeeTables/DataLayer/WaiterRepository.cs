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
    public class WaiterRepository : IWaiterRepository
    {
        public List<Waiter> GetAllWaiters()
        {
            List<Waiter> listOfWaiters = new List<Waiter>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Waiters;");

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
                w.Logged = sqlDataReader.GetBoolean(8);
                listOfWaiters.Add(w);
            }

            DBConnection.CloseConnection();
            return listOfWaiters;
        }

        public int InsertWaiter(Waiter w)
        {

            var result = DBConnection.EditData(string.Format("INSERT INTO Waiters VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", w.Name, w.Surname,
                    w.Email, w.Address, w.PhoneNumber, w.Username, w.Password, w.Logged));

            DBConnection.CloseConnection();
            return result;
        }

        public int UpdateWaiter(Waiter w)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Waiters SET Name = '{0}', Surname = '{1}', Email = '{2}', Address = '{3}', PhoneNumber = '{4}', Username = '{5}', Password = '{6}', Logged = '{7}' WHERE Id = '{8}';", w.Name, w.Surname, w.Email, w.Address, w.PhoneNumber, w.Username, w.Password, w.Logged, w.Id));

            DBConnection.CloseConnection();
            return result;
        }



        public int DeleteWaiter(int Id)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Waiters WHERE Id = '{0}' ", Id));

            DBConnection.CloseConnection();
            return result;

        }
    }
}
