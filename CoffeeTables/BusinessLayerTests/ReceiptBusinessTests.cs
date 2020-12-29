using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace BusinessLayerTests
{
    [TestClass]
    public class ReceiptBusinessTests
    {
        private Mock<IReceiptRepository> mockReceiptRepository = new Mock<IReceiptRepository>();
        private ReceiptBusiness receiptBusiness;
        private Receipt receipt = new Receipt
        {
            Id = 1,
            WaiterId = 3,
            TableId = 2
        };

        [TestMethod]
        public void IsReceiptInserted()
        {
            //Arange
            mockReceiptRepository.Setup(x => x.InsertReceipts(receipt)).Returns(1);
            this.receiptBusiness = new ReceiptBusiness(mockReceiptRepository.Object);

            //Act
            var result = receiptBusiness.insertReceipt(receipt);

            //Asert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IsReceiptDeleted()
        {
            //Arange
            mockReceiptRepository.Setup(a => a.DeleteReceipt(It.IsAny<int>())).Returns(0);
            this.receiptBusiness = new ReceiptBusiness(mockReceiptRepository.Object);

            //Act
            var result = receiptBusiness.deleteReceipt(It.IsAny<int>());

            //Asert
            Assert.IsFalse(result);
        }
    }
}
