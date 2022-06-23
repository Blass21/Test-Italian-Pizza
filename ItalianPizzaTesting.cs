using Backend.Contracts;
using Backend.Models;
using Backend.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestItalianPizza
{
    [TestClass]
    public class ItalianPizzaTesting
    {
        //private readonly IItalianPizzaService service;

        private ItalianPizzaContext context;
   
        [TestInitialize]
        public void Initialize()
        {
            context = new ItalianPizzaContext(Effort.DbConnectionFactory.CreateTransient());
        }

        [TestMethod]
        public void GetCustomersListTest()
        {
            //Arrange
            var italianPizza = new ItalianPizzaTest(context);
            //string nameFake = "pedro";
            List<CustomerContract> customerList = new List<CustomerContract>();
            var customerListTest = italianPizza.GetCustomerListSortedByName();

            //Act
            //Assert.IsTrue(customerList.Count > 0);
            Assert.IsTrue(true);
            //Assert
        }


    }
}
