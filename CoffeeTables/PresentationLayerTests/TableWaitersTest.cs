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
    public class TableWaitersTest
    {
        [TestMethod]
        public void TestRefreshData()
        {
            // Arrange
            List<Waiter> waiters = new List<Waiter>()
            {
                new Waiter()
                {
                    Id = 100,
                    Name = "Milan",
                    Surname = "Tolic",
                    Address = "Konjevici bb",
                    Email = "milan.tolic@gmail.com",
                    PhoneNumber = "0616451230"
                },
                new Waiter()
                {
                    Id = 200,
                    Name = "Mladen",
                    Surname = "Pesic",
                    Address = "Ljubic bb",
                    Email = "mladen.pesic@gmail.com",
                    PhoneNumber = "0623257410"
                },
            };

            var mockWaiterBusiness = new Mock<IWaiterBusiness>();

            mockWaiterBusiness.Setup(r => r.getAllWaiters()).Returns(waiters);

            var tableReceipt = new TableWaiter(mockWaiterBusiness.Object);

            // Act
            PrivateObject obj = new PrivateObject(tableReceipt);
            obj.Invoke("RefreshData");

            DataGridView dgvData = (DataGridView)obj.GetFieldOrProperty("dgvData");

            // Assert
            Assert.AreEqual("Milan", dgvData.Rows[0].Cells[1].Value);
        }
    }
}
