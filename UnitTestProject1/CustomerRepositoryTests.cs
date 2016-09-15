using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void FindExistingCustomer()
        {
            //Arrange 
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act
            var result = repository.Find(customerList, 2);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("Bilbo", result.FirstName);

        }

        [TestMethod]
        public void TestNotFound()
        {
            //Arrange 
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act
            var result = repository.Find(customerList, 42);

            //Assert
            Assert.IsNull(result);

        }

        [TestMethod]
        public void SortByName()
        {
            //Arrange 
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act
            var result = repository.SortByName(customerList);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);

        }
    }
}
