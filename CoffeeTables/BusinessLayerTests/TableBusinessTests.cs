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
    public class TableBusinessTests
    {
        private Mock<ITableRepository> mockTableRepository = new Mock<ITableRepository>();

        private List<Table> listOfTables = new List<Table>();
        private TableBusiness tableBusiness;

        [TestMethod]
        public void IsGetTableById()
        {
            //Arange
            listOfTables.Add(new Table
            {
                Id = 1,
                Number = 1,
                Taken = true
            });
            listOfTables.Add(new Table
            {
                Id = 2,
                Number = 2,
                Taken = false
            });
            listOfTables.Add(new Table
            {
                Id = 3,
                Number = 3,
                Taken = true
            });
            mockTableRepository.Setup(x => x.GetAllTables()).Returns(listOfTables);
            tableBusiness = new TableBusiness(mockTableRepository.Object);

            //Act
            var result = tableBusiness.getTableById(3);

            //Assert
            Assert.AreEqual(true, result.Taken);
        }
    }
}
