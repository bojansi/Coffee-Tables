using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PresentationLayer;
using Shared.Interfaces.Business;
using Shared.Models;

namespace PresentationLayerTests
{
    [TestClass]
    public class TableOverviewTests
    {
        [TestMethod]
        public void IsDisplayTotalOK()
        {

            // Arrange
            Receipt receipt = new Receipt()
            {
                Id = 1,
                TableId = 1,
                WaiterId = 2,
                Date = DateTime.Now,
                Paid = false,
                Total = 1000
            };

            var mockReceiptBusiness = new Mock<IReceiptBusiness>();
            var mockProductBusiness = new Mock<IProductBusiness>();
            var mockReceiptItemBusiness = new Mock<IReceiptItemBusiness>();
            var mockWaiterBusiness = new Mock<IWaiterBusiness>();
            var mockTableBusiness = new Mock<ITableBusiness>();
            var tableOveriew = new Mock<TableOverview>();

            mockReceiptBusiness.Setup(r => r.updateReceipt(receipt)).Returns(true);

            var tableOverview = new TableOverview(mockProductBusiness.Object, mockReceiptBusiness.Object, mockReceiptItemBusiness.Object, mockWaiterBusiness.Object, mockTableBusiness.Object, 1);

            // Act
            PrivateObject obj = new PrivateObject(tableOverview);

            Label lbReceiptTotal = (Label )obj.GetFieldOrProperty("lbReceiptTotal");
            Receipt currentReceipt = (Receipt) obj.GetFieldOrProperty("currentReceipt");
            decimal total = (decimal) obj.GetFieldOrProperty("total");
            total = receipt.Total;
            currentReceipt = receipt;

            obj.Invoke("DisplayTotal", (decimal) 1500);

            // Assert
            Assert.AreEqual("Iznos racuna : 2500 din.", lbReceiptTotal.Text);

        }
    }
}
