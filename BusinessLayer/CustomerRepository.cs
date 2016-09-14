using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;

            var customers = from c in customerList
                            where c.CustomerId == customerId
                            select c;

            foundCustomer = customers.First();
            return foundCustomer;
        }


        public List<Customer> Retrieve()
        {
            List<Customer> custList = new List<Customer>
            {
                new Customer() {CustomerId = 1, FirstName = "Frodo", LastName = "Baggins", EmailAddress = "fb@hob.me", CustomerTypeId = 1},
                new Customer() {CustomerId = 2, FirstName = "Bilbo", LastName = "Baggins", EmailAddress = "bb@hob.me", CustomerTypeId = null},
                new Customer() {CustomerId = 3, FirstName = "Samewise", LastName = "Gamee", EmailAddress = "sg@hob.me", CustomerTypeId = 1},
                new Customer() {CustomerId = 4, FirstName = "Rosie", LastName = "Cotton", EmailAddress = "rc@hob.me", CustomerTypeId = 2}
            };

            return custList;
        }
    }
}
