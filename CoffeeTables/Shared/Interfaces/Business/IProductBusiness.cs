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
        List<Product> getAllProduct();
        bool insertProduct(Product p);
        bool updateProduct(Product p);
        bool deleteProduct(int Id);
        Product getProductById(int Id);

    }
}
