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
    public class ProductRepository : IProductRepository
    {

        public List<Product> GetAllProducts()
        {
            List<Product> listOfProducts = new List<Product>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Products");

            while (sqlDataReader.Read())
            {
                Product p = new Product();
                p.Id = sqlDataReader.GetInt32(0);
                p.Name = sqlDataReader.GetString(1);
                p.Price = sqlDataReader.GetDecimal(2);
                p.Type = sqlDataReader.GetString(3);
                listOfProducts.Add(p);
            }

            DBConnection.CloseConnection();
            return listOfProducts;
        }


        public int UpdateProduct(Product p)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Products SET Name = '{0}', Price = '{1}', Type = '{2}' WHERE Id = '{3}' ", p.Name, p.Price, p.Type, p.Id));

            DBConnection.CloseConnection();
            return result;

        }

        public int InsertProduct(Product p)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Products VALUES ('{0}',  '{1}', '{2}')", p.Name, p.Price, p.Type));
            DBConnection.CloseConnection();

            return result;
        }

        public int DeleteProduct(int Id)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Products WHERE Id='{0}'", Id));

            DBConnection.CloseConnection();
            return result;

        }


    }
}
