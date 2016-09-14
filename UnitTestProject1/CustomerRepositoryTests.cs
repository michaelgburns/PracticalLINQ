using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;

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
    }
}
