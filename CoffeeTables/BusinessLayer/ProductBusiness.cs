using DataLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness:IProductBusiness
    {
        private readonly IProductRepository productRepository;
        public ProductBusiness(IProductRepository _productRepository)
        {
            this.productRepository = _productRepository;
        }
        public List<Product> getAllProduct()
        {
            return this.productRepository.GetAllProducts();
        }
        public bool insertProduct(Product p)
        {
            if(this.productRepository.InsertProduct(p) > 0)
            {
                return true;
            }
            return false;
        }
        public bool updateProduct(Product p)
        {
            if (this.productRepository.UpdateProduct(p) > 0)
            {
                return true;
            }
            return false;
        }
        public bool deleteProduct(int Id)
        {
            if (this.productRepository.DeleteProduct(Id) > 0)
            {
                return true;
            }
            return false;
        }
        public Product getProductById(int Id)
        {
            return this.productRepository.GetAllProducts().FirstOrDefault(p => p.Id == Id);
        }
    }
}
