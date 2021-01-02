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
        public List<Product> GetAllProducts()
        {
            return this.productRepository.GetAllProducts();
        }
        public bool InsertProduct(Product p)
        {
            if(this.productRepository.InsertProduct(p) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateProduct(Product p)
        {
            if (this.productRepository.UpdateProduct(p) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteProduct(int Id)
        {
            if (this.productRepository.DeleteProduct(Id) > 0)
            {
                return true;
            }
            return false;
        }
        public Product GetProductById(int Id)
        {
            return this.productRepository.GetAllProducts().FirstOrDefault(p => p.Id == Id);
        }
    }
}
