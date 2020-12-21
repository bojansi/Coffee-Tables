using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TableRepository
    {
        public List<Table> GetAllTables()
        {
            List<Table> listOfTables = new List<Table>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Tables;";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Table t = new Table();
                    t.Id = sqlDataReader.GetInt32(0);
                    t.Number = sqlDataReader.GetInt32(1);
                    t.Taken = sqlDataReader.GetBoolean(2);
                    t.Description = sqlDataReader.GetString(3);
                    
                    listOfTables.Add(t);
                }

            }

            return listOfTables;
        }

        public int UpdateTable(Table t)
        { 
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Tables SET Number = '{0}', Taken = '{1}', Description = '{2}' WHERE Id = '{3}';", t.Number, t.Taken, t.Description, t.Id);

                sqlConnection.Open();

                int result = sqlCommand.ExecuteNonQuery();

                return result;
            }
        }


    }
}
