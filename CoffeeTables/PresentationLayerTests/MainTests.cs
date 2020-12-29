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
    public class MainTests
    {
        [TestMethod]
        public void OpenTable()
        {
            List<Receipt> receipts = new List<Receipt>()
            {
                new Receipt()
                {
                    Id=1,
                    WaiterId = 2,
                    TableId = 3,
                    Date = DateTime.Now,
                    Paid = false,
                    Total = 1000
                },
                new Receipt()
                {
                    Id=2,
                    WaiterId = 2,
                    TableId = 3,
                    Date = DateTime.Now,
                    Paid = false,
                    Total = 350
                },
                new Receipt()
                {
                    Id=3,
                    WaiterId = 2,
                    TableId = 3,
                    Date = DateTime.Now,
                    Paid = false,
                    Total = 600
                }
            };

            var mockReceiptBusiness = new Mock<IReceiptBusiness>();
            var mockProductBusiness = new Mock<IProductBusiness>();
            var mockReceiptItemBusiness = new Mock<IReceiptItemBusiness>();
            var mockWaiterBusiness = new Mock<IWaiterBusiness>();
            var mockTableBusiness = new Mock<ITableBusiness>();

            mockReceiptBusiness.Setup(r => r.getReceiptByTodayDate(It.IsAny<DateTime>())).Returns(receipts);
            var main = new Main(mockProductBusiness.Object, mockReceiptBusiness.Object, mockReceiptItemBusiness.Object, mockWaiterBusiness.Object, mockTableBusiness.Object);

            // Act
            PrivateObject obj = new PrivateObject(main);
            
            obj.Invoke("OpenTable", (int) 1);

            Label lbDailyIncome = (Label) obj.GetFieldOrProperty("lbDailyIncome");

            // Assert
            Assert.AreEqual("1950 din.", lbDailyIncome.Text);

        }
    }
}
