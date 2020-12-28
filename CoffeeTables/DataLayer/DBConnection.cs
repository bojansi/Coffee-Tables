using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public sealed class DBConnection
    {
        private static SqlConnection sqlConnection = null;
        private static SqlCommand sqlCommand = null;

        private DBConnection()
        {

        }

        private static SqlConnection SqlConnection
        {
            get
            {
                if(sqlConnection == null)
                {
                    sqlConnection = new SqlConnection(Constants.connectionString);
                }
                return sqlConnection;
            }
        }

        private static SqlCommand SqlCommand
        {
            get
            {
                if(sqlCommand == null)
                {
                    sqlCommand = new SqlCommand
                    {
                        Connection = SqlConnection
                    };
                }
                return sqlCommand;
            }
        }

        private static void OpenConnection()
        {
            if(sqlConnection != null)
            {
                sqlConnection.Open();
            }
        }

        public static void CloseConnection()
        {
            if(sqlConnection != null) 
            {
                sqlConnection.Close();
            }
        }

        public static SqlDataReader GetData(string commandText)
        {
            if (SqlConnection !=null && SqlCommand != null)
            {
                OpenConnection();
                sqlCommand.CommandText = commandText;
                var result = sqlCommand.ExecuteReader();
                return result;
            }
            return null;
        }

        public static int EditData(string commandText)
        {
            if(SqlConnection != null && SqlCommand != null)
            {
                OpenConnection();
                SqlCommand.CommandText = commandText;
                var result = sqlCommand.ExecuteNonQuery();
                return result;
            }
            return 0;
        }

    }
}
