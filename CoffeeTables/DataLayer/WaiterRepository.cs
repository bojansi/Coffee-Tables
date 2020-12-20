using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class WaiterRepository
    {
        public List<Waiter> GetAllWaiters()
        {
            List<Waiter> listOfWaiters = new List<Waiter>();

            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Waiters;";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

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

            }

            return listOfWaiters;
        }

        public int InsertWaiter(Waiter w)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Waiters VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", w.Name, w.Surname,
                    w.Email, w.Address, w.PhoneNumber, w.Username, w.Password, w.Logged);

                sqlConnection.Open();
               
                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdateWaiter(Waiter w)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Waiters SET Name = '{0}', Surname = '{1}', Email = '{2}', Address = '{3}', PhoneNumber = '{4}', Username = '{5}', Password = '{6}', Logged = '{7}' WHERE Id = '{8}';", w.Name, w.Surname, w.Email, w.Address, w.PhoneNumber, w.Username, w.Password, w.Logged, w.Id);

                sqlConnection.Open();

                int result = sqlCommand.ExecuteNonQuery();

                return result;
            }
        }


        public int DeleteWaiter(int Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DETELE FROM Waiters WHERE Id = '{0}' ", Id); 

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();

                return result;                
            }
        }




    }
}
