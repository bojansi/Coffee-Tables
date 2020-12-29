using System;
using System.Collections.Generic;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace BusinessLayerTests
{
    [TestClass]
    public class ProductBusinessTests
    {
        private Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();
        private Product product = new Product
        {
            Name = "Caj",
            Price = 100m,
            Type = "Topli napitak"
        };
        private List<Product> listOfProducts = new List<Product>();
        private ProductBusiness productBusiness;
        

        [TestMethod]
        public void IsProductInserted()
        {

            //Arange(dodeliti vrednosti)
            mockProductRepository.Setup(x => x.InsertProduct(product)).Returns(1);
            this.productBusiness = new ProductBusiness(mockProductRepository.Object);

            //Act(izvrsiti operaciju)
            var result = productBusiness.insertProduct(product);

            //Asert(proveriti rezultat)
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void IsProductDeleted()
        {
            //Arange
            Product product = new Product()
            {
                Id = 1,
                Name = "Caj",
                Price = 100m,
                Type = "Topli napitak"
            };
            mockProductRepository.Setup(a => a.DeleteProduct(It.IsAny<int>())).Returns(1);
            this.productBusiness = new ProductBusiness(mockProductRepository.Object);

            //Act
            var result = productBusiness.deleteProduct(It.IsAny<int>());

            //Asert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsGetProductById()
        {
            //Arange
            listOfProducts.Add(new Product
            {
                Id = 1,
                Name = "Pivo",
                Price = 150m,
                Type = "Alkoholno pice"
            });
            listOfProducts.Add(new Product
            {
                Id = 2,
                Name = "Fanta",
                Price = 120m,
                Type = "Gazirani sok"
            });
            listOfProducts.Add(new Product
            {
                Id = 3,
                Name = "Espreso",
                Price = 110m,
                Type = "Topli napitak"
            });
            mockProductRepository.Setup(x => x.GetAllProducts()).Returns(listOfProducts);
            productBusiness = new ProductBusiness(mockProductRepository.Object);

            //Act
            var result = productBusiness.getProductById(2);

            //Assert
            Assert.AreEqual("Fanta", result.Name);
        }
    }
}
