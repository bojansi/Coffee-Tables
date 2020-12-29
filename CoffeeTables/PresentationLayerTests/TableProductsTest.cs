using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PresentationLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayerTests
{
    [TestClass]
    public class TableProductsTest
    {
        [TestMethod]
        public void TestRefreshData()
        {
            // Arrange
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 10,
                    Name = "VODA VODA",
                    Price = 70,
                    Type = "Vode"
                },
                new Product()
                {
                    Id = 20,
                    Name = "Cedevita",
                    Price = 110,
                    Type = "Sokovi"
                },
                new Product()
                {
                    Id = 30,
                    Name = "Kafa",
                    Price = 60,
                    Type = "Topli napici"
                },
                new Product()
                {
                    Id = 40,
                    Name = "Coca cola",
                    Price = 120,
                    Type = "Sokovi"
                }
            };
            
            var mockProductBusiness = new Mock<IProductBusiness>();
            mockProductBusiness.Setup(p => p.getAllProduct()).Returns(products);

            var tableProduct = new TableProducts(mockProductBusiness.Object);

            // Act
            PrivateObject obj = new PrivateObject(tableProduct);
            obj.Invoke("RefreshData");

            DataGridView dgvData = (DataGridView) obj.GetFieldOrProperty("dgvData");

            // Assert
            Assert.AreEqual(4, dgvData.Rows.Count);
        }
    }
}
