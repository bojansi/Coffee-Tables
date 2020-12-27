using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        int UpdateProduct(Product p);
        int InsertProduct(Product p);
        int DeleteProduct(int Id);
    }
}
