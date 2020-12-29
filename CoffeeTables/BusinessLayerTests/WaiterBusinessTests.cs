using System;
using System.Collections.Generic;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace BusinessLayerTests
{
    [TestClass]
    public class WaiterBusinessTests
    {
        private Mock<IWaiterRepository> mockWaiterRepository = new Mock<IWaiterRepository>();
        private List<Waiter> listOfWaiter = new List<Waiter>();
        private Waiter waiter = new Waiter
        {
            Id = 1,
            Name = "Pera",
            Surname = "Peric",
            PhoneNumber = "0611765041"
        };
        private WaiterBusiness waiterBusiness;
        [TestMethod]
        public void IsProductInserted()
        {
            //Arange
            mockWaiterRepository.Setup(x => x.InsertWaiter(waiter)).Returns(1);
            this.waiterBusiness = new WaiterBusiness(mockWaiterRepository.Object);

            //Act
            var result = waiterBusiness.insertWaiter(waiter);

            //Asert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void IsGetWaiterById()
        {
            //Arange
            listOfWaiter.Add(waiter);
            listOfWaiter.Add(new Waiter
            {
                Id = 2,
                Name = "Milos",
                Surname = "Milosevic",
                PhoneNumber = "0641123041"
            });
            listOfWaiter.Add(new Waiter
            {
                Id = 3,
                Name = "Milan",
                Surname = "Milic",
                PhoneNumber = "0655765041"
            });
            listOfWaiter.Add(new Waiter
            {
                Id = 4,
                Name = "Nikola",
                Surname = "Nikolic",
                PhoneNumber = "0611718341"
            });
            mockWaiterRepository.Setup(x => x.GetAllWaiters()).Returns(listOfWaiter);
            waiterBusiness = new WaiterBusiness(mockWaiterRepository.Object);

            //Act
            var result = waiterBusiness.getWaiterById(4);

            //Assert
            Assert.AreEqual("Nikolic", result.Surname);
        }
    }
}
