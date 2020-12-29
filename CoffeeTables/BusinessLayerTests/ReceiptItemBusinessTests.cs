using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace BusinessLayerTests
{
    [TestClass]
    public class ReceiptItemBusinessTests
    {
        private Mock<IReceiptItemRepository> mockReceiptItemRepository = new Mock<IReceiptItemRepository>();
        private List<ReceiptItem> listOfReceiptItems = new List<ReceiptItem>();

        private ReceiptItemBusiness receiptItemBusiness;

        [TestMethod]
        public void IsGetReceiptItemById()
        {
            //Arange
            listOfReceiptItems.Add(new ReceiptItem
            {
                ReceiptId = 1,
                ProductId = 1,
                Amount = 500m
            });
            listOfReceiptItems.Add(new ReceiptItem
            {
                ReceiptId = 2,
                ProductId = 2,
                Amount = 1000m
            });
            listOfReceiptItems.Add(new ReceiptItem
            {
                ReceiptId = 3,
                ProductId = 3,
                Amount = 250m
                
            });
            mockReceiptItemRepository.Setup(x => x.GetAllReceiptItems()).Returns(listOfReceiptItems);
            receiptItemBusiness = new ReceiptItemBusiness(mockReceiptItemRepository.Object);

            //Act
            var result = receiptItemBusiness.getReceiptItemByReceiptId(2);

            //Assert
            Assert.AreEqual(1, result.Count);
        }
    }
}
