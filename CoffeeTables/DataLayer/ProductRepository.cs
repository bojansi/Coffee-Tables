using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductRepository
    {

        public List<Product> GetAllProducts()
        {
            List<Product> listOfProducts = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Products";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Product p = new Product();
                    p.Id = sqlDataReader.GetInt32(0);
                    p.Name = sqlDataReader.GetString(1);
                    p.Price = sqlDataReader.GetDecimal(2);
                    p.Type = sqlDataReader.GetString(3);
                    listOfProducts.Add(p);
                }
            }

                return listOfProducts;
        }


        public int UpdateProduct(Product p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Products SET Name = '{0}', Price = '{1}', Type = '{2}' WHERE Id = '{3}' ", p.Name, p.Price, p.Type, p.Id);

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
           
        }

        public int InsertProduct(Product p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Products VALUES ('{0}',  '{1}', '{2}')", p.Name, p.Price, p.Type);

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }

        public int DeleteProduct(int Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Products WHERE Id='{0}'", Id);

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }


    }
}
