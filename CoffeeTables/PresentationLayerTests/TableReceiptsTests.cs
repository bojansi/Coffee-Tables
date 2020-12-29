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
    public class TableReceiptsTests
    {
        [TestMethod]
        public void TestRefreshData()
        {
            // Arrange
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
                    Paid = true,
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
            var mockReceiptItemBusiness = new Mock<IReceiptItemBusiness>();
            var mockWaiterBusiness = new Mock<IWaiterBusiness>();

            mockReceiptBusiness.Setup(r => r.getAllReceipts()).Returns(receipts);

            var tableReceipt = new TableReceipts(mockReceiptBusiness.Object, mockReceiptItemBusiness.Object, mockWaiterBusiness.Object);

            // Act
            PrivateObject obj = new PrivateObject(tableReceipt);
            obj.Invoke("RefreshData");

            DataGridView dgvData = (DataGridView)obj.GetFieldOrProperty("dgvData");

            // Assert
            Assert.IsTrue((bool)dgvData.Rows[1].Cells[5].Value);
        }
    }
}
