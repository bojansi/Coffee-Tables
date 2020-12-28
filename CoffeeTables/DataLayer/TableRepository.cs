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
    public class TableRepository : ITableRepository
    {
        public List<Table> GetAllTables()
        {
            List<Table> listOfTables = new List<Table>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Tables;");

            while (sqlDataReader.Read())
            {
                Table t = new Table();
                t.Id = sqlDataReader.GetInt32(0);
                t.Number = sqlDataReader.GetInt32(1);
                t.Taken = sqlDataReader.GetBoolean(2);
                t.Description = sqlDataReader.GetString(3);

                listOfTables.Add(t);
            }

            DBConnection.CloseConnection();
            return listOfTables;
        }

        public int UpdateTable(Table t)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Tables SET Number = '{0}', Taken = '{1}', Description = '{2}' WHERE Id = '{3}';", t.Number, t.Taken, t.Description, t.Id));

            DBConnection.CloseConnection();
            return result;
        }


    }
}
