using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IProductBusiness
    {
        List<Product> GetAllProducts();
        bool InsertProduct(Product p);
        bool UpdateProduct(Product p);
        bool DeleteProduct(int Id);
        Product GetProductById(int Id);

    }
}
